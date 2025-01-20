# VRChat.API.Model.Avatar

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AssetUrl** | **string** | Not present from general serach &#x60;/avatars&#x60;, only on specific requests &#x60;/avatars/{avatarId}&#x60;. | [optional] 
**AssetUrlObject** | **Object** | Not present from general serach &#x60;/avatars&#x60;, only on specific requests &#x60;/avatars/{avatarId}&#x60;. **Deprecation:** &#x60;Object&#x60; has unknown usage/fields, and is always empty. Use normal &#x60;Url&#x60; field instead. | [optional] 
**AuthorId** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | 
**AuthorName** | **string** |  | 
**CreatedAt** | **DateTime** |  | 
**Description** | **string** |  | 
**Featured** | **bool** |  | [default to false]
**Id** | **string** |  | 
**ImageUrl** | **string** |  | 
**Name** | **string** |  | 
**ReleaseStatus** | **ReleaseStatus** |  | 
**Styles** | [**AvatarStyles**](AvatarStyles.md) |  | 
**Tags** | **List&lt;string&gt;** |   | 
**ThumbnailImageUrl** | **string** |  | 
**UnityPackageUrl** | **string** |  | 
**UnityPackageUrlObject** | [**AvatarUnityPackageUrlObject**](AvatarUnityPackageUrlObject.md) |  | 
**UnityPackages** | [**List&lt;UnityPackage&gt;**](UnityPackage.md) |  | 
**UpdatedAt** | **DateTime** |  | 
**_Version** | **int** |  | [default to 0]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

