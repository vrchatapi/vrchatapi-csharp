using OtpNet;
using System.Net;
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
                .WithApplication("Example", "1.0.0", "contact@vrchat.community")
                .Build();

            var user = await vrchat.LoginAsync();

            System.Console.WriteLine($"Logged in as {user.DisplayName}!");
            System.Console.ReadLine();
        }
    }
}