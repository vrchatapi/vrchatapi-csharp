# VRChat.API.Model.UserSubscription

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**TransactionId** | **string** |  | 
**Store** | **string** | Which \&quot;Store\&quot; it came from. Right now only Stores are \&quot;Steam\&quot; and \&quot;Admin\&quot;. | 
**SteamItemId** | **string** |  | [optional] 
**Amount** | **decimal** |  | 
**Description** | **string** |  | 
**Period** | **SubscriptionPeriod** |  | 
**Tier** | **decimal** |  | 
**Active** | **bool** |  | [default to true]
**Status** | **TransactionStatus** |  | 
**Expires** | **DateTime** |  | 
**CreatedAt** | **DateTime** |  | 
**UpdatedAt** | **DateTime** |  | 
**LicenseGroups** | **List&lt;string&gt;** |  | 
**IsGift** | **bool** |  | [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

