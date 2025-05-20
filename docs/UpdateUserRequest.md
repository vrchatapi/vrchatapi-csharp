# VRChat.API.Model.UpdateUserRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** |  | [optional] 
**Unsubscribe** | **bool** |  | [optional] 
**Birthday** | **DateTime** |  | [optional] 
**AcceptedTOSVersion** | **int** |  | [optional] 
**Tags** | **List&lt;string&gt;** |   | [optional] 
**Status** | **UserStatus** |  | [optional] 
**StatusDescription** | **string** |  | [optional] 
**Bio** | **string** |  | [optional] 
**BioLinks** | **List&lt;string&gt;** |  | [optional] 
**Pronouns** | **string** |  | [optional] 
**IsBoopingEnabled** | **bool** |  | [optional] 
**UserIcon** | **string** | MUST be a valid VRChat /file/ url. | [optional] 
**ContentFilters** | **List&lt;string&gt;** | These tags begin with &#x60;content_&#x60; and control content gating | [optional] 
**DisplayName** | **string** | MUST specify currentPassword as well to change display name | [optional] 
**RevertDisplayName** | **bool** | MUST specify currentPassword as well to revert display name | [optional] 
**Password** | **string** | MUST specify currentPassword as well to change password | [optional] 
**CurrentPassword** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

