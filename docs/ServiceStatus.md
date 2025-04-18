# VRChat.API.Model.ServiceStatus
Status information for a service request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** |  | 
**Id** | **string** | The id of this service, NOT the id of the thing this service was requested for. | 
**Progress** | **List&lt;Object&gt;** |  | 
**RequesterUserId** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | 
**State** | **string** |  | 
**SubjectId** | **string** | The id of the thing this service was requested for. | 
**SubjectType** | **string** | The kind of the thing this service was requested for. | 
**Type** | **string** | The kind of service that was requested. | 
**UpdatedAt** | **DateTime** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

