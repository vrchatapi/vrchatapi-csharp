# VRChat.API.Model.GroupMyMember

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**GroupId** | **string** |  | [optional] 
**UserId** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | [optional] 
**RoleIds** | **List&lt;string&gt;** |  | [optional] 
**AcceptedByDisplayName** | **string** |  | [optional] 
**AcceptedById** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**ManagerNotes** | **string** |  | [optional] 
**MembershipStatus** | **string** |  | [optional] 
**IsSubscribedToAnnouncements** | **bool** |  | [optional] [default to true]
**Visibility** | **string** |  | [optional] 
**IsRepresenting** | **bool** |  | [optional] [default to false]
**JoinedAt** | **DateTime** |  | [optional] 
**BannedAt** | **string** |  | [optional] 
**Has2FA** | **bool** |  | [optional] [default to false]
**HasJoinedFromPurchase** | **bool** |  | [optional] [default to false]
**LastPostReadAt** | **DateTime?** |  | [optional] 
**MRoleIds** | **List&lt;string&gt;** |  | [optional] 
**Permissions** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

