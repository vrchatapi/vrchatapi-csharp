# VRChat.API.Model.LimitedWorld

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthorId** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | 
**AuthorName** | **string** |  | 
**Capacity** | **int** |  | 
**RecommendedCapacity** | **int** |  | [optional] 
**CreatedAt** | **DateTime** |  | 
**Favorites** | **int** |  | [default to 0]
**Heat** | **int** |  | [default to 0]
**Id** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | 
**ImageUrl** | **string** |  | 
**LabsPublicationDate** | **string** |  | 
**Name** | **string** |  | 
**Occupants** | **int** |  | [default to 0]
**Organization** | **string** |  | [default to "vrchat"]
**Popularity** | **int** |  | [default to 0]
**PublicationDate** | **string** |  | 
**ReleaseStatus** | **ReleaseStatus** |  | 
**Tags** | **List&lt;string&gt;** |   | 
**ThumbnailImageUrl** | **string** |  | 
**UnityPackages** | [**List&lt;LimitedUnityPackage&gt;**](LimitedUnityPackage.md) |   | 
**UpdatedAt** | **DateTime** |  | 
**UdonProducts** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

