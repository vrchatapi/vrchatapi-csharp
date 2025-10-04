# VRChat.API.Model.LimitedUserSearch
User object received when searching

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bio** | **string** |  | [optional] 
**BioLinks** | **List&lt;string&gt;** |   | [optional] 
**CurrentAvatarImageUrl** | **string** | When profilePicOverride is not empty, use it instead. | 
**CurrentAvatarThumbnailImageUrl** | **string** | When profilePicOverride is not empty, use it instead. | 
**CurrentAvatarTags** | **List&lt;string&gt;** |  | 
**DeveloperType** | **DeveloperType** |  | 
**DisplayName** | **string** |  | 
**Id** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | 
**IsFriend** | **bool** |  | 
**LastPlatform** | **string** | This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. | 
**ProfilePicOverride** | **string** |  | [optional] 
**Pronouns** | **string** |  | [optional] 
**Status** | **UserStatus** |  | 
**StatusDescription** | **string** |  | 
**Tags** | **List&lt;string&gt;** | &lt;- Always empty. | 
**UserIcon** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

