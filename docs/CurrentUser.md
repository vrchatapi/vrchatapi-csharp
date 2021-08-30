
# io.github.vrchatapi.Model.CurrentUser

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [readonly] 
**Username** | **string** |  | 
**DisplayName** | **string** |  | 
**UserIcon** | **string** |  | 
**Bio** | **string** |  | 
**BioLinks** | **List&lt;string&gt;** |  | 
**ProfilePicOverride** | **string** |  | 
**StatusDescription** | **string** |  | 
**PastDisplayNames** | [**List&lt;PastDisplayName&gt;**](PastDisplayName.md) |  | 
**HasEmail** | **bool** |  | 
**HasPendingEmail** | **bool** |  | 
**ObfuscatedEmail** | **string** |  | 
**ObfuscatedPendingEmail** | **string** |  | 
**EmailVerified** | **bool** |  | 
**HasBirthday** | **bool** |  | 
**Unsubscribe** | **bool** |  | 
**StatusHistory** | **List&lt;string&gt;** |  | 
**StatusFirstTime** | **bool** |  | 
**Friends** | **List&lt;string&gt;** |  | 
**FriendGroupNames** | **List&lt;string&gt;** | Always empty array. | 
**CurrentAvatarImageUrl** | **string** |  | 
**CurrentAvatarThumbnailImageUrl** | **string** |  | 
**FallbackAvatar** | **string** |  | 
**CurrentAvatar** | **string** |  | 
**CurrentAvatarAssetUrl** | **string** |  | 
**AccountDeletionDate** | **DateTime?** |  | [optional] 
**AcceptedTOSVersion** | **decimal** |  | 
**SteamId** | **string** |  | 
**SteamDetails** | **Object** |  | 
**OculusId** | **string** |  | 
**HasLoggedInFromClient** | **bool** |  | 
**HomeLocation** | **string** |  | 
**TwoFactorAuthEnabled** | **bool** |  | 
**State** | **UserState** |  | 
**Tags** | **List&lt;string&gt;** |  | 
**DeveloperType** | **DeveloperType** |  | 
**LastLogin** | **DateTime** |  | 
**LastPlatform** | **Platform** |  | 
**AllowAvatarCopying** | **bool** |  | 
**Status** | **UserStatus** |  | 
**DateJoined** | **DateTime** |  | [readonly] 
**IsFriend** | **bool** |  | [default to false]
**FriendKey** | **string** |  | 
**OnlineFriends** | **List&lt;string&gt;** |  | [optional] 
**ActiveFriends** | **List&lt;string&gt;** |  | [optional] 
**OfflineFriends** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

