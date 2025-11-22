namespace VRChat.API.Examples.Console
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            string username = Environment.GetEnvironmentVariable("VRCHAT_USERNAME");
            string password = Environment.GetEnvironmentVariable("VRCHAT_PASSWORD");
            string twoFactorSecret = Environment.GetEnvironmentVariable("VRCHAT_TWO_FACTOR_SECRET");

        }
    }
}