# VRChat.API.Model.GroupLimitedMember

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**GroupId** | **string** |  | [optional] 
**UserId** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | [optional] 
**IsRepresenting** | **bool** | Whether the user is representing the group. This makes the group show up above the name tag in-game. | [optional] [default to false]
**RoleIds** | **List&lt;string&gt;** |  | [optional] 
**MRoleIds** | **List&lt;string&gt;** |  | [optional] 
**JoinedAt** | **DateTime?** |  | [optional] 
**MembershipStatus** | **GroupMemberStatus** |  | [optional] 
**Visibility** | **string** |  | [optional] 
**IsSubscribedToAnnouncements** | **bool** |  | [optional] [default to false]
**CreatedAt** | **DateTime?** | Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user. | [optional] 
**BannedAt** | **DateTime?** | Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user. | [optional] 
**ManagerNotes** | **string** | Only visible via the /groups/:groupId/members endpoint, **not** when fetching a specific user. | [optional] 
**LastPostReadAt** | **DateTime?** |  | [optional] 
**HasJoinedFromPurchase** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

