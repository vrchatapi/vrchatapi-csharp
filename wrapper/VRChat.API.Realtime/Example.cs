using System;
using System.Threading.Tasks;
using VRChat.API.Realtime;
using VRChat.API.Realtime.Models;

namespace VRChat.API.Realtime.Examples
{
    /// <summary>
    /// Example usage of the VRChat Realtime WebSocket client
    /// </summary>
    public class Example
    {
        public static async Task BasicUsageExample()
        {
            // Create client using builder pattern
            var client = new VRChatRealtimeClientBuilder()
                .WithAuthToken("authcookie_...")
                .WithUserAgent("MyApp/1.0")
                .WithAutoReconnect(AutoReconnectMode.OnDisconnect)
                .Build();

            // Subscribe to connection events
            client.OnConnected += (sender, e) =>
            {
                Console.WriteLine("Connected to VRChat Pipeline!");
            };

            client.OnDisconnected += (sender, e) =>
            {
                Console.WriteLine("Disconnected from VRChat Pipeline");
            };

            client.Log += (sender, e) =>
            {
                Console.WriteLine($"[{e.Level}] {e.Message}");
                if (e.Exception != null)
                {
                    Console.WriteLine($"Exception: {e.Exception}");
                }
            };

            // Subscribe to friend events
            client.OnFriendOnline += (sender, e) =>
            {
                Console.WriteLine($"Friend {e.Message.User?.DisplayName} came online!");
                Console.WriteLine($"  Platform: {e.Message.Platform}");
                Console.WriteLine($"  Location: {e.Message.Location}");
                Console.WriteLine($"  Message Type: {e.Type}");
                // e.RawMessage = full JSON: {"type":"friend-online","content":{...}}
                // e.RawContent = just content: {...}
            };

            client.OnFriendOffline += (sender, e) =>
            {
                Console.WriteLine($"Friend {e.Message.UserId} went offline");
            };

            client.OnFriendLocation += (sender, e) =>
            {
                Console.WriteLine($"Friend {e.Message.User?.DisplayName} changed location");
                Console.WriteLine($"  New location: {e.Message.Location}");
                Console.WriteLine($"  World: {e.Message.WorldId}");
            };

            // Subscribe to notification events
            client.OnNotificationReceived += (sender, e) =>
            {
                Console.WriteLine($"Notification received: {e.Message?.Type}");
            };

            client.OnNotificationV2 += (sender, e) =>
            {
                Console.WriteLine($"V2 Notification: {e.Message.Title}");
                Console.WriteLine($"  Message: {e.Message.Message}");
            };

            // Subscribe to user events
            client.OnUserLocation += (sender, e) =>
            {
                Console.WriteLine($"You changed location to: {e.Message.Location}");
            };

            client.OnUserUpdate += (sender, e) =>
            {
                Console.WriteLine($"Your profile was updated");
                Console.WriteLine($"  Status: {e.Message.User?.Status}");
                Console.WriteLine($"  Bio: {e.Message.User?.Bio}");
            };

            // Subscribe to group events
            client.OnGroupJoined += (sender, e) =>
            {
                Console.WriteLine($"Joined group: {e.Message.GroupId}");
            };

            client.OnGroupMemberUpdated += (sender, e) =>
            {
                Console.WriteLine($"Group member updated: {e.Message.Member?.Id}");
            };

            // Connect to the WebSocket
            await client.ConnectAsync();

            // Keep the application running
            Console.WriteLine("Press any key to disconnect...");
            Console.ReadKey();

            // Disconnect
            await client.DisconnectAsync();
            client.Dispose();
        }

        public static async Task CustomConfigurationExample()
        {
            // Create client with custom configuration
            var config = new VRChatRealtimeConfiguration
            {
                EndpointURL = "wss://pipeline.vrchat.cloud/",
                AuthToken = "authcookie_...",
                UserAgent = "MyCustomApp/2.0",
                AutoReconnectMode = AutoReconnectMode.Every10Minutes
            };

            var client = new VRChatRealtimeClient(config);

            // Subscribe to events and connect
            client.OnConnected += (sender, e) => Console.WriteLine("Connected!");
            
            await client.ConnectAsync();

            // Use the client...

            await client.DisconnectAsync();
            client.Dispose();
        }

        public static async Task AutoReconnectExample()
        {
            var client = new VRChatRealtimeClientBuilder()
                .WithAuthToken("authcookie_...")
                .WithAutoReconnect(AutoReconnectMode.Every20Minutes)
                .Build();

            client.OnAutoReconnecting += (sender, e) =>
            {
                Console.WriteLine("Auto-reconnecting...");
            };

            client.OnConnected += (sender, e) =>
            {
                Console.WriteLine("Connected!");
            };

            await client.ConnectAsync();

            // The client will automatically reconnect every 20 minutes
            // and also reconnect on unexpected disconnections

            await Task.Delay(TimeSpan.FromHours(1));

            await client.DisconnectAsync();
            client.Dispose();
        }

        public static async Task RawDataAccessExample()
        {
            var client = new VRChatRealtimeClientBuilder()
                .WithAuthToken("authcookie_...")
                .WithUserAgent("MyApp/1.0")
                .Build();

            // Access raw WebSocket messages
            client.OnMessageReceived += (sender, e) =>
            {
                Console.WriteLine("=== Raw WebSocket Message ===");
                Console.WriteLine(e.RawMessage); // Full JSON string
            };

            // Access parsed events with raw data
            client.OnFriendOnline += (sender, e) =>
            {
                Console.WriteLine("=== Friend Online Event ===");
                Console.WriteLine($"Typed Message: {e.Message.User?.DisplayName}");
                Console.WriteLine($"Type: {e.Type}");
                Console.WriteLine($"RawMessage (full JSON): {e.RawMessage}");
                Console.WriteLine($"RawContent (content only): {e.RawContent}");
            };

            // Generic event handler for all parsed events
            client.OnEvent += (sender, e) =>
            {
                Console.WriteLine($"Event Type: {e.Type}");
                Console.WriteLine($"Parsed Content Type: {e.Message?.GetType().Name}");
                // Access raw JSON for custom processing
                if (!string.IsNullOrEmpty(e.RawContent))
                {
                    // You can re-parse or log the raw content
                    Console.WriteLine($"Raw Content: {e.RawContent}");
                }
            };

            // Heartbeat monitoring
            client.OnHeartbeat += (sender, e) =>
            {
                Console.WriteLine("Heartbeat sent to keep connection alive");
            };

            await client.ConnectAsync();

            await Task.Delay(TimeSpan.FromMinutes(1));

            await client.DisconnectAsync();
            client.Dispose();
        }
    }
}

