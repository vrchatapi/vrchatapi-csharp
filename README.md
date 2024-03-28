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

    if (requiresEmail2FA(currentUserResp)) // If the API wants us to send an Email OTP code
    {
        authApi.Verify2FAEmailCode(new TwoFactorEmailCode("123456"));
    }
    else
    {
        // requiresEmail2FA returned false, so we use secret-based 2fa verification
        // authApi.VerifyRecoveryCode(new TwoFactorAuthCode("12345678")); // To Use a Recovery Code
        authApi.Verify2FA(new TwoFactorAuthCode("123456"));
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

// Function that determines if the api expects email2FA from an ApiResponse
static bool requiresEmail2FA(ApiResponse<CurrentUser> resp)
{
    // We can just use a super simple string.Contains() check
    if (resp.RawContent.Contains("emailOtp"))
    {
        return true;
    }

    return false;
}
```

## Documentation

 - [docs](docs/)

## Contributing

Contributions are welcome, but do not add features that should be handled by the OpenAPI specification.

Join the [Discord server](https://discord.gg/Ge2APMhPfD) to get in touch with us.
