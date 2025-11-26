using VRChat.API.Client;
using VRChat.API.Model;

namespace VRChat.API.Examples.Console
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
                .WithApplication(name: "Example", version: "1.0.0", contact: "contact@vrchat.community")
                .Build();

            var currentUser = await vrchat.LoginAsync();
            System.Console.WriteLine($"Logged in as {currentUser.DisplayName}!");

            var user = await vrchat.Users.GetUserAsync("usr_f2049d71-e76b-42d2-a8bd-43deec9c004e");
            System.Console.WriteLine($"Found user {user.DisplayName}, joined at {user.DateJoined}");

            var world = await vrchat.Worlds.GetWorldAsync("wrld_ba913a96-fac4-4048-a062-9aa5db092812");
            System.Console.WriteLine($"Found world {world.Name}, with {world.Visits} visits");

            System.Console.ReadLine();
        }
    }
}