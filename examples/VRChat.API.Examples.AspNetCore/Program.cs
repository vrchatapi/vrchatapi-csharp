using VRChat.API.Extensions.Hosting;

namespace VRChat.API.Examples.AspNetCore
{
    public class Program
    {
        public async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddVRChat(builder.Configuration.GetSection("VRChat"));

            var app = builder.Build();

            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
