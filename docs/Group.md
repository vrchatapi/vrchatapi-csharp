# VRChat.API.Model.Group

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**ShortCode** | **string** |  | [optional] 
**Discriminator** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**IconUrl** | **string** |  | [optional] 
**BannerUrl** | **string** |  | [optional] 
**Privacy** | **GroupPrivacy** |  | [optional] 
**OwnerId** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | [optional] 
**Rules** | **string** |  | [optional] 
**Links** | **List&lt;string&gt;** |  | [optional] 
**Languages** | **List&lt;string&gt;** |  | [optional] 
**IconId** | **string** |  | [optional] 
**BannerId** | **string** |  | [optional] 
**MemberCount** | **int** |  | [optional] 
**MemberCountSyncedAt** | **DateTime** |  | [optional] 
**IsVerified** | **bool** |  | [optional] [default to false]
**JoinState** | **GroupJoinState** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**TransferTargetId** | **string** | A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. | [optional] 
**Galleries** | [**List&lt;GroupGallery&gt;**](GroupGallery.md) |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**LastPostCreatedAt** | **DateTime?** |  | [optional] 
**OnlineMemberCount** | **int** |  | [optional] 
**MembershipStatus** | **GroupMemberStatus** |  | [optional] 
**MyMember** | [**GroupMyMember**](GroupMyMember.md) |  | [optional] 
**Roles** | [**List&lt;GroupRole&gt;**](GroupRole.md) | Only returned if ?includeRoles&#x3D;true is specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

