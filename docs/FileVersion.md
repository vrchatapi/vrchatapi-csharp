
# io.github.vrchatapi.Model.FileVersion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Version** | **decimal** | Incremental version counter, can only be increased. | [default to 0M]
**Status** | **FileStatus** |  | 
**CreatedAt** | **DateTime** |  | [readonly] 
**File** | [**FileData**](FileData.md) |  | [optional] 
**Delta** | [**FileData**](FileData.md) |  | [optional] 
**Signature** | [**FileData**](FileData.md) |  | [optional] 
**Deleted** | **bool** | Usually only present if &#x60;true&#x60; | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

