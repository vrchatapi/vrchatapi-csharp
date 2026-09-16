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

        // Profile fields (bio, bio links, badges, ...) are no longer part of CurrentUser.
        // They live behind getPublicProfile; asSelf includes the owner-only view.
        var profile = await _vrchat.Users.GetPublicProfileAsync(user.Id, asSelf: true);

        return Ok(new
        {
            user.Id,
            user.DisplayName,
            user.CurrentAvatarImageUrl,
            profile.Badges,
            profile.Bio,
            profile.BioLinks,
            user.Tags
        });
    }

    [HttpGet]
    [Route("/api/users/{id}")]
    public async Task<IActionResult> GetUserByIdAsync(string id)
    {
        var user = await _vrchat.Users.GetUserAsync(id);

        // User no longer carries the profile or current-avatar fields; fetch them from the
        // public profile instead.
        var profile = await _vrchat.Users.GetPublicProfileAsync(id);

        return Ok(new
        {
            user.Id,
            user.DisplayName,
            profile.CurrentAvatarImageUrl,
            profile.Badges,
            profile.Bio,
            profile.BioLinks,
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
