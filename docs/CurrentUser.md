# VRChat.API.Model.CurrentUser

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcceptedTOSVersion** | **int** |  | 
**AcceptedPrivacyVersion** | **int** |  | [optional] 
**AccountDeletionDate** | **DateTime?** |  | [optional] 
**AccountDeletionLog** | [**List&lt;AccountDeletionLog&gt;**](AccountDeletionLog.md) |   | [optional] 
**ActiveFriends** | **List&lt;string&gt;** |   | [optional] 
**AllowAvatarCopying** | **bool** |  | 
**Bio** | **string** |  | 
**BioLinks** | **List&lt;string&gt;** |   | 
**CurrentAvatar** | **string** |  | 
**CurrentAvatarAssetUrl** | **string** |  | 
**CurrentAvatarImageUrl** | **string** | When profilePicOverride is not empty, use it instead. | 
**CurrentAvatarThumbnailImageUrl** | **string** | When profilePicOverride is not empty, use it instead. | 
**CurrentAvatarTags** | **List&lt;string&gt;** |  | [optional] 
**DateJoined** | **DateTime** |  | 
**DeveloperType** | **DeveloperType** |  | 
**DisplayName** | **string** |  | 
**EmailVerified** | **bool** |  | 
**FallbackAvatar** | **string** |  | [optional] 
**FriendGroupNames** | **List&lt;string&gt;** | Always empty array. | 
**FriendKey** | **string** |  | 
**Friends** | **List&lt;string&gt;** |  | 
**HasBirthday** | **bool** |  | 
**HideContentFilterSettings** | **bool** |  | [optional] 
**UserLanguage** | **string** |  | [optional] 
**UserLanguageCode** | **string** |  | [optional] 
**HasEmail** | **bool** |  | 
**HasLoggedInFromClient** | **bool** |  | 
**HasPendingEmail** | **bool** |  | 
**HomeLocation** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | 
**Id** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | 
**IsFriend** | **bool** |  | [default to false]
**LastActivity** | **DateTime** |  | [optional] 
**LastLogin** | **DateTime** |  | 
**LastPlatform** | **string** | This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. | 
**ObfuscatedEmail** | **string** |  | 
**ObfuscatedPendingEmail** | **string** |  | 
**OculusId** | **string** |  | 
**GoogleId** | **string** |  | [optional] 
**PicoId** | **string** |  | [optional] 
**ViveId** | **string** |  | [optional] 
**OfflineFriends** | **List&lt;string&gt;** |  | [optional] 
**OnlineFriends** | **List&lt;string&gt;** |  | [optional] 
**PastDisplayNames** | [**List&lt;PastDisplayName&gt;**](PastDisplayName.md) |   | 
**Presence** | [**CurrentUserPresence**](CurrentUserPresence.md) |  | [optional] 
**ProfilePicOverride** | **string** |  | 
**State** | **UserState** |  | 
**Status** | **UserStatus** |  | 
**StatusDescription** | **string** |  | 
**StatusFirstTime** | **bool** |  | 
**StatusHistory** | **List&lt;string&gt;** |  | 
**SteamDetails** | **Object** |  | 
**SteamId** | **string** |  | 
**Tags** | **List&lt;string&gt;** |  | 
**TwoFactorAuthEnabled** | **bool** |  | 
**TwoFactorAuthEnabledDate** | **DateTime?** |  | [optional] 
**Unsubscribe** | **bool** |  | 
**UpdatedAt** | **DateTime** |  | [optional] 
**UserIcon** | **string** |  | 
**Username** | **string** | -| **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

