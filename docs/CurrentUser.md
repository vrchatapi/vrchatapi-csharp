
# io.github.vrchatapi.Model.CurrentUser

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
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
**FallbackAvatar** | **string** |  | [optional] 
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
**LastPlatform** | **string** | This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. | 
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

