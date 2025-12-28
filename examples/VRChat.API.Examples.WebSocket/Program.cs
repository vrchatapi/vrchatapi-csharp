using VRChat.API.Client;
using VRChat.API.Model;
using VRChat.API.Realtime;

namespace VRChat.API.Examples.WebSocket
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            string username = Environment.GetEnvironmentVariable("VRCHAT_USERNAME");
            string password = Environment.GetEnvironmentVariable("VRCHAT_PASSWORD");
            string twoFactorSecret = Environment.GetEnvironmentVariable("VRCHAT_TWO_FACTOR_SECRET");

            IVRChat vrchat = new VRChatClientBuilder()
                .WithUsername(username)
                .WithPassword(password)
                .WithTwoFactorSecret(twoFactorSecret)
                .WithApplication(name: "Example", version: "1.0.0", contact: "youremail.com")
                .Build();

            var currentUser = await vrchat.LoginAsync();
            Console.WriteLine($"Logged in as {currentUser.DisplayName}!");

            var authToken = vrchat.GetCookies().FirstOrDefault(c => c.Name == "auth")?.Value;

            IVRChatRealtime realtime = new VRChatRealtimeClientBuilder()
                .WithAuthToken(authToken)
                .WithApplication(name: "Example", version: "1.0.0", contact: "youremail.com")
                .Build();

            realtime.OnConnected += (sender, e) =>
            {
                Console.WriteLine("Connected to VRChat Realtime WebSocket!");
            };

            realtime.OnFriendOnline += (sender, e) =>
            {
                Console.WriteLine($"Friend {e.Message.User.DisplayName} is now online!");
            };

            realtime.OnFriendOffline += (sender, e) =>
            {
                Console.WriteLine($"Friend {e.Message.UserId} is now offline!");
            };

            realtime.OnFriendLocation += (sender, e) =>
            {
                Console.WriteLine($"Friend {e.Message.User.DisplayName} is now in {e.Message.Location}!");
            };

            await realtime.ConnectAsync();

            Console.ReadLine();

            await realtime.DisconnectAsync();
            realtime.Dispose();
        }
    }
}