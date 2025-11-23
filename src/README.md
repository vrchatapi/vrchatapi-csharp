![](https://raw.githubusercontent.com/vrchatapi/vrchatapi.github.io/main/static/assets/img/lang/lang_csharp_banner_1500x300.png)

# VRChat API Library for C#

A C# client to interact with the unofficial VRChat API. Supports all REST calls specified in https://github.com/vrchatapi/specification.

## Disclaimer

This is the official response of the VRChat Team (from Tupper more specifically) on the usage of the VRChat API.

> Use of the API using applications other than the approved methods (website, VRChat application) are not officially supported. You may use the API for your own application, but keep these guidelines in mind:
> * We do not provide documentation or support for the API.
> * Do not make queries to the API more than once per 60 seconds.
> * Abuse of the API may result in account termination.
> * Access to API endpoints may break at any given time, with no warning.

As stated, this documentation was not created with the help of the official VRChat team. Therefore this documentation is not an official documentation of the VRChat API and may not be always up to date with the latest versions. If you find that a page or endpoint is not longer valid please create an issue and tell us so we can fix it.

## Installation

Install with NuGet:

```bash
# With .NET CLI
dotnet add package VRChat.API

# Or with Package Manager
Install-Package VRChat.API
```

If you're working with Depedency Injection like ASP.NET Core or Discord.Net, make sure to also install the DI package

```bash
# With .NET CLI
dotnet add package VRChat.API.Extensions.Hosting

# Or with Package Manager
Install-Package VRChat.API.Extensions.Hosting
```

## Getting Started

The following example code authenticates you with the API, fetches your join-date, and prints the name of a world.

```cs
using System;
using VRChat.API.Client;

// WithApplication or WithUserAgent is required or VRChat will reject your requests
IVRChat vrchat = new VRChatClientBuilder() // More options available
    .WithUsername("username")
    .WithPassword("password")
    .WithTwoFactorSecret("twoFactorSecret") 
    .WithApplication("APP_NAME", "1.0.0", "CONTACT_EMAIL")
    .Build();

// Reccomended to set up 2FA on your account for seamless login

// There is also IVRChat.TryLoginAsync()
// Set throwOnFail to false if you want no errors
var user = await vrchat.LoginAsync(throwOnFail: true);

if (user == null)
{
    Console.WriteLine("Failed to login to VRChat!");
}
else
{
    Console.WriteLine($"Logged in as {user.DisplayName}!");
}
```

The builder is quite flexible and will let you customize as you see fit.

# Cookies

You can fetch the cookies that the API client has using the `IVRChat.GetCookies()` method.

```cs
var cookies = vrchat.GetCookies(); // List<Cookie>
```

You can set the cookies yourself by attaching them during the client building process.

```cs
IVRChat vrchat = new VRChatClientBuilder()
    .WithUsername("username")
    .WithPassword("password")
    .WithTwoFactorSecret("twoFactorSecret") 
    .WithApplication("APP_NAME", "1.0.0", "CONTACT_EMAIL")
    .WithAuthCookie("auth cookie", "twoFactorAuth cookie")
    .Build();
```

# Depedency Injection

Working with Microsoft DI is easy, after installing the DI package `VRChat.API.Extensions.Hosting`, you can easily attach it to your .NET DI Host, including ASP.NET Core, .NET Aspire, and Discord.Net

```cs
// assuming you have a IServiceCollection services defined somewhere

// Fluent builder
services.AddVRChat(builder => builder.WithUsername("username"));

// Named clients
services.AddVRChat("WorldsClient", builder => builder.WithUsername("username"))

// Loading from IConfiguration (supports env, file, and user-secrets)
services.AddVRChat(builder.Configuration.GetSection("VRChat"))
```

To see the available options for loading from an IConfiguration see [VRChatOptions.cs](/wrapper//VRChat.API.Extensions.Hosting/VRChatOptions.cs)

# Working with named clients

Instead of requesting an `IVRChat` from services, you will request an `IVRChatClientFactory`. Unnamed clients will have a default name of `vrc_default` and registering multiple will overwrite the previous one.

```cs
public class MyController : Controller
{
    [HttpGet("/worlds/active")]
    public async Task<IActionResult> GetActiveWorldsAsync([FromServices] IVRChatClientFactory factory)
    {
        var vrchat = factory.CreateClient("WorldsClient");

        var worlds = await vrchat.Worlds.GetActiveWorldsAsync();

        return Ok(worlds);
    }
}
```

# Example Projects

Console app (login): see [VRChat.API.Examples.Console](examples/VRChat.API.Examples.Console/)

ASP.NET Core (depedency injection): see [VRChat.API.Examples.AspNetCore](examples/VRChat.API.Examples.AspNetCore/)

# Working with the raw generated wrapper yourself

The following example code showcases how you can work with the raw generated library yourself. 

This is not the reccomended way but can be used for very specific use cases.

```csharp
using System;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

// Create a configuration for us to log in
Configuration config = new Configuration();
config.Username = "Username";
config.Password = "Password";

// We have to identify ourselves according to the vrchat tos,
// We can't use emails here bc http header parser complains
config.UserAgent = "ExampleProgram/0.0.1 mydiscordusername"; 

// Create a client to hold all our cookies :D
ApiClient client = new ApiClient();

// Create an instance of the auth api so we can verify and log in
AuthenticationApi authApi = new AuthenticationApi(client, client, config);

// We also need to create instances of the other APIs we'll need
UsersApi userApi = new UsersApi(client, client, config);
WorldsApi worldApi = new WorldsApi(client, client, config);

try
{
    // Our first request we get the ApiResponse instead of just the user object,
    // so we can see what the API expects from us
    ApiResponse<CurrentUser> currentUserResp = authApi.GetCurrentUserWithHttpInfo();

    if(currentUserResp.Data.RequiresTwoFactorAuth?.Count > 0)
    {
        if (currentUserResp.Data.RequiresTwoFactorAuth.Contains("emailOtp")) // If the API wants us to send an Email OTP code
        {
            authApi.Verify2FAEmailCode(new TwoFactorEmailCode("123456"));
        }
        else if(currentUserResp.Data.RequiresTwoFactorAuth.Contains("totp"))
        {
            // authApi.VerifyRecoveryCode(new TwoFactorAuthCode("12345678")); // To Use a Recovery Code
            authApi.Verify2FA(new TwoFactorAuthCode("123456"));
        }
    }

    // We can now get our CurrentUser :D
    CurrentUser currentUser = authApi.GetCurrentUser();
    Console.WriteLine("Logged in as {0}", currentUser.DisplayName);

    User user = userApi.GetUser("usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469");
    Console.WriteLine("Found user {0}, joined {1}", user.DisplayName, user.DateJoined);

    World world = worldApi.GetWorld("wrld_ba913a96-fac4-4048-a062-9aa5db092812");
    Console.WriteLine("Found world {0}, visits: {1}", world.Name, world.Visits);
} 
catch (ApiException ex)
{
    // Catch any exceptions write to console, helps w debugging :D
    Console.WriteLine("Exception when calling API: {0}", ex.Message);
    Console.WriteLine("Status Code: {0}", ex.ErrorCode);
    Console.WriteLine(ex.ToString());
}
```

## Cookies (Generated API)
Cookies can be displayed after logging in using:
```csharp
ApiClient.CookieContainer.GetAllCookies().ToList().ForEach(x => Console.WriteLine($"{x.Name}={x.Value}"));
```

And they can be used by editing the config at the start of your program like this:
```csharp
config.DefaultHeaders.Add("Cookie", "auth=[AUTH_COOKIE_HERE]; twoFactorAuth=[TWO_FACTOR_AUTH_COOKIE_HERE]");
```

## Documentation

 - [docs](docs/)

## Contributing

Contributions are welcome, but do not add features that should be handled by the OpenAPI specification.

Join the [Discord server](https://discord.gg/Ge2APMhPfD) to get in touch with us.
