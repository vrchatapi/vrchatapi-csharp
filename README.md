![](https://github.com/vrchatapi/vrchatapi.github.io/blob/master/assets/img/lang/lang_csharp_banner_1500x300.png?raw=true)

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

## Getting Started

```csharp
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Client;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
            Console.ReadKey();
        }

        static async Task MainAsync()
        {
            // Configure API key authorization: apiKeyCookie
            Configuration.Default.Username = VRCUsername;
            Configuration.Default.Password = VRCPassword;

            try
            {
                // Calling "GetCurrentUser" will log you in.
                AuthenticationApi authApi = new AuthenticationApi();
                var user = await authApi.GetCurrentUserAsync();
                Console.WriteLine($"Logged in user {user.DisplayName}, Current Avatar {user.CurrentAvatar}");

                UsersApi userApi = new UsersApi();
                var getUser = await userApi.GetUserAsync(user.Id);
                Console.WriteLine($"Found user {getUser.DisplayName}, joined {getUser.DateJoined}");

                WorldsApi worldApi = new WorldsApi();
                var world = await worldApi.GetWorldAsync("wrld_ba913a96-fac4-4048-a062-9aa5db092812");
                Console.WriteLine($"Found world {world.Name}, visits: {world.Visits}");
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling API: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

## Contributing

Contributions are welcome, but do not add features that should be handled by the OpenAPI specification.

Join the [Discord server](https://discord.gg/Ge2APMhPfD) to get in touch with us.