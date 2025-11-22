using VRChat.API.Client;

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
                .WithApplication("VRChatAPIExample", "1.0.0", "contact@vrchat.community")
                .Build();

            var user = await vrchat.LoginAsync(throwOnFail: true);

            if (user == null)
            {
                System.Console.WriteLine("Failed to login to VRChat!");
            }
            else
            {
                System.Console.WriteLine($"Logged in as {user.DisplayName}!");
            }

            System.Console.ReadLine();
        }
    }
}