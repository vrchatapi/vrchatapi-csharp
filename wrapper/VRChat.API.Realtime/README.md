![](https://raw.githubusercontent.com/vrchatapi/vrchatapi.github.io/main/static/assets/img/lang/lang_csharp_banner_1500x300.png)

# VRChat Realtime WebSocket API for .NET

A .NET client for VRChat's Realtime WebSocket API (Pipeline). Receive real-time updates about notifications, friends, user status, and more.

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
dotnet add package VRChat.API.Realtime

# Or with Package Manager
Install-Package VRChat.API.Realtime
```

## Features

- ✅ **Real-time WebSocket connection** to VRChat Pipeline
- ✅ **All event types supported**: Notifications, Friends, User, Groups
- ✅ **Auto-reconnect modes**: On disconnect, every 10/20/30 minutes
- ✅ **Strongly-typed event arguments** for all events
- ✅ **Fluent builder pattern** for easy configuration
- ✅ **Full async/await support**
- ✅ **Logging events** for debugging

## Quick Start

```cs
using VRChat.API.Realtime;
using VRChat.API.Realtime.Models;

// Create client using builder pattern
var client = new VRChatRealtimeClientBuilder()
    .WithAuthToken("authcookie_...")
    .WithUserAgent("MyApp/1.0")
    .WithAutoReconnect(AutoReconnectMode.OnDisconnect)
    .Build();

// Subscribe to events
client.OnConnected += (sender, e) =>
{
    Console.WriteLine("Connected to VRChat Pipeline!");
};

client.OnFriendOnline += (sender, e) =>
{
    Console.WriteLine($"Friend {e.User?.DisplayName} came online!");
};

client.OnNotificationReceived += (sender, e) =>
{
    Console.WriteLine($"Notification: {e.Notification?.Type}");
};

// Connect
await client.ConnectAsync();

// Keep running...
Console.ReadKey();

// Disconnect
await client.DisconnectAsync();
client.Dispose();
```

## Configuration

### Using Builder Pattern

```cs
var client = new VRChatRealtimeClientBuilder()
    .WithEndpoint("wss://pipeline.vrchat.cloud/")
    .WithAuthToken("authcookie_...")
    .WithUserAgent("MyApp/1.0")
    .WithAutoReconnect(AutoReconnectMode.Every10Minutes)
    .Build();
```

### Using Configuration Object

```cs
var config = new VRChatRealtimeConfiguration
{
    EndpointURL = "wss://pipeline.vrchat.cloud/",
    AuthToken = "authcookie_...",
    UserAgent = "MyApp/1.0",
    AutoReconnectMode = AutoReconnectMode.OnDisconnect
};

var client = new VRChatRealtimeClient(config);
```

## Auto-Reconnect Modes

- **None**: Do not automatically reconnect
- **OnDisconnect**: Reconnect when disconnected unexpectedly
- **Every10Minutes**: Reconnect every 10 minutes
- **Every20Minutes**: Reconnect every 20 minutes  
- **Every30Minutes**: Reconnect every 30 minutes

## Available Events

### Connection Events
- `OnConnected` - Connected to WebSocket
- `OnDisconnected` - Disconnected from WebSocket
- `OnAutoReconnecting` - Auto-reconnect triggered
- `Log` - Log messages with levels (Trace, Debug, Info, Warning, Error, Critical)

### Notification Events
- `OnNotificationReceived` - Standard notification
- `OnResponseNotification` - Response to previous notification
- `OnSeeNotification` - Mark notification as seen
- `OnHideNotification` - Hide notification
- `OnClearNotification` - Clear all notifications
- `OnNotificationV2` - V2 notification system
- `OnNotificationV2Update` - Update V2 notification
- `OnNotificationV2Delete` - Delete V2 notifications

### Friend Events
- `OnFriendAdd` - Friend added
- `OnFriendDelete` - Friend removed
- `OnFriendOnline` - Friend came online
- `OnFriendActive` - Friend active on website
- `OnFriendOffline` - Friend went offline
- `OnFriendUpdate` - Friend profile updated
- `OnFriendLocation` - Friend changed location

### User Events
- `OnUserUpdate` - Your profile updated
- `OnUserLocation` - Your location changed
- `OnUserBadgeAssigned` - Badge obtained
- `OnUserBadgeUnassigned` - Badge lost
- `OnContentRefresh` - Content added/removed
- `OnModifiedImageUpdate` - Image file modified
- `OnInstanceQueueJoined` - Joined instance queue
- `OnInstanceQueueReady` - Ready to join instance

### Group Events
- `OnGroupJoined` - Joined a group
- `OnGroupLeft` - Left a group
- `OnGroupMemberUpdated` - Group membership changed
- `OnGroupRoleUpdated` - Group role changed

## Example Usage

See [Example.cs](Example.cs) for complete examples including:
- Basic usage
- Custom configuration
- Auto-reconnect handling
- All event types

## Authentication

You need a VRChat authentication cookie (`authcookie_...`) to connect to the Pipeline. You can obtain this by:
1. Using the main VRChat.API library to authenticate
2. Logging in through the VRChat website and extracting the cookie
3. Logging in through the VRChat client and extracting the cookie

**Note**: Keep your auth token secure and never commit it to version control!

## Contributing

Contributions are welcome, but do not add features that should be handled by the OpenAPI specification.

Join the [Discord server](https://discord.gg/Ge2APMhPfD) to get in touch with us.
