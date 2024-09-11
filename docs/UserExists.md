# VRChat.API.Model.UserExists
Status object representing if a queried user by username or userId exists or not. This model is primarily used by the `/auth/exists` endpoint, which in turn is used during registration. Please see the documentation on that endpoint for more information on usage.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**_UserExists** | **bool** | Status if a user exist with that username or userId. | [default to false]
**NameOk** | **bool** | Is the username valid? | [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

