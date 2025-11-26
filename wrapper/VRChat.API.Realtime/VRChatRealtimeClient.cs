using System;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using VRChat.API.Realtime.Models;
using VRChat.API.Realtime.Messages;

namespace VRChat.API.Realtime
{
    public interface IVRChatRealtime
    {
        // Connection Events
        event EventHandler<LogEventArgs> Log;
        event EventHandler OnDisconnected;
        event EventHandler OnConnected;
        event EventHandler OnAutoReconnecting;

        // Notification Events (legacy)
        event EventHandler<NotificationEventArgs> OnNotification;

        // Notification Events
        event EventHandler<NotificationEventArgs> OnNotificationReceived;
        event EventHandler<ResponseNotificationContent> OnResponseNotification;
        event EventHandler<SeeNotificationEventArgs> OnSeeNotification;
        event EventHandler<HideNotificationEventArgs> OnHideNotification;
        event EventHandler OnClearNotification;
        event EventHandler<NotificationV2Content> OnNotificationV2;
        event EventHandler<NotificationV2UpdateContent> OnNotificationV2Update;
        event EventHandler<NotificationV2DeleteContent> OnNotificationV2Delete;

        // Friend Events
        event EventHandler<FriendAddContent> OnFriendAdd;
        event EventHandler<FriendDeleteContent> OnFriendDelete;
        event EventHandler<FriendOnlineContent> OnFriendOnline;
        event EventHandler<FriendActiveContent> OnFriendActive;
        event EventHandler<FriendOfflineContent> OnFriendOffline;
        event EventHandler<FriendUpdateContent> OnFriendUpdate;
        event EventHandler<FriendLocationContent> OnFriendLocation;

        // User Events
        event EventHandler<UserUpdateContent> OnUserUpdate;
        event EventHandler<UserLocationContent> OnUserLocation;
        event EventHandler<UserBadgeAssignedContent> OnUserBadgeAssigned;
        event EventHandler<UserBadgeUnassignedContent> OnUserBadgeUnassigned;
        event EventHandler<ContentRefreshContent> OnContentRefresh;
        event EventHandler<ModifiedImageUpdateContent> OnModifiedImageUpdate;
        event EventHandler<InstanceQueueJoinedContent> OnInstanceQueueJoined;
        event EventHandler<InstanceQueueReadyContent> OnInstanceQueueReady;

        // Group Events
        event EventHandler<GroupJoinedContent> OnGroupJoined;
        event EventHandler<GroupLeftContent> OnGroupLeft;
        event EventHandler<GroupMemberUpdatedContent> OnGroupMemberUpdated;
        event EventHandler<GroupRoleUpdatedContent> OnGroupRoleUpdated;

        // Methods
        Task ConnectAsync(CancellationToken cancellationToken = default);
        Task DisconnectAsync();
        bool IsConnected { get; }
    }

    public partial class VRChatRealtimeClient : IVRChatRealtime, IDisposable
    {
        private readonly VRChatRealtimeConfiguration _configuration;
        private ClientWebSocket _client;
        private Timer _reconnectTimer;
        private Timer _heartbeatTimer;
        private CancellationTokenSource _receiveCts;
        private Task _receiveTask;
        private bool _isManualDisconnect;
        private bool _disposed;
        private readonly SemaphoreSlim _sendLock = new SemaphoreSlim(1, 1);

        // Connection Events
        public event EventHandler<LogEventArgs> Log;
        public event EventHandler OnDisconnected;
        public event EventHandler OnConnected;
        public event EventHandler OnAutoReconnecting;

        // Notification Events (legacy)
        public event EventHandler<NotificationEventArgs> OnNotification;

        // Notification Events
        public event EventHandler<NotificationEventArgs> OnNotificationReceived;
        public event EventHandler<ResponseNotificationContent> OnResponseNotification;
        public event EventHandler<SeeNotificationEventArgs> OnSeeNotification;
        public event EventHandler<HideNotificationEventArgs> OnHideNotification;
        public event EventHandler OnClearNotification;
        public event EventHandler<NotificationV2Content> OnNotificationV2;
        public event EventHandler<NotificationV2UpdateContent> OnNotificationV2Update;
        public event EventHandler<NotificationV2DeleteContent> OnNotificationV2Delete;

        // Friend Events
        public event EventHandler<FriendAddContent> OnFriendAdd;
        public event EventHandler<FriendDeleteContent> OnFriendDelete;
        public event EventHandler<FriendOnlineContent> OnFriendOnline;
        public event EventHandler<FriendActiveContent> OnFriendActive;
        public event EventHandler<FriendOfflineContent> OnFriendOffline;
        public event EventHandler<FriendUpdateContent> OnFriendUpdate;
        public event EventHandler<FriendLocationContent> OnFriendLocation;

        // User Events
        public event EventHandler<UserUpdateContent> OnUserUpdate;
        public event EventHandler<UserLocationContent> OnUserLocation;
        public event EventHandler<UserBadgeAssignedContent> OnUserBadgeAssigned;
        public event EventHandler<UserBadgeUnassignedContent> OnUserBadgeUnassigned;
        public event EventHandler<ContentRefreshContent> OnContentRefresh;
        public event EventHandler<ModifiedImageUpdateContent> OnModifiedImageUpdate;
        public event EventHandler<InstanceQueueJoinedContent> OnInstanceQueueJoined;
        public event EventHandler<InstanceQueueReadyContent> OnInstanceQueueReady;

        // Group Events
        public event EventHandler<GroupJoinedContent> OnGroupJoined;
        public event EventHandler<GroupLeftContent> OnGroupLeft;
        public event EventHandler<GroupMemberUpdatedContent> OnGroupMemberUpdated;
        public event EventHandler<GroupRoleUpdatedContent> OnGroupRoleUpdated;

        public bool IsConnected => _client?.State == WebSocketState.Open;

        public VRChatRealtimeClient(VRChatRealtimeConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            
            if (string.IsNullOrWhiteSpace(_configuration.AuthToken))
                throw new ArgumentException("AuthToken is required", nameof(configuration));
        }

        public async Task ConnectAsync(CancellationToken cancellationToken = default)
        {
            if (_client?.State == WebSocketState.Open)
            {
                LogMessage(LogLevel.Warning, "Already connected to VRChat WebSocket");
                return;
            }

            try
            {
                _isManualDisconnect = false;
                _receiveCts?.Cancel();
                _receiveCts?.Dispose();
                _receiveCts = new CancellationTokenSource();

                var url = $"{_configuration.EndpointURL.TrimEnd('/')}/?authToken={_configuration.AuthToken}";
                
                _client?.Dispose();
                _client = new ClientWebSocket();
                
                if (!string.IsNullOrWhiteSpace(_configuration.UserAgent))
                {
                    _client.Options.SetRequestHeader("User-Agent", _configuration.UserAgent);
                }

                await _client.ConnectAsync(new Uri(url), cancellationToken);

                LogMessage(LogLevel.Info, "Connected to VRChat WebSocket");
                OnConnected?.Invoke(this, EventArgs.Empty);

                // Start receiving messages
                _receiveTask = ReceiveLoop(_receiveCts.Token);

                // Setup periodic reconnect timer
                SetupReconnectTimer();

                // Setup heartbeat timer (every 30 seconds)
                SetupHeartbeatTimer();
            }
            catch (Exception ex)
            {
                LogMessage(LogLevel.Error, $"Failed to connect to VRChat WebSocket: {ex.Message}", ex);
                throw;
            }
        }

        public async Task DisconnectAsync()
        {
            _isManualDisconnect = true;
            
            // Stop timers
            _reconnectTimer?.Dispose();
            _reconnectTimer = null;
            _heartbeatTimer?.Dispose();
            _heartbeatTimer = null;

            // Cancel receiving
            _receiveCts?.Cancel();

            if (_client != null && _client.State == WebSocketState.Open)
            {
                try
                {
                    await _client.CloseAsync(WebSocketCloseStatus.NormalClosure, "Client disconnecting", CancellationToken.None);
                }
                catch (Exception ex)
                {
                    LogMessage(LogLevel.Warning, $"Error during disconnect: {ex.Message}", ex);
                }
            }

            _client?.Dispose();
            _client = null;

            if (_receiveTask != null)
            {
                try
                {
                    await _receiveTask;
                }
                catch (OperationCanceledException)
                {
                    // Expected
                }
                catch (Exception ex)
                {
                    LogMessage(LogLevel.Warning, $"Error waiting for receive task: {ex.Message}", ex);
                }
            }

            LogMessage(LogLevel.Info, "Disconnected from VRChat WebSocket");
        }

        private async Task ReceiveLoop(CancellationToken cancellationToken)
        {
            var buffer = new byte[8192];
            var messageBuffer = new StringBuilder();

            try
            {
                while (!cancellationToken.IsCancellationRequested && _client.State == WebSocketState.Open)
                {
                    WebSocketReceiveResult result;
                    messageBuffer.Clear();

                    do
                    {
                        result = await _client.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);
                        
                        if (result.MessageType == WebSocketMessageType.Close)
                        {
                            await HandleDisconnection();
                            return;
                        }

                        messageBuffer.Append(Encoding.UTF8.GetString(buffer, 0, result.Count));
                    }
                    while (!result.EndOfMessage);

                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        var message = messageBuffer.ToString();
                        HandleMessage(message);
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // Expected when cancelling
            }
            catch (WebSocketException ex)
            {
                LogMessage(LogLevel.Error, $"WebSocket error: {ex.Message}", ex);
                await HandleDisconnection();
            }
            catch (Exception ex)
            {
                LogMessage(LogLevel.Error, $"Receive loop error: {ex.Message}", ex);
                await HandleDisconnection();
            }
        }

        private async Task SendHeartbeatAsync()
        {
            if (_client?.State != WebSocketState.Open)
                return;

            try
            {
                var heartbeat = new HeartbeatMessage
                {
                    Nonce = Guid.NewGuid().ToString()
                };

                var json = JsonSerializer.Serialize(heartbeat);
                var bytes = Encoding.UTF8.GetBytes(json);

                await _sendLock.WaitAsync();
                try
                {
                    await _client.SendAsync(
                        new ArraySegment<byte>(bytes),
                        WebSocketMessageType.Text,
                        true,
                        CancellationToken.None);

                    LogMessage(LogLevel.Trace, $"Heartbeat sent: {heartbeat.Nonce}");
                }
                finally
                {
                    _sendLock.Release();
                }
            }
            catch (Exception ex)
            {
                LogMessage(LogLevel.Warning, $"Failed to send heartbeat: {ex.Message}", ex);
            }
        }

        private void SetupReconnectTimer()
        {
            _reconnectTimer?.Dispose();

            TimeSpan? interval = _configuration.AutoReconnectMode switch
            {
                AutoReconnectMode.Every10Minutes => TimeSpan.FromMinutes(10),
                AutoReconnectMode.Every20Minutes => TimeSpan.FromMinutes(20),
                AutoReconnectMode.Every30Minutes => TimeSpan.FromMinutes(30),
                _ => null
            };

            if (interval.HasValue)
            {
                _reconnectTimer = new Timer(async _ =>
                {
                    try
                    {
                        OnAutoReconnecting?.Invoke(this, EventArgs.Empty);
                        LogMessage(LogLevel.Info, $"Auto-reconnecting (mode: {_configuration.AutoReconnectMode})");
                        
                        await DisconnectAsync();
                        await Task.Delay(150); // Brief delay before reconnecting
                        await ConnectAsync();
                    }
                    catch (Exception ex)
                    {
                        LogMessage(LogLevel.Error, $"Auto-reconnect failed: {ex.Message}", ex);
                    }
                }, null, interval.Value, interval.Value);
            }
        }

        private void SetupHeartbeatTimer()
        {
            _heartbeatTimer?.Dispose();

            _heartbeatTimer = new Timer(async _ =>
            {
                await SendHeartbeatAsync();
            }, null, TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(30));
        }

        private void HandleMessage(string json)
        {
            try
            {
                LogMessage(LogLevel.Trace, $"Received message: {json}");

                using var document = JsonDocument.Parse(json);
                var root = document.RootElement;

                if (!root.TryGetProperty("type", out var typeElement))
                {
                    LogMessage(LogLevel.Warning, "Received message without type field");
                    return;
                }

                var messageType = typeElement.GetString();
                if (string.IsNullOrEmpty(messageType))
                {
                    LogMessage(LogLevel.Warning, "Received message with empty type");
                    return;
                }

                ProcessMessage(messageType, json);
            }
            catch (Exception ex)
            {
                LogMessage(LogLevel.Error, $"Error processing message: {ex.Message}", ex);
            }
        }

        private async Task HandleDisconnection()
        {
            LogMessage(LogLevel.Info, "WebSocket disconnected");
            OnDisconnected?.Invoke(this, EventArgs.Empty);

            if (!_isManualDisconnect && _configuration.AutoReconnectMode >= AutoReconnectMode.OnDisconnect)
            {
                await Task.Run(async () =>
                {
                    try
                    {
                        OnAutoReconnecting?.Invoke(this, EventArgs.Empty);
                        LogMessage(LogLevel.Info, "Attempting to reconnect...");
                        await Task.Delay(2000); // Wait 2 seconds before reconnecting
                        await ConnectAsync();
                    }
                    catch (Exception ex)
                    {
                        LogMessage(LogLevel.Error, $"Reconnection failed: {ex.Message}", ex);
                    }
                });
            }
        }

        private void LogMessage(LogLevel level, string message, Exception exception = null)
        {
            Log?.Invoke(this, new LogEventArgs
            {
                Level = level,
                Message = message,
                Exception = exception
            });
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _reconnectTimer?.Dispose();
                _heartbeatTimer?.Dispose();
                _receiveCts?.Cancel();
                _receiveCts?.Dispose();
                _client?.Dispose();
                _sendLock?.Dispose();
                _disposed = true;
            }
        }
    }
}
