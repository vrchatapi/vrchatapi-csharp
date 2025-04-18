# VRChat.API.Model.APIConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VoiceEnableDegradation** | **bool** | Unknown, probably voice optimization testing | [default to false]
**VoiceEnableReceiverLimiting** | **bool** | Unknown, probably voice optimization testing | [default to true]
**AccessLogsUrls** | [**APIConfigAccessLogsUrls**](APIConfigAccessLogsUrls.md) |  | 
**Address** | **string** | VRChat&#39;s office address | 
**AgeVerificationInviteVisible** | **bool** |  | 
**AgeVerificationP** | **bool** |  | 
**AgeVerificationStatusVisible** | **bool** |  | 
**AnalysisMaxRetries** | **int** | Max retries for avatar analysis requests | 
**AnalysisRetryInterval** | **int** | Interval between retries for avatar analysis requests | 
**Announcements** | [**List&lt;APIConfigAnnouncement&gt;**](APIConfigAnnouncement.md) | Public Announcements | 
**AnalyticsSegmentNewUIPctOfUsers** | **int** | Unknown | 
**AnalyticsSegmentNewUISalt** | **string** | Unknown | 
**AvailableLanguageCodes** | **List&lt;string&gt;** | List of supported Languages | 
**AvailableLanguages** | **List&lt;string&gt;** | List of supported Languages | 
**AvatarPerfLimiter** | [**APIConfigAvatarPerfLimiter**](APIConfigAvatarPerfLimiter.md) |  | 
**ChatboxLogBufferSeconds** | **int** | Unknown | [default to 40]
**ClientApiKey** | **string** | apiKey to be used for all other requests | 
**ClientBPSCeiling** | **int** | Unknown | [default to 18432]
**ClientDisconnectTimeout** | **int** | Unknown | [default to 30000]
**ClientNetDispatchThread** | **bool** | Unknown | [optional] [default to false]
**ClientNetDispatchThreadMobile** | **bool** | Unknown | [default to true]
**ClientNetInThread** | **bool** | Unknown | [optional] [default to false]
**ClientNetInThread2** | **bool** | Unknown | [optional] [default to false]
**ClientNetInThreadMobile** | **bool** | Unknown | [optional] [default to false]
**ClientNetInThreadMobile2** | **bool** | Unknown | [optional] [default to false]
**ClientNetOutThread** | **bool** | Unknown | [optional] [default to false]
**ClientNetOutThread2** | **bool** | Unknown | [optional] [default to false]
**ClientNetOutThreadMobile** | **bool** | Unknown | [optional] [default to false]
**ClientNetOutThreadMobile2** | **bool** | Unknown | [optional] [default to false]
**ClientQR** | **int** | Unknown | [optional] [default to 1]
**ClientReservedPlayerBPS** | **int** | Unknown | [default to 7168]
**ClientSentCountAllowance** | **int** | Unknown | [default to 15]
**Constants** | [**APIConfigConstants**](APIConfigConstants.md) |  | 
**ContactEmail** | **string** | VRChat&#39;s contact email | 
**CopyrightEmail** | **string** | VRChat&#39;s copyright-issues-related email | 
**CurrentPrivacyVersion** | **int** | Current version number of the Privacy Agreement | [optional] [default to 1]
**CurrentTOSVersion** | **int** | Current version number of the Terms of Service | 
**DefaultAvatar** | **string** |  | 
**DefaultStickerSet** | **string** |  | 
**DevLanguageCodes** | **List&lt;string&gt;** | Unknown | [optional] 
**DevSdkUrl** | **string** | Link to download the development SDK, use downloadUrls instead | 
**DevSdkVersion** | **string** | Version of the development SDK | 
**DisCountdown** | **DateTime** | Unknown, \&quot;dis\&quot; maybe for disconnect? | 
**DisableAVProInProton** | **bool** | Unknown | [optional] [default to false]
**DisableAvatarCopying** | **bool** | Toggles if copying avatars should be disabled | [default to false]
**DisableAvatarGating** | **bool** | Toggles if avatar gating should be disabled. Avatar gating restricts uploading of avatars to people with the &#x60;system_avatar_access&#x60; Tag or &#x60;admin_avatar_access&#x60; Tag | [default to false]
**DisableCommunityLabs** | **bool** | Toggles if the Community Labs should be disabled | [default to false]
**DisableCommunityLabsPromotion** | **bool** | Toggles if promotion out of Community Labs should be disabled | [default to false]
**DisableEmail** | **bool** | Unknown | [default to false]
**DisableCaptcha** | **bool** | Unknown | [optional] [default to true]
**DisableEventStream** | **bool** | Toggles if Analytics should be disabled. | [default to false]
**DisableFeedbackGating** | **bool** | Toggles if feedback gating should be disabled. Feedback gating restricts submission of feedback (reporting a World or User) to people with the &#x60;system_feedback_access&#x60; Tag. | [default to false]
**DisableFrontendBuilds** | **bool** | Unknown, probably toggles compilation of frontend web builds? So internal flag? | [default to false]
**DisableGiftDrops** | **bool** | Toggles if gift drops should be disabled | [default to false]
**DisableHello** | **bool** | Unknown | [default to false]
**DisableOculusSubs** | **bool** | Toggles if signing up for Subscriptions in Oculus is disabled or not. | [default to false]
**DisableRegistration** | **bool** | Toggles if new user account registration should be disabled. | [default to false]
**DisableSteamNetworking** | **bool** | Toggles if Steam Networking should be disabled. VRChat these days uses Photon Unity Networking (PUN) instead. | [default to true]
**DisableTwoFactorAuth** | **bool** | Toggles if 2FA should be disabled. | [default to false]
**DisableUdon** | **bool** | Toggles if Udon should be universally disabled in-game. | [default to false]
**DisableUpgradeAccount** | **bool** | Toggles if account upgrading \&quot;linking with Steam/Oculus\&quot; should be disabled. | [default to false]
**DownloadLinkWindows** | **string** | Download link for game on the Oculus Rift website. | 
**DownloadUrls** | [**APIConfigDownloadURLList**](APIConfigDownloadURLList.md) |  | 
**DynamicWorldRows** | [**List&lt;DynamicContentRow&gt;**](DynamicContentRow.md) | Array of DynamicWorldRow objects, used by the game to display the list of world rows | 
**EconomyPauseEnd** | **string** | Unknown | [optional] 
**EconomyPauseStart** | **string** | Unknown | [optional] 
**EconomyState** | **int** | Unknown | [optional] [default to 1]
**Events** | [**APIConfigEvents**](APIConfigEvents.md) |  | 
**ForceUseLatestWorld** | **bool** | Unknown | [default to true]
**GiftDisplayType** | **string** | Display type of gifts | 
**GoogleApiClientId** | **string** | Unknown | [default to "827942544393-r2ouvckvouldn9dg9uruseje575e878f.apps.googleusercontent.com"]
**HomeWorldId** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | 
**HomepageRedirectTarget** | **string** | Redirect target if you try to open the base API domain in your browser | [default to "https://hello.vrchat.com"]
**HubWorldId** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | 
**ImageHostUrlList** | **List&lt;string&gt;** | A list of explicitly allowed origins that worlds can request images from via the Udon&#39;s [VRCImageDownloader#DownloadImage](https://creators.vrchat.com/worlds/udon/image-loading/#downloadimage). | 
**JobsEmail** | **string** | VRChat&#39;s job application email | 
**MinSupportedClientBuildNumber** | [**APIConfigMinSupportedClientBuildNumber**](APIConfigMinSupportedClientBuildNumber.md) |  | 
**MinimumUnityVersionForUploads** | **string** | Minimum Unity version required for uploading assets | [default to "2019.0.0f1"]
**ModerationEmail** | **string** | VRChat&#39;s moderation related email | 
**NotAllowedToSelectAvatarInPrivateWorldMessage** | **string** | Used in-game to notify a user they aren&#39;t allowed to select avatars in private worlds | 
**OfflineAnalysis** | [**APIConfigOfflineAnalysis**](APIConfigOfflineAnalysis.md) |  | 
**PhotonNameserverOverrides** | **List&lt;string&gt;** | Unknown | 
**PhotonPublicKeys** | **List&lt;string&gt;** | Unknown | 
**ReportCategories** | [**APIConfigReportCategories**](APIConfigReportCategories.md) |  | 
**ReportFormUrl** | **string** | URL to the report form | [default to "https://help.vrchat.com/hc/en-us/requests/new?ticket_form_id=1500000182242&tf_360056455174=user_report&tf_360057451993={userId}&tf_1500001445142={reportedId}&tf_subject={reason} {category} By {contentType} {reportedName}&tf_description={description}"]
**ReportOptions** | [**APIConfigReportOptions**](APIConfigReportOptions.md) |  | 
**ReportReasons** | [**APIConfigReportReasons**](APIConfigReportReasons.md) |  | 
**RequireAgeVerificationBetaTag** | **bool** |  | 
**SdkDeveloperFaqUrl** | **string** | Link to the developer FAQ | 
**SdkDiscordUrl** | **string** | Link to the official VRChat Discord | 
**SdkNotAllowedToPublishMessage** | **string** | Used in the SDK to notify a user they aren&#39;t allowed to upload avatars/worlds yet | 
**SdkUnityVersion** | **string** | Unity version supported by the SDK | 
**StringHostUrlList** | **List&lt;string&gt;** | A list of explicitly allowed origins that worlds can request strings from via the Udon&#39;s [VRCStringDownloader.LoadUrl](https://creators.vrchat.com/worlds/udon/string-loading/#ivrcstringdownload). | 
**SupportEmail** | **string** | VRChat&#39;s support email | 
**SupportFormUrl** | **string** | VRChat&#39;s support form | 
**Timekeeping** | **bool** | Unknown | [default to true]
**TimeOutWorldId** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | 
**TutorialWorldId** | **string** | WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. | 
**UpdateRateMsMaximum** | **int** | Unknown | 
**UpdateRateMsMinimum** | **int** | Unknown | 
**UpdateRateMsNormal** | **int** | Unknown | 
**UpdateRateMsUdonManual** | **int** | Unknown | 
**UploadAnalysisPercent** | **int** | Unknown | 
**UrlList** | **List&lt;string&gt;** | List of allowed URLs that bypass the \&quot;Allow untrusted URL&#39;s\&quot; setting in-game | 
**UseReliableUdpForVoice** | **bool** | Unknown | [default to false]
**ViveWindowsUrl** | **string** | Download link for game on the Steam website. | 
**WhiteListedAssetUrls** | **List&lt;string&gt;** | List of allowed URLs that are allowed to host avatar assets | 
**PlayerUrlResolverVersion** | **string** | Currently used youtube-dl.exe version | 
**PlayerUrlResolverSha1** | **string** | Currently used youtube-dl.exe hash in SHA1-delimited format | 
**PublicKey** | **string** | Public key, hex encoded | 
**WebsocketMaxFriendsRefreshDelay** | **int** | Unknown | [default to 900]
**WebsocketQuickReconnectTime** | **int** | Unknown | [default to 2]
**WebsocketReconnectMaxDelay** | **int** | Unknown | [default to 2]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

