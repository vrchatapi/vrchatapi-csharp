
# io.github.vrchatapi.Model.Config

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | VRChat&#39;s office address | [readonly] 
**Announcements** | [**List&lt;ConfigAnnouncements&gt;**](ConfigAnnouncements.md) | Public Announcements | [readonly] 
**ApiKey** | **string** | apiKey to be used for all other requests | [readonly] 
**AppName** | **string** | Game name | [readonly] [default to "VrChat"]
**BuildVersionTag** | **string** | Build tag of the API server | [readonly] 
**ClientApiKey** | **string** | apiKey to be used for all other requests | [readonly] 
**ClientBPSCeiling** | **decimal** | Unknown | [optional] 
**ClientDisconnectTimeout** | **decimal** | Unknown | [optional] 
**ClientReservedPlayerBPS** | **decimal** | Unknown | [optional] 
**ClientSentCountAllowance** | **decimal** | Unknown | [optional] 
**ContactEmail** | **string** | VRChat&#39;s contact email | [readonly] 
**CopyrightEmail** | **string** | VRChat&#39;s copyright-issues-related email | [readonly] 
**CurrentTOSVersion** | **decimal** | Current version number of the Terms of Service | [readonly] 
**DefaultAvatar** | **string** |  | 
**DeploymentGroup** | **DeploymentGroup** |  | 
**DevAppVersionStandalone** | **string** | Version number for game development build | [readonly] 
**DevDownloadLinkWindows** | **string** | Developer Download link | [readonly] 
**DevSdkUrl** | **string** | Link to download the development SDK, use downloadUrls instead | [readonly] 
**DevSdkVersion** | **string** | Version of the development SDK | [readonly] 
**DevServerVersionStandalone** | **string** | Version number for server development build | [readonly] 
**DisableAvatarCopying** | **bool** | Toggles if copying avatars should be disabled | [default to false]
**DisableAvatarGating** | **bool** | Toggles if avatar gating should be disabled. Avatar gating restricts uploading of avatars to people with the &#x60;system_avatar_access&#x60; Tag or &#x60;admin_avatar_access&#x60; Tag | [default to false]
**DisableCommunityLabs** | **bool** | Toggles if the Community Labs should be disabled | [default to false]
**DisableCommunityLabsPromotion** | **bool** | Toggles if promotion out of Community Labs should be disabled | [default to false]
**DisableEmail** | **bool** | Unknown | [optional] [default to false]
**DisableEventStream** | **bool** | Toggles if Analytics should be disabled (this sreportedly not used in the Client) | [default to false]
**DisableFeedbackGating** | **bool** | Toggles if feedback gating should be disabled. Feedback gating restricts submission of feedback (reporting a World or User) to people with the &#x60;system_feedback_access&#x60; Tag. | [default to false]
**DisableHello** | **bool** | Unknown | [optional] [default to false]
**DisableRegistration** | **bool** | Toggles if new user account registration should be disabled | [default to false]
**DisableSteamNetworking** | **bool** | Toggles if Steam Networking should be disabled. VRChat these days uses Photon Unity Networking (PUN) instead. | [default to true]
**DisableTwoFactorAuth** | **bool** | Toggles if 2FA should be disabled. | [default to false]
**DisableUdon** | **bool** | Toggles if Udon should be universally disabled in-game. | [default to false]
**DisableUpgradeAccount** | **bool** | Toggles if account upgrading \&quot;linking with Steam/Oculus\&quot; should be disabled. | [default to false]
**DownloadLinkWindows** | **string** | Download link for game on the Oculus Rift website. | [readonly] 
**DownloadUrls** | [**ConfigDownloadUrls**](ConfigDownloadUrls.md) |  | 
**DynamicWorldRows** | [**List&lt;ConfigDynamicWorldRows&gt;**](ConfigDynamicWorldRows.md) | Array of DynamicWorldRow objects, used by the game to display the list of world rows | [readonly] 
**Events** | [**ConfigEvents**](ConfigEvents.md) |  | 
**GearDemoRoomId** | **string** | Unknown | [readonly] 
**HomepageRedirectTarget** | **string** | Redirect target if you try to open the base API domain in your browser | [readonly] [default to "https://hello.vrchat.com"]
**HomeWorldId** | **string** |  | 
**HubWorldId** | **string** |  | 
**JobsEmail** | **string** | VRChat&#39;s job application email | [readonly] 
**MessageOfTheDay** | **string** | MOTD | [readonly] 
**ModerationEmail** | **string** | VRChat&#39;s moderation related email | [readonly] 
**ModerationQueryPeriod** | **decimal** | Unknown | 
**NotAllowedToSelectAvatarInPrivateWorldMessage** | **string** | Used in-game to notify a user they aren&#39;t allowed to select avatars in private worlds | [readonly] 
**Plugin** | **string** | Extra [plugin](https://doc.photonengine.com/en-us/server/current/plugins/manual) to run in each instance | [readonly] 
**ReleaseAppVersionStandalone** | **string** | Version number for game release build | [readonly] 
**ReleaseSdkUrl** | **string** | Link to download the release SDK | [readonly] 
**ReleaseSdkVersion** | **string** | Version of the release SDK | [readonly] 
**ReleaseServerVersionStandalone** | **string** | Version number for server release build | [readonly] 
**SdkDeveloperFaqUrl** | **string** | Link to the developer FAQ | [readonly] 
**SdkDiscordUrl** | **string** | Link to the official VRChat Discord | [readonly] 
**SdkNotAllowedToPublishMessage** | **string** | Used in the SDK to notify a user they aren&#39;t allowed to upload avatars/worlds yet | [readonly] 
**SdkUnityVersion** | **string** | Unity version supported by the SDK | [readonly] 
**ServerName** | **string** | Server name of the API server currently responding | [readonly] 
**SupportEmail** | **string** | VRChat&#39;s support email | [readonly] 
**TimeOutWorldId** | **string** |  | 
**TutorialWorldId** | **string** |  | 
**UpdateRateMsMaximum** | **decimal** | Unknown | [readonly] 
**UpdateRateMsMinimum** | **decimal** | Unknown | [readonly] 
**UpdateRateMsNormal** | **decimal** | Unknown | [readonly] 
**UpdateRateMsUdonManual** | **decimal** | Unknown | [readonly] 
**UploadAnalysisPercent** | **decimal** | Unknown | [readonly] 
**UrlList** | **List&lt;string&gt;** | List of allowed URLs that bypass the \&quot;Allow untrusted URL&#39;s\&quot; setting in-game | [readonly] 
**UseReliableUdpForVoice** | **bool** | Unknown | [default to false]
**UserUpdatePeriod** | **decimal** | Unknown | [readonly] 
**UserVerificationDelay** | **decimal** | Unknown | [readonly] 
**UserVerificationRetry** | **decimal** | Unknown | [readonly] 
**UserVerificationTimeout** | **decimal** | Unknown | [readonly] 
**ViveWindowsUrl** | **string** | Download link for game on the Steam website. | [readonly] 
**WhiteListedAssetUrls** | **List&lt;string&gt;** | List of allowed URLs that are allowed to host avatar assets | [readonly] 
**WorldUpdatePeriod** | **decimal** | Unknown | [readonly] 
**YoutubedlHash** | **string** | Currently used youtube-dl.exe hash in SHA-256-delimited format | [readonly] 
**YoutubedlVersion** | **string** | Currently used youtube-dl.exe version | [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

