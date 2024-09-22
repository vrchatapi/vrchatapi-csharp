# VRChat.API.Model.User

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowAvatarCopying** | **bool** |  | [default to true]
**Badges** | [**List&lt;Badge&gt;**](Badge.md) |   | [optional] 
**Bio** | **string** |  | 
**BioLinks** | **List&lt;string&gt;** |  | 
**CurrentAvatarImageUrl** | **string** | When profilePicOverride is not empty, use it instead. | 
**CurrentAvatarThumbnailImageUrl** | **string** | When profilePicOverride is not empty, use it instead. | 
**CurrentAvatarTags** | **List&lt;string&gt;** |  | 
**DateJoined** | **DateTime** |  | 
**DeveloperType** | **DeveloperType** |  | 
**DisplayName** | **string** | A users visual display name. This is what shows up in-game, and can different from their &#x60;username&#x60;. Changing display name is restricted to a cooldown period. | 
**FriendKey** | **string** |  | 
**FriendRequestStatus** | **string** |  | [optional] 
**Id** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | 
**InstanceId** | **string** | InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance. | [optional] 
**IsFriend** | **bool** | Either their &#x60;friendKey&#x60;, or empty string if you are not friends. Unknown usage. | 
**LastActivity** | **string** | Either a date-time or empty string. | 
**LastLogin** | **string** | Either a date-time or empty string. | 
**LastMobile** | **string** |  | [optional] 
**LastPlatform** | **string** | This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. | 
**Location** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | [optional] 
**Note** | **string** |  | [optional] 
**Platform** | **string** |  | [optional] 
**ProfilePicOverride** | **string** |  | 
**ProfilePicOverrideThumbnail** | **string** |  | 
**Pronouns** | **string** |  | 
**State** | **UserState** |  | 
**Status** | **UserStatus** |  | 
**StatusDescription** | **string** |  | 
**Tags** | **List&lt;string&gt;** |   | 
**TravelingToInstance** | **string** |  | [optional] 
**TravelingToLocation** | **string** |  | [optional] 
**TravelingToWorld** | **string** |  | [optional] 
**UserIcon** | **string** |  | 
**Username** | **string** | -| A users unique name, used during login. This is different from &#x60;displayName&#x60; which is what shows up in-game. A users &#x60;username&#x60; can never be changed.&#39; **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429). | [optional] 
**WorldId** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

