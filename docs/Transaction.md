# VRChat.API.Model.Transaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**UserId** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | [optional] 
**UserDisplayName** | **string** |  | [optional] 
**Status** | **TransactionStatus** |  | 
**Subscription** | [**Subscription**](Subscription.md) |  | 
**Sandbox** | **bool** |  | [default to false]
**CreatedAt** | **DateTime** |  | 
**UpdatedAt** | **DateTime** |  | 
**Steam** | [**TransactionSteamInfo**](TransactionSteamInfo.md) |  | [optional] 
**Agreement** | [**TransactionAgreement**](TransactionAgreement.md) |  | [optional] 
**Error** | **string** |  | 
**IsGift** | **bool** |  | [optional] [default to false]
**IsTokens** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

