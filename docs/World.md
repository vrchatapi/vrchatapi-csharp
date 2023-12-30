# VRChat.API.Model.World

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthorId** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | 
**AuthorName** | **string** |  | 
**Capacity** | **int** |  | 
**RecommendedCapacity** | **int** |  | 
**CreatedAt** | **DateTime** |  | 
**Description** | **string** |  | 
**Favorites** | **int** |  | [optional] [default to 0]
**Featured** | **bool** |  | [default to false]
**Heat** | **int** |  | [default to 0]
**Id** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | 
**ImageUrl** | **string** |  | 
**Instances** | **List&lt;List&lt;Object&gt;&gt;** | Will always be an empty list when unauthenticated. | [optional] 
**LabsPublicationDate** | **string** |  | 
**Name** | **string** |  | 
**Namespace** | **string** |  | 
**Occupants** | **int** | Will always be &#x60;0&#x60; when unauthenticated. | [optional] [default to 0]
**Organization** | **string** |  | [default to "vrchat"]
**Popularity** | **int** |  | [default to 0]
**PreviewYoutubeId** | **string** |  | [optional] 
**PrivateOccupants** | **int** | Will always be &#x60;0&#x60; when unauthenticated. | [optional] [default to 0]
**PublicOccupants** | **int** | Will always be &#x60;0&#x60; when unauthenticated. | [optional] [default to 0]
**PublicationDate** | **string** |  | 
**ReleaseStatus** | **ReleaseStatus** |  | 
**Tags** | **List&lt;string&gt;** |   | 
**ThumbnailImageUrl** | **string** |  | 
**UnityPackages** | [**List&lt;UnityPackage&gt;**](UnityPackage.md) | Empty if unauthenticated. | [optional] 
**UpdatedAt** | **DateTime** |  | 
**_Version** | **int** |  | [default to 0]
**Visits** | **int** |  | [default to 0]
**UdonProducts** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

