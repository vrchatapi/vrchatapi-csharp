using Microsoft.AspNetCore.Mvc;
using VRChat.API.Client;

namespace VRChat.API.Examples.AspNetCore.Controllers;

public class HomeController : Controller
{
    private readonly IVRChat _vrchat;

    public HomeController(IVRChat vrchat)
    {
        _vrchat = vrchat;
    }

    [HttpGet]
    [Route("/")]
    public IActionResult Index()
    {
        return Ok(new { status = "healthy" });
    }

    [HttpGet]
    [Route("/api/users/current")]
    public async Task<IActionResult> GetCurrentUserAsync()
    {
        var user = await _vrchat.Authentication.GetCurrentUserAsync();

        return Ok(new
        {
            user.Id,
            user.DisplayName,
            user.CurrentAvatarImageUrl,
            user.Badges,
            user.Bio,
            user.BioLinks,
            user.Tags
        });
    }

    [HttpGet]
    [Route("/api/users/{id}")]
    public async Task<IActionResult> GetUserByIdAsync(string id)
    {
        var user = await _vrchat.Users.GetUserAsync(id);

        return Ok(new
        {
            user.Id,
            user.DisplayName,
            user.CurrentAvatarImageUrl,
            user.Badges,
            user.Bio,
            user.BioLinks,
            user.Tags
        });
    }

    [HttpGet]
    [Route("/api/worlds/active")]
    public async Task<IActionResult> GetActiveWorldsAsync()
    {
        var worlds = await _vrchat.Worlds.GetActiveWorldsAsync();

        return Ok(worlds);
    }
}
