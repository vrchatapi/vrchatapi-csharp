# VRChat.API.Model.CreateInstanceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WorldId** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | 
**Type** | **InstanceType** |  | 
**Region** | **InstanceRegion** |  | 
**OwnerId** | **string** | A groupId if the instance type is \&quot;group\&quot;, null if instance type is public, or a userId otherwise | [optional] 
**RoleIds** | **List&lt;string&gt;** | Group roleIds that are allowed to join if the type is \&quot;group\&quot; and groupAccessType is \&quot;member\&quot; | [optional] 
**GroupAccessType** | **GroupAccessType** |  | [optional] 
**QueueEnabled** | **bool** |  | [optional] [default to false]
**ClosedAt** | **DateTime** | The time after which users won&#39;t be allowed to join the instance. This doesn&#39;t work for public instances. | [optional] 
**CanRequestInvite** | **bool** | Only applies to invite type instances to make them invite+ | [optional] [default to false]
**HardClose** | **bool** | Currently unused, but will eventually be a flag to set if the closing of the instance should kick people. | [optional] [default to false]
**InviteOnly** | **bool** |  | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

