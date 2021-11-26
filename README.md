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
    CurrentUser CurrentUser = await AuthApi.GetCurrentUserAsync();
    Console.WriteLine("Logged in as {0}, Current Avatar {1}", CurrentUser.DisplayName, CurrentUser.CurrentAvatar);

    User OtherUser = await UserApi.GetUserAsync("usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469");
    Console.WriteLine("Found user {0}, joined {1}", OtherUser.DisplayName, OtherUser.DateJoined);

    World World = await WorldApi.GetWorldAsync("wrld_ba913a96-fac4-4048-a062-9aa5db092812");
    Console.WriteLine("Found world {0}, visits: {1}", World.Name, World.Visits);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling API: {0}", e.Message);
    Console.WriteLine("Status Code: {0}", e.ErrorCode);
    Console.WriteLine(e.ToString());
}
```

## Documentation for API Endpoints

All URIs are relative to *https://api.vrchat.cloud/api/1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**CheckUserExists**](docs/AuthenticationApi.md#checkuserexists) | **GET** /auth/exists | Check User Exists
*AuthenticationApi* | [**DeleteUser**](docs/AuthenticationApi.md#deleteuser) | **PUT** /user/{userId}/delete | Delete User
*AuthenticationApi* | [**GetCurrentUser**](docs/AuthenticationApi.md#getcurrentuser) | **GET** /auth/user | Login and/or Get Current User Info
*AuthenticationApi* | [**Logout**](docs/AuthenticationApi.md#logout) | **PUT** /logout | Logout
*AuthenticationApi* | [**Verify2FA**](docs/AuthenticationApi.md#verify2fa) | **POST** /auth/twofactorauth/totp/verify | Verify 2FA code
*AuthenticationApi* | [**VerifyAuthToken**](docs/AuthenticationApi.md#verifyauthtoken) | **GET** /auth | Verify Auth Token
*AuthenticationApi* | [**VerifyRecoveryCode**](docs/AuthenticationApi.md#verifyrecoverycode) | **POST** /auth/twofactorauth/otp/verify | Verify 2FA code with Recovery code
*AvatarsApi* | [**CreateAvatar**](docs/AvatarsApi.md#createavatar) | **POST** /avatars | Create Avatar
*AvatarsApi* | [**DeleteAvatar**](docs/AvatarsApi.md#deleteavatar) | **DELETE** /avatars/{avatarId} | Delete Avatar
*AvatarsApi* | [**GetAvatar**](docs/AvatarsApi.md#getavatar) | **GET** /avatars/{avatarId} | Get Avatar
*AvatarsApi* | [**GetFavoritedAvatars**](docs/AvatarsApi.md#getfavoritedavatars) | **GET** /avatars/favorites | List Favorited Avatars
*AvatarsApi* | [**SearchAvatars**](docs/AvatarsApi.md#searchavatars) | **GET** /avatars | Search Avatars
*AvatarsApi* | [**SelectAvatar**](docs/AvatarsApi.md#selectavatar) | **PUT** /avatars/{avatarId}/select | Select Avatar
*AvatarsApi* | [**SelectFallbackAvatar**](docs/AvatarsApi.md#selectfallbackavatar) | **PUT** /avatars/{avatarId}/selectFallback | Select Fallback Avatar
*AvatarsApi* | [**UpdateAvatar**](docs/AvatarsApi.md#updateavatar) | **PUT** /avatars/{avatarId} | Update Avatar
*EconomyApi* | [**GetCurrentSubscriptions**](docs/EconomyApi.md#getcurrentsubscriptions) | **GET** /auth/user/subscription | Get Current Subscriptions
*EconomyApi* | [**GetLicenseGroup**](docs/EconomyApi.md#getlicensegroup) | **GET** /licenseGroups/{licenseGroupId} | Get License Group
*EconomyApi* | [**GetSteamTransaction**](docs/EconomyApi.md#getsteamtransaction) | **GET** /Steam/transactions/{transactionId} | Get Steam Transaction
*EconomyApi* | [**GetSteamTransactions**](docs/EconomyApi.md#getsteamtransactions) | **GET** /Steam/transactions | List Steam Transactions
*EconomyApi* | [**GetSubscriptions**](docs/EconomyApi.md#getsubscriptions) | **GET** /subscriptions | List Subscriptions
*FavoritesApi* | [**AddFavorite**](docs/FavoritesApi.md#addfavorite) | **POST** /favorites | Add Favorite
*FavoritesApi* | [**ClearFavoriteGroup**](docs/FavoritesApi.md#clearfavoritegroup) | **DELETE** /favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId} | Clear Favorite Group
*FavoritesApi* | [**GetFavorite**](docs/FavoritesApi.md#getfavorite) | **GET** /favorites/{favoriteId} | Show Favorite
*FavoritesApi* | [**GetFavoriteGroup**](docs/FavoritesApi.md#getfavoritegroup) | **GET** /favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId} | Show Favorite Group
*FavoritesApi* | [**GetFavoriteGroups**](docs/FavoritesApi.md#getfavoritegroups) | **GET** /favorite/groups | List Favorite Groups
*FavoritesApi* | [**GetFavorites**](docs/FavoritesApi.md#getfavorites) | **GET** /favorites | List Favorites
*FavoritesApi* | [**RemoveFavorite**](docs/FavoritesApi.md#removefavorite) | **DELETE** /favorites/{favoriteId} | Remove Favorite
*FavoritesApi* | [**UpdateFavoriteGroup**](docs/FavoritesApi.md#updatefavoritegroup) | **PUT** /favorite/group/{favoriteGroupType}/{favoriteGroupName}/{userId} | Update Favorite Group
*FilesApi* | [**CreateFile**](docs/FilesApi.md#createfile) | **POST** /file | Create File
*FilesApi* | [**CreateFileVersion**](docs/FilesApi.md#createfileversion) | **POST** /file/{fileId} | Create File Version
*FilesApi* | [**DeleteFile**](docs/FilesApi.md#deletefile) | **DELETE** /file/{fileId} | Delete File
*FilesApi* | [**DeleteFileVersion**](docs/FilesApi.md#deletefileversion) | **DELETE** /file/{fileId}/{versionId} | Delete File Version
*FilesApi* | [**DownloadFileVersion**](docs/FilesApi.md#downloadfileversion) | **GET** /file/{fileId}/{versionId} | Download File Version
*FilesApi* | [**FinishFileDataUpload**](docs/FilesApi.md#finishfiledataupload) | **PUT** /file/{fileId}/{versionId}/{fileType}/finish | Finish FileData Upload
*FilesApi* | [**GetFile**](docs/FilesApi.md#getfile) | **GET** /file/{fileId} | Show File
*FilesApi* | [**GetFileDataUploadStatus**](docs/FilesApi.md#getfiledatauploadstatus) | **GET** /file/{fileId}/{versionId}/{fileType}/status | Check FileData Upload Status
*FilesApi* | [**GetFiles**](docs/FilesApi.md#getfiles) | **GET** /files | List Files
*FilesApi* | [**StartFileDataUpload**](docs/FilesApi.md#startfiledataupload) | **PUT** /file/{fileId}/{versionId}/{fileType}/start | Start FileData Upload
*FriendsApi* | [**DeleteFriendRequest**](docs/FriendsApi.md#deletefriendrequest) | **DELETE** /user/{userId}/friendRequest | Delete Friend Request
*FriendsApi* | [**Friend**](docs/FriendsApi.md#friend) | **POST** /user/{userId}/friendRequest | Send Friend Request
*FriendsApi* | [**GetFriendStatus**](docs/FriendsApi.md#getfriendstatus) | **GET** /user/{userId}/friendStatus | Check Friend Status
*FriendsApi* | [**GetFriends**](docs/FriendsApi.md#getfriends) | **GET** /auth/user/friends | List Friends
*FriendsApi* | [**Unfriend**](docs/FriendsApi.md#unfriend) | **DELETE** /auth/user/friends/{userId} | Unfriend
*InstancesApi* | [**GetInstance**](docs/InstancesApi.md#getinstance) | **GET** /instances/{worldId}:{instanceId} | Get Instance
*InstancesApi* | [**GetShortName**](docs/InstancesApi.md#getshortname) | **GET** /instances/{worldId}:{instanceId}/shortName | Get Instance Short Name
*InstancesApi* | [**SendSelfInvite**](docs/InstancesApi.md#sendselfinvite) | **POST** /instances/{worldId}:{instanceId}/invite | Send Self Invite
*InviteApi* | [**GetInviteMessage**](docs/InviteApi.md#getinvitemessage) | **GET** /message/{userId}/{messageType}/{slot} | Get Invite Message
*InviteApi* | [**GetInviteMessages**](docs/InviteApi.md#getinvitemessages) | **GET** /message/{userId}/{messageType} | List Invite Messages
*InviteApi* | [**InviteUser**](docs/InviteApi.md#inviteuser) | **POST** /invite/{userId} | Invite User
*InviteApi* | [**RequestInvite**](docs/InviteApi.md#requestinvite) | **POST** /requestInvite/{userId} | Request Invite
*InviteApi* | [**ResetInviteMessage**](docs/InviteApi.md#resetinvitemessage) | **DELETE** /message/{userId}/{messageType}/{slot} | Reset Invite Message
*InviteApi* | [**RespondInvite**](docs/InviteApi.md#respondinvite) | **POST** /invite/{notificationId}/response | Respond Invite
*InviteApi* | [**UpdateInviteMessage**](docs/InviteApi.md#updateinvitemessage) | **PUT** /message/{userId}/{messageType}/{slot} | Update Invite Message
*NotificationsApi* | [**AcceptFriendRequest**](docs/NotificationsApi.md#acceptfriendrequest) | **PUT** /auth/user/notifications/{notificationId}/accept | Accept Friend Request
*NotificationsApi* | [**ClearNotifications**](docs/NotificationsApi.md#clearnotifications) | **PUT** /auth/user/notifications/clear | Clear All Notifications
*NotificationsApi* | [**DeleteNotification**](docs/NotificationsApi.md#deletenotification) | **PUT** /auth/user/notifications/{notificationId}/hide | Delete Notification
*NotificationsApi* | [**GetNotifications**](docs/NotificationsApi.md#getnotifications) | **GET** /auth/user/notifications | List Notifications
*NotificationsApi* | [**MarkNotificationAsRead**](docs/NotificationsApi.md#marknotificationasread) | **PUT** /auth/user/notifications/{notificationId}/see | Mark Notification As Read
*PermissionsApi* | [**GetAssignedPermissions**](docs/PermissionsApi.md#getassignedpermissions) | **GET** /auth/permissions | Get Assigned Permissions
*PermissionsApi* | [**GetPermission**](docs/PermissionsApi.md#getpermission) | **GET** /permissions/{permissionId} | Get Permission
*PlayermoderationApi* | [**ClearAllPlayerModerations**](docs/PlayermoderationApi.md#clearallplayermoderations) | **DELETE** /auth/user/playermoderations | Clear All Player Moderations
*PlayermoderationApi* | [**DeletePlayerModeration**](docs/PlayermoderationApi.md#deleteplayermoderation) | **DELETE** /auth/user/playermoderations/{playerModerationId} | Delete Player Moderation
*PlayermoderationApi* | [**GetPlayerModeration**](docs/PlayermoderationApi.md#getplayermoderation) | **GET** /auth/user/playermoderations/{playerModerationId} | Get Player Moderation
*PlayermoderationApi* | [**GetPlayerModerations**](docs/PlayermoderationApi.md#getplayermoderations) | **GET** /auth/user/playermoderations | Search Player Moderations
*PlayermoderationApi* | [**ModerateUser**](docs/PlayermoderationApi.md#moderateuser) | **POST** /auth/user/playermoderations | Moderate User
*PlayermoderationApi* | [**UnmoderateUser**](docs/PlayermoderationApi.md#unmoderateuser) | **PUT** /auth/user/unplayermoderate | Unmoderate User
*SystemApi* | [**GetCSS**](docs/SystemApi.md#getcss) | **GET** /css/app.css | Download CSS
*SystemApi* | [**GetConfig**](docs/SystemApi.md#getconfig) | **GET** /config | Fetch API Config
*SystemApi* | [**GetCurrentOnlineUsers**](docs/SystemApi.md#getcurrentonlineusers) | **GET** /visits | Current Online Users
*SystemApi* | [**GetHealth**](docs/SystemApi.md#gethealth) | **GET** /health | Check API Health
*SystemApi* | [**GetInfoPush**](docs/SystemApi.md#getinfopush) | **GET** /infoPush | Show Information Notices
*SystemApi* | [**GetJavaScript**](docs/SystemApi.md#getjavascript) | **GET** /js/app.js | Download JavaScript
*SystemApi* | [**GetSystemTime**](docs/SystemApi.md#getsystemtime) | **GET** /time | Current System Time
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /users/{userId} | Get User by ID
*UsersApi* | [**GetUserByName**](docs/UsersApi.md#getuserbyname) | **GET** /users/{username}/name | Get User by Username
*UsersApi* | [**SearchUsers**](docs/UsersApi.md#searchusers) | **GET** /users | Search All Users
*UsersApi* | [**UpdateUser**](docs/UsersApi.md#updateuser) | **PUT** /users/{userId} | Update User Info
*WorldsApi* | [**CreateWorld**](docs/WorldsApi.md#createworld) | **POST** /worlds | Create World
*WorldsApi* | [**DeleteWorld**](docs/WorldsApi.md#deleteworld) | **DELETE** /worlds/{worldId} | Delete World
*WorldsApi* | [**GetActiveWorlds**](docs/WorldsApi.md#getactiveworlds) | **GET** /worlds/active | List Active Worlds
*WorldsApi* | [**GetFavoritedWorlds**](docs/WorldsApi.md#getfavoritedworlds) | **GET** /worlds/favorites | List Favorited Worlds
*WorldsApi* | [**GetRecentWorlds**](docs/WorldsApi.md#getrecentworlds) | **GET** /worlds/recent | List Recent Worlds
*WorldsApi* | [**GetWorld**](docs/WorldsApi.md#getworld) | **GET** /worlds/{worldId} | Get World by ID
*WorldsApi* | [**GetWorldInstance**](docs/WorldsApi.md#getworldinstance) | **GET** /worlds/{worldId}/{instanceId} | Get World Instance
*WorldsApi* | [**GetWorldMetadata**](docs/WorldsApi.md#getworldmetadata) | **GET** /worlds/{worldId}/metadata | Get World Metadata
*WorldsApi* | [**GetWorldPublishStatus**](docs/WorldsApi.md#getworldpublishstatus) | **GET** /worlds/{worldId}/publish | Get World Publish Status
*WorldsApi* | [**PublishWorld**](docs/WorldsApi.md#publishworld) | **PUT** /worlds/{worldId}/publish | Publish World
*WorldsApi* | [**SearchWorlds**](docs/WorldsApi.md#searchworlds) | **GET** /worlds | Search All Worlds
*WorldsApi* | [**UnpublishWorld**](docs/WorldsApi.md#unpublishworld) | **DELETE** /worlds/{worldId}/publish | Unpublish World
*WorldsApi* | [**UpdateWorld**](docs/WorldsApi.md#updateworld) | **PUT** /worlds/{worldId} | Update World


## Documentation for Models

 - [Model.APIConfig](docs/APIConfig.md)
 - [Model.APIEventConfig](docs/APIEventConfig.md)
 - [Model.APIHealth](docs/APIHealth.md)
 - [Model.AddFavoriteRequest](docs/AddFavoriteRequest.md)
 - [Model.Avatar](docs/Avatar.md)
 - [Model.AvatarUnityPackageUrlObject](docs/AvatarUnityPackageUrlObject.md)
 - [Model.CreateAvatarRequest](docs/CreateAvatarRequest.md)
 - [Model.CreateFileRequest](docs/CreateFileRequest.md)
 - [Model.CreateFileVersionRequest](docs/CreateFileVersionRequest.md)
 - [Model.CreateWorldRequest](docs/CreateWorldRequest.md)
 - [Model.CurrentUser](docs/CurrentUser.md)
 - [Model.DeploymentGroup](docs/DeploymentGroup.md)
 - [Model.DeveloperType](docs/DeveloperType.md)
 - [Model.DownloadURLList](docs/DownloadURLList.md)
 - [Model.DynamicContentRow](docs/DynamicContentRow.md)
 - [Model.Error](docs/Error.md)
 - [Model.Favorite](docs/Favorite.md)
 - [Model.FavoriteGroup](docs/FavoriteGroup.md)
 - [Model.FavoriteGroupVisibility](docs/FavoriteGroupVisibility.md)
 - [Model.FavoriteType](docs/FavoriteType.md)
 - [Model.File](docs/File.md)
 - [Model.FileData](docs/FileData.md)
 - [Model.FileStatus](docs/FileStatus.md)
 - [Model.FileUploadURL](docs/FileUploadURL.md)
 - [Model.FileVersion](docs/FileVersion.md)
 - [Model.FileVersionUploadStatus](docs/FileVersionUploadStatus.md)
 - [Model.FinishFileDataUploadRequest](docs/FinishFileDataUploadRequest.md)
 - [Model.FriendStatus](docs/FriendStatus.md)
 - [Model.InfoPush](docs/InfoPush.md)
 - [Model.InfoPushData](docs/InfoPushData.md)
 - [Model.InfoPushDataArticle](docs/InfoPushDataArticle.md)
 - [Model.InfoPushDataArticleContent](docs/InfoPushDataArticleContent.md)
 - [Model.InfoPushDataClickable](docs/InfoPushDataClickable.md)
 - [Model.Instance](docs/Instance.md)
 - [Model.InstancePlatforms](docs/InstancePlatforms.md)
 - [Model.InviteMessage](docs/InviteMessage.md)
 - [Model.InviteMessageType](docs/InviteMessageType.md)
 - [Model.InviteRequest](docs/InviteRequest.md)
 - [Model.InviteResponse](docs/InviteResponse.md)
 - [Model.License](docs/License.md)
 - [Model.LicenseAction](docs/LicenseAction.md)
 - [Model.LicenseGroup](docs/LicenseGroup.md)
 - [Model.LicenseType](docs/LicenseType.md)
 - [Model.LimitedUnityPackage](docs/LimitedUnityPackage.md)
 - [Model.LimitedUser](docs/LimitedUser.md)
 - [Model.LimitedWorld](docs/LimitedWorld.md)
 - [Model.MIMEType](docs/MIMEType.md)
 - [Model.ModerateUserRequest](docs/ModerateUserRequest.md)
 - [Model.Notification](docs/Notification.md)
 - [Model.NotificationType](docs/NotificationType.md)
 - [Model.PastDisplayName](docs/PastDisplayName.md)
 - [Model.Permission](docs/Permission.md)
 - [Model.PlayerModeration](docs/PlayerModeration.md)
 - [Model.PlayerModerationType](docs/PlayerModerationType.md)
 - [Model.PublicAnnouncement](docs/PublicAnnouncement.md)
 - [Model.ReleaseStatus](docs/ReleaseStatus.md)
 - [Model.Response](docs/Response.md)
 - [Model.Subscription](docs/Subscription.md)
 - [Model.SubscriptionPeriod](docs/SubscriptionPeriod.md)
 - [Model.Success](docs/Success.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionAgreement](docs/TransactionAgreement.md)
 - [Model.TransactionStatus](docs/TransactionStatus.md)
 - [Model.TransactionSteamInfo](docs/TransactionSteamInfo.md)
 - [Model.TransactionSteamWalletInfo](docs/TransactionSteamWalletInfo.md)
 - [Model.TwoFactorAuthCode](docs/TwoFactorAuthCode.md)
 - [Model.UnityPackage](docs/UnityPackage.md)
 - [Model.UpdateAvatarRequest](docs/UpdateAvatarRequest.md)
 - [Model.UpdateFavoriteGroupRequest](docs/UpdateFavoriteGroupRequest.md)
 - [Model.UpdateInviteMessageRequest](docs/UpdateInviteMessageRequest.md)
 - [Model.UpdateUserRequest](docs/UpdateUserRequest.md)
 - [Model.UpdateWorldRequest](docs/UpdateWorldRequest.md)
 - [Model.User](docs/User.md)
 - [Model.UserExists](docs/UserExists.md)
 - [Model.UserState](docs/UserState.md)
 - [Model.UserStatus](docs/UserStatus.md)
 - [Model.UserSubscription](docs/UserSubscription.md)
 - [Model.Verify2FAResult](docs/Verify2FAResult.md)
 - [Model.VerifyAuthTokenResult](docs/VerifyAuthTokenResult.md)
 - [Model.World](docs/World.md)
 - [Model.WorldMetadata](docs/WorldMetadata.md)
 - [Model.WorldPublishStatus](docs/WorldPublishStatus.md)


## Contributing

Contributions are welcome, but do not add features that should be handled by the OpenAPI specification.

Join the [Discord server](https://discord.gg/Ge2APMhPfD) to get in touch with us.