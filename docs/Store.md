# VRChat.API.Model.Store

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** |  | 
**DisplayName** | **string** |  | 
**Id** | **string** |  | 
**SellerDisplayName** | **string** |  | 
**SellerId** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | 
**StoreId** | **string** |  | 
**StoreType** | **StoreType** |  | 
**Tags** | **List&lt;string&gt;** |  | 
**ListingIds** | **List&lt;string&gt;** | Only for store type world and group | [optional] 
**Listings** | [**List&lt;ProductListing&gt;**](ProductListing.md) | Only for store type world and group | [optional] 
**WorldId** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | [optional] 
**GroupId** | **string** |  | [optional] 
**ShelfIds** | **List&lt;string&gt;** | Only for store type house | [optional] 
**Shelves** | [**List&lt;StoreShelf&gt;**](StoreShelf.md) | Only for store type house | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

