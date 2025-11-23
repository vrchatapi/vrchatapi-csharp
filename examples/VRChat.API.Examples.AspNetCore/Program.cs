using VRChat.API.Client;
using VRChat.API.Extensions.Hosting;

namespace VRChat.API.Examples.AspNetCore
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddVRChat(builder.Configuration.GetSection("VRChat"));

            var app = builder.Build();

            var logger = app.Services.GetRequiredService<ILogger<Program>>();
            var vrchat = app.Services.GetRequiredService<IVRChat>();
            var user = await vrchat.LoginAsync(throwOnFail: true);

            logger.LogInformation("Logged into VRChat as {user} ({id})", user.DisplayName, user.Id);

            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
