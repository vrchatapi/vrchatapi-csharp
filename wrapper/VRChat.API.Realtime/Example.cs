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
            client.OnFriendOnline += (sender, content) =>
            {
                Console.WriteLine($"Friend {content.User?.DisplayName} came online!");
                Console.WriteLine($"  Platform: {content.Platform}");
                Console.WriteLine($"  Location: {content.Location}");
            };

            client.OnFriendOffline += (sender, content) =>
            {
                Console.WriteLine($"Friend {content.UserId} went offline");
            };

            client.OnFriendLocation += (sender, content) =>
            {
                Console.WriteLine($"Friend {content.User?.DisplayName} changed location");
                Console.WriteLine($"  New location: {content.Location}");
                Console.WriteLine($"  World: {content.WorldId}");
            };

            // Subscribe to notification events
            client.OnNotificationReceived += (sender, e) =>
            {
                Console.WriteLine($"Notification received: {e.Notification?.Type}");
            };

            client.OnNotificationV2 += (sender, content) =>
            {
                Console.WriteLine($"V2 Notification: {content.Title}");
                Console.WriteLine($"  Message: {content.Message}");
            };

            // Subscribe to user events
            client.OnUserLocation += (sender, content) =>
            {
                Console.WriteLine($"You changed location to: {content.Location}");
            };

            client.OnUserUpdate += (sender, content) =>
            {
                Console.WriteLine($"Your profile was updated");
                Console.WriteLine($"  Status: {content.User?.Status}");
                Console.WriteLine($"  Bio: {content.User?.Bio}");
            };

            // Subscribe to group events
            client.OnGroupJoined += (sender, content) =>
            {
                Console.WriteLine($"Joined group: {content.GroupId}");
            };

            client.OnGroupMemberUpdated += (sender, content) =>
            {
                Console.WriteLine($"Group member updated: {content.Member?.Id}");
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
    }
}

