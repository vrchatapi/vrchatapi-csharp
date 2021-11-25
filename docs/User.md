# VRChat.API.Model.User

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowAvatarCopying** | **bool** |  | [default to true]
**Bio** | **string** |  | 
**BioLinks** | **List&lt;string&gt;** |  | 
**CurrentAvatarImageUrl** | **string** | When profilePicOverride is not empty, use it instead. | 
**CurrentAvatarThumbnailImageUrl** | **string** | When profilePicOverride is not empty, use it instead. | 
**DateJoined** | **DateTime** |  | 
**DeveloperType** | **DeveloperType** |  | 
**DisplayName** | **string** | A users visual display name. This is what shows up in-game, and can different from their &#x60;username&#x60;. Changing display name is restricted to a cooldown period. | 
**FriendKey** | **string** |  | 
**Id** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | 
**InstanceId** | **string** | InstanceID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | [optional] 
**IsFriend** | **bool** | Either their &#x60;friendKey&#x60;, or empty string if you are not friends. Unknown usage. | 
**LastLogin** | **string** | Either a date-time or empty string. | 
**LastPlatform** | **string** | This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. | 
**Location** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | [optional] 
**ProfilePicOverride** | **string** |  | 
**State** | **UserState** |  | 
**Status** | **UserStatus** |  | 
**StatusDescription** | **string** |  | 
**Tags** | **List&lt;string&gt;** |  | 
**UserIcon** | **string** |  | 
**Username** | **string** | A users unique name, used during login. This is different from &#x60;displayName&#x60; which is what shows up in-game. A users &#x60;username&#x60; can never be changed. | 
**WorldId** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

