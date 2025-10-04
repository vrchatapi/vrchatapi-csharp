# VRChat.API.Model.LimitedUserInstance
User object received when querying your own instance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgeVerificationStatus** | **AgeVerificationStatus** |  | 
**AgeVerified** | **bool** | &#x60;true&#x60; if, user is age verified (not 18+). | 
**AllowAvatarCopying** | **bool** |  | 
**Bio** | **string** |  | [optional] 
**BioLinks** | **List&lt;string&gt;** |   | [optional] 
**CurrentAvatarImageUrl** | **string** | When profilePicOverride is not empty, use it instead. | 
**CurrentAvatarThumbnailImageUrl** | **string** | When profilePicOverride is not empty, use it instead. | 
**CurrentAvatarTags** | **List&lt;string&gt;** |  | 
**DateJoined** | **DateTime?** |  | 
**DeveloperType** | **DeveloperType** |  | 
**DisplayName** | **string** |  | 
**FriendKey** | **string** |  | 
**Id** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | 
**IsFriend** | **bool** |  | 
**ImageUrl** | **string** |  | [optional] 
**LastPlatform** | **string** | This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. | 
**LastActivity** | **DateTime?** |  | 
**LastMobile** | **DateTime?** |  | 
**Platform** | **string** |  | [optional] 
**ProfilePicOverride** | **string** |  | [optional] 
**ProfilePicOverrideThumbnail** | **string** |  | [optional] 
**Pronouns** | **string** |  | 
**State** | **UserState** |  | 
**Status** | **UserStatus** |  | 
**StatusDescription** | **string** |  | 
**Tags** | **List&lt;string&gt;** |  | 
**UserIcon** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

