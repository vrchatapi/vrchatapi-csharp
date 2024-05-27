# VRChat.API.Model.Instance
* `hidden` field is only present if InstanceType is `hidden` aka \"Friends+\", and is instance creator. * `friends` field is only present if InstanceType is `friends` aka \"Friends\", and is instance creator. * `private` field is only present if InstanceType is `private` aka \"Invite\" or \"Invite+\", and is instance creator.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** |  | [default to true]
**CanRequestInvite** | **bool** |  | [default to true]
**Capacity** | **int** |  | 
**ClientNumber** | **string** | Always returns \&quot;unknown\&quot;. | 
**Full** | **bool** |  | [default to false]
**Id** | **string** | InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance. | 
**InstanceId** | **string** |  | 
**Location** | **string** | InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance. | 
**NUsers** | **int** |  | 
**Name** | **string** |  | 
**OwnerId** | **string** | A groupId if the instance type is \&quot;group\&quot;, null if instance type is public, or a userId otherwise | [optional] 
**Permanent** | **bool** |  | [default to false]
**PhotonRegion** | **Region** |  | 
**Platforms** | [**InstancePlatforms**](InstancePlatforms.md) |  | 
**Region** | **InstanceRegion** |  | 
**SecureName** | **string** |  | 
**ShortName** | **string** |  | [optional] 
**Tags** | **List&lt;string&gt;** | The tags array on Instances usually contain the language tags of the people in the instance.  | 
**Type** | **InstanceType** |  | 
**WorldId** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | 
**Hidden** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | [optional] 
**Friends** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | [optional] 
**Private** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | [optional] 
**QueueEnabled** | **bool** |  | 
**QueueSize** | **int** |  | 
**RecommendedCapacity** | **int** |  | 
**RoleRestricted** | **bool** |  | [optional] 
**Strict** | **bool** |  | 
**UserCount** | **int** |  | 
**World** | [**World**](World.md) |  | 
**Users** | [**List&lt;LimitedUser&gt;**](LimitedUser.md) | The users field is present on instances created by the requesting user. | [optional] 
**GroupAccessType** | **GroupAccessType** |  | [optional] 
**HasCapacityForYou** | **bool** |  | [optional] 
**Nonce** | **string** |  | [optional] 
**ClosedAt** | **DateTime?** |  | [optional] 
**HardClose** | **bool?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

