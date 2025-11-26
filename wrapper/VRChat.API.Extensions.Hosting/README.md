![](https://raw.githubusercontent.com/vrchatapi/vrchatapi.github.io/main/static/assets/img/lang/lang_csharp_banner_1500x300.png)

# VRChat API Library for .NET

A .NET client to interact with the unofficial VRChat API. Supports all REST calls specified in https://github.com/vrchatapi/specification.

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

## Getting Started with Depedency Injection

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

ASP.NET Core (depedency injection): see [VRChat.API.Examples.AspNetCore](examples/VRChat.API.Examples.AspNetCore/)

## Contributing

Contributions are welcome, but do not add features that should be handled by the OpenAPI specification.

Join the [Discord server](https://discord.gg/Ge2APMhPfD) to get in touch with us.
