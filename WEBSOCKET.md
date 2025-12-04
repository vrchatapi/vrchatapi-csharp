![](https://raw.githubusercontent.com/vrchatapi/vrchatapi.github.io/main/static/assets/img/lang/lang_csharp_banner_1500x300.png)

# VRChat API Library for .NET

A .NET client to interact with the unofficial VRChat API. Supports all REST calls specified in https://github.com/vrchatapi/specification.

This documentation covers how to use the WebSocket (Pipeline) API with VRChat.

## Installation

Install with NuGet:

```bash
# With .NET CLI
dotnet add package VRChat.API.Realtime

# Or with Package Manager
Install-Package VRChat.API.Realtime
```

## Getting Started

The following example code authenticates you with the API, and starts listenting to some events.

```cs
using System;
using VRChat.API.Realtime;

string authToken = Environment.GetEnvironmentVariable("VRCHAT_AUTH_TOKEN");
// You can also use IVRChat.GetCookies() and grab the cookies from your IVRChat instance.
// Example: vrchat.GetCookies().FirstOrDefault(c => c.Name == "auth")?.Value;

// WithApplication or WithUserAgent is required or VRChat will reject your requests
IVRChatRealtime realtime = new VRChatRealtimeClientBuilder()
    .WithAuthToken(authToken)
    .WithAutoReconnect(AutoReconnectMode.OnDisconnect)
    .WithApplication(name: "Example", version: "1.0.0", contact: "youremail.com")
    .Build();

realtime.OnConnected += (sender, e) =>
{
    Console.WriteLine("Connected to VRChat Realtime WebSocket!");
};

realtime.OnFriendOnline += (sender, e) =>
{
    Console.WriteLine($"Friend {e.Message.User.DisplayName} is now online!");
};

realtime.OnFriendOffline += (sender, e) =>
{
    Console.WriteLine($"Friend {e.Message.UserId} is now offline!");
};

realtime.OnFriendLocation += (sender, e) =>
{
    Console.WriteLine($"Friend {e.Message.User.DisplayName} is now in {e.Message.Location}!");
};

await realtime.ConnectAsync();
```

# Example Projects

Console app (login and listen to events): see [VRChat.API.Examples.WebSocket](examples/VRChat.API.Examples.WebSocket/)

## Contributing

Contributions are welcome, but do not add features that should be handled by the OpenAPI specification.

Join the [Discord server](https://discord.gg/Ge2APMhPfD) to get in touch with us.
