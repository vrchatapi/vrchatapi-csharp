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
dotnet add package VRChat.API --version <LATEST_VERSION>

# Or with Package Manager
Install-Package VRChat.API -Version <LATEST_VERSION>
```

## Getting Started

The following example code authenticates you with the API, fetches your join-date, and prints the name of a world.

```csharp
using System;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

// Authentication credentials
Configuration Config = new Configuration();
Config.Username = "username";
Config.Password = "password";

// Create instances of API's we'll need
AuthenticationApi AuthApi = new AuthenticationApi(Config);
UsersApi UserApi = new UsersApi(Config);
WorldsApi WorldApi = new WorldsApi(Config);

try
{
    // Calling "GetCurrentUser(Async)" logs you in if you are not already logged in.
    CurrentUser CurrentUser = AuthApi.GetCurrentUser();
    Console.WriteLine("Logged in as {0}, Current Avatar {1}", CurrentUser.DisplayName, CurrentUser.CurrentAvatar);

    User OtherUser = UserApi.GetUser("usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469");
    Console.WriteLine("Found user {0}, joined {1}", OtherUser.DisplayName, OtherUser.DateJoined);

    World World = WorldApi.GetWorld("wrld_ba913a96-fac4-4048-a062-9aa5db092812");
    Console.WriteLine("Found world {0}, visits: {1}", World.Name, World.Visits);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling API: {0}", e.Message);
    Console.WriteLine("Status Code: {0}", e.ErrorCode);
    Console.WriteLine(e.ToString());
}
```

## Documentation

 - [docs](docs/)

## Contributing

Contributions are welcome, but do not add features that should be handled by the OpenAPI specification.

Join the [Discord server](https://discord.gg/Ge2APMhPfD) to get in touch with us.
