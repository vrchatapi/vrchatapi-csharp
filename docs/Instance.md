
# io.github.vrchatapi.Model.Instance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** |  | [default to true]
**CanRequestInvite** | **bool** |  | [default to true]
**Capacity** | **decimal** |  | 
**ClientNumber** | **string** |  | 
**Full** | **bool** |  | [default to false]
**Id** | **string** |  | 
**InstanceId** | **string** |  | 
**Location** | **string** |  | 
**NUsers** | **decimal** |  | 
**Name** | **string** |  | 
**Nonce** | **string** |  | [optional] 
**OwnerId** | **string** |  | [readonly] 
**Permanent** | **bool** |  | [default to false]
**PhotonRegion** | **string** |  | 
**Platforms** | [**InstancePlatforms**](InstancePlatforms.md) |  | 
**Region** | **string** |  | 
**ShortName** | **string** |  | 
**Tags** | **List&lt;string&gt;** |  | 
**Type** | **string** |  | 
**Users** | **List&lt;Object&gt;** | Always empty on non-existing instances, and non-present on existing instances. | [optional] 
**World** | **Object** | Only present on non-existing instances, and only contains a very small subject of World object. Use World API instead. | [optional] 
**WorldId** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

