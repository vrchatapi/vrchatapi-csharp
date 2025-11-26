# VRChat.API.Realtime Changelog

## Refactor - System.Text.Json & Built-in WebSocket Implementation

### Major Changes

#### 1. **Removed Third-Party Dependencies**
- ❌ Removed `Newtonsoft.Json` dependency
- ❌ Removed `Websocket.Client` dependency
- ✅ Now using built-in `System.Text.Json`
- ✅ Now using built-in `System.Net.WebSockets.ClientWebSocket`

#### 2. **Message Deserialization Architecture**
- **Before**: Manual JSON parsing with JObject/JToken
- **After**: Direct deserialization to strongly-typed classes

Created new `Messages/` namespace with:
- `WebSocketMessage<T>` - Generic wrapper for all messages
- Strongly-typed content classes for each message type:
  - `NotificationContent`, `ResponseNotificationContent`
  - `NotificationV2Content`, `NotificationV2UpdateContent`, `NotificationV2DeleteContent`
  - `FriendAddContent`, `FriendOnlineContent`, `FriendLocationContent`, etc.
  - `UserUpdateContent`, `UserLocationContent`, `ContentRefreshContent`, etc.
  - `GroupJoinedContent`, `GroupMemberUpdatedContent`, etc.
  - `HeartbeatMessage` for outgoing heartbeats

#### 3. **WebSocket Implementation**
- **Before**: Used `Websocket.Client` library with Reactive Extensions
- **After**: Custom implementation using `ClientWebSocket`

New features:
- Manual receive loop with proper cancellation support
- Thread-safe send operations using `SemaphoreSlim`
- Better error handling and reconnection logic
- Full control over WebSocket lifecycle

#### 4. **Heartbeat Functionality** ✨ NEW
- Sends heartbeat every 30 seconds: `{"type": "heartbeat", "connected": true, "nonce": "<guid>"}`
- Automatic timer-based sending
- Unique GUID nonce for each heartbeat
- Helps keep connection alive and detect disconnections faster

### Implementation Details

#### WebSocket Receive Loop
```csharp
private async Task ReceiveLoop(CancellationToken cancellationToken)
{
    var buffer = new byte[8192];
    var messageBuffer = new StringBuilder();
    
    while (!cancellationToken.IsCancellationRequested && _client.State == WebSocketState.Open)
    {
        // Receive message in chunks
        // Handle text messages
        // Process through message processor
    }
}
```

#### Message Processing
```csharp
// Before (Newtonsoft.Json)
var baseMessage = JObject.Parse(json);
var content = baseMessage["content"];
var userId = content["userId"]?.ToString();

// After (System.Text.Json)
var message = JsonSerializer.Deserialize<WebSocketMessage<FriendOnlineContent>>(json, JsonOptions);
var userId = message.Content.UserId;
```

#### Heartbeat Timer
```csharp
private void SetupHeartbeatTimer()
{
    _heartbeatTimer = new Timer(async _ =>
    {
        await SendHeartbeatAsync();
    }, null, TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(30));
}
```

### Benefits

1. **No External Dependencies**: Relies only on .NET 8.0 built-in libraries
2. **Better Performance**: System.Text.Json is faster than Newtonsoft.Json
3. **Type Safety**: Direct deserialization to classes catches errors at compile time
4. **Full Control**: Custom WebSocket implementation allows for better debugging and customization
5. **Keep-Alive**: Heartbeat ensures connection stays active
6. **Cleaner Code**: Less manual JSON parsing, more declarative

### File Structure

```
wrapper/VRChat.API.Realtime/
├── Messages/
│   └── WebSocketMessage.cs              # All message content classes
├── Models/
│   └── [27 EventArgs classes]           # Event argument classes
├── VRChatRealtimeClient.cs              # Main client (partial)
├── VRChatRealtimeClient.MessageProcessor.cs  # Message processing (partial)
├── VRChatRealtimeClientBuilder.cs       # Fluent builder
├── VRChatRealtimeConfiguration.cs       # Configuration class
├── Example.cs                           # Usage examples
└── README.md                            # Documentation
```

### Breaking Changes

⚠️ **None** - The public API remains unchanged. All changes are internal implementation details.

### Migration Guide

No migration needed! The public API (events, configuration, methods) remains exactly the same.

### Testing

- ✅ No linter errors
- ✅ All event types supported
- ✅ Heartbeat functionality implemented
- ✅ Auto-reconnect modes working
- ✅ Proper resource disposal

