/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself and is **not** officially supported by VRChat. The documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility.  The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee or support for external applications using the API. Access to API endpoints may break **at any time, without notice**. Therefore, please **do not ping** VRChat Staff in the VRChat Discord if you are having API problems, as they do not provide API support. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programmatically retrieve or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintains API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open-source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.2
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Model;
using io.github.vrchatapi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace io.github.vrchatapi.Test
{
    /// <summary>
    ///  Class for testing Config
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ConfigTests
    {
        // TODO uncomment below to declare an instance variable for Config
        //private Config instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Config
            //instance = new Config();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Config
        /// </summary>
        [Test]
        public void ConfigInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Config
            //Assert.IsInstanceOf(typeof(Config), instance);
        }


        /// <summary>
        /// Test the property 'Address'
        /// </summary>
        [Test]
        public void AddressTest()
        {
            // TODO unit test for the property 'Address'
        }
        /// <summary>
        /// Test the property 'Announcements'
        /// </summary>
        [Test]
        public void AnnouncementsTest()
        {
            // TODO unit test for the property 'Announcements'
        }
        /// <summary>
        /// Test the property 'ApiKey'
        /// </summary>
        [Test]
        public void ApiKeyTest()
        {
            // TODO unit test for the property 'ApiKey'
        }
        /// <summary>
        /// Test the property 'AppName'
        /// </summary>
        [Test]
        public void AppNameTest()
        {
            // TODO unit test for the property 'AppName'
        }
        /// <summary>
        /// Test the property 'BuildVersionTag'
        /// </summary>
        [Test]
        public void BuildVersionTagTest()
        {
            // TODO unit test for the property 'BuildVersionTag'
        }
        /// <summary>
        /// Test the property 'ClientApiKey'
        /// </summary>
        [Test]
        public void ClientApiKeyTest()
        {
            // TODO unit test for the property 'ClientApiKey'
        }
        /// <summary>
        /// Test the property 'ClientBPSCeiling'
        /// </summary>
        [Test]
        public void ClientBPSCeilingTest()
        {
            // TODO unit test for the property 'ClientBPSCeiling'
        }
        /// <summary>
        /// Test the property 'ClientDisconnectTimeout'
        /// </summary>
        [Test]
        public void ClientDisconnectTimeoutTest()
        {
            // TODO unit test for the property 'ClientDisconnectTimeout'
        }
        /// <summary>
        /// Test the property 'ClientReservedPlayerBPS'
        /// </summary>
        [Test]
        public void ClientReservedPlayerBPSTest()
        {
            // TODO unit test for the property 'ClientReservedPlayerBPS'
        }
        /// <summary>
        /// Test the property 'ClientSentCountAllowance'
        /// </summary>
        [Test]
        public void ClientSentCountAllowanceTest()
        {
            // TODO unit test for the property 'ClientSentCountAllowance'
        }
        /// <summary>
        /// Test the property 'ContactEmail'
        /// </summary>
        [Test]
        public void ContactEmailTest()
        {
            // TODO unit test for the property 'ContactEmail'
        }
        /// <summary>
        /// Test the property 'CopyrightEmail'
        /// </summary>
        [Test]
        public void CopyrightEmailTest()
        {
            // TODO unit test for the property 'CopyrightEmail'
        }
        /// <summary>
        /// Test the property 'CurrentTOSVersion'
        /// </summary>
        [Test]
        public void CurrentTOSVersionTest()
        {
            // TODO unit test for the property 'CurrentTOSVersion'
        }
        /// <summary>
        /// Test the property 'DefaultAvatar'
        /// </summary>
        [Test]
        public void DefaultAvatarTest()
        {
            // TODO unit test for the property 'DefaultAvatar'
        }
        /// <summary>
        /// Test the property 'DeploymentGroup'
        /// </summary>
        [Test]
        public void DeploymentGroupTest()
        {
            // TODO unit test for the property 'DeploymentGroup'
        }
        /// <summary>
        /// Test the property 'DevAppVersionStandalone'
        /// </summary>
        [Test]
        public void DevAppVersionStandaloneTest()
        {
            // TODO unit test for the property 'DevAppVersionStandalone'
        }
        /// <summary>
        /// Test the property 'DevDownloadLinkWindows'
        /// </summary>
        [Test]
        public void DevDownloadLinkWindowsTest()
        {
            // TODO unit test for the property 'DevDownloadLinkWindows'
        }
        /// <summary>
        /// Test the property 'DevSdkUrl'
        /// </summary>
        [Test]
        public void DevSdkUrlTest()
        {
            // TODO unit test for the property 'DevSdkUrl'
        }
        /// <summary>
        /// Test the property 'DevSdkVersion'
        /// </summary>
        [Test]
        public void DevSdkVersionTest()
        {
            // TODO unit test for the property 'DevSdkVersion'
        }
        /// <summary>
        /// Test the property 'DevServerVersionStandalone'
        /// </summary>
        [Test]
        public void DevServerVersionStandaloneTest()
        {
            // TODO unit test for the property 'DevServerVersionStandalone'
        }
        /// <summary>
        /// Test the property 'DisableAvatarCopying'
        /// </summary>
        [Test]
        public void DisableAvatarCopyingTest()
        {
            // TODO unit test for the property 'DisableAvatarCopying'
        }
        /// <summary>
        /// Test the property 'DisableAvatarGating'
        /// </summary>
        [Test]
        public void DisableAvatarGatingTest()
        {
            // TODO unit test for the property 'DisableAvatarGating'
        }
        /// <summary>
        /// Test the property 'DisableCommunityLabs'
        /// </summary>
        [Test]
        public void DisableCommunityLabsTest()
        {
            // TODO unit test for the property 'DisableCommunityLabs'
        }
        /// <summary>
        /// Test the property 'DisableCommunityLabsPromotion'
        /// </summary>
        [Test]
        public void DisableCommunityLabsPromotionTest()
        {
            // TODO unit test for the property 'DisableCommunityLabsPromotion'
        }
        /// <summary>
        /// Test the property 'DisableEmail'
        /// </summary>
        [Test]
        public void DisableEmailTest()
        {
            // TODO unit test for the property 'DisableEmail'
        }
        /// <summary>
        /// Test the property 'DisableEventStream'
        /// </summary>
        [Test]
        public void DisableEventStreamTest()
        {
            // TODO unit test for the property 'DisableEventStream'
        }
        /// <summary>
        /// Test the property 'DisableFeedbackGating'
        /// </summary>
        [Test]
        public void DisableFeedbackGatingTest()
        {
            // TODO unit test for the property 'DisableFeedbackGating'
        }
        /// <summary>
        /// Test the property 'DisableHello'
        /// </summary>
        [Test]
        public void DisableHelloTest()
        {
            // TODO unit test for the property 'DisableHello'
        }
        /// <summary>
        /// Test the property 'DisableRegistration'
        /// </summary>
        [Test]
        public void DisableRegistrationTest()
        {
            // TODO unit test for the property 'DisableRegistration'
        }
        /// <summary>
        /// Test the property 'DisableSteamNetworking'
        /// </summary>
        [Test]
        public void DisableSteamNetworkingTest()
        {
            // TODO unit test for the property 'DisableSteamNetworking'
        }
        /// <summary>
        /// Test the property 'DisableTwoFactorAuth'
        /// </summary>
        [Test]
        public void DisableTwoFactorAuthTest()
        {
            // TODO unit test for the property 'DisableTwoFactorAuth'
        }
        /// <summary>
        /// Test the property 'DisableUdon'
        /// </summary>
        [Test]
        public void DisableUdonTest()
        {
            // TODO unit test for the property 'DisableUdon'
        }
        /// <summary>
        /// Test the property 'DisableUpgradeAccount'
        /// </summary>
        [Test]
        public void DisableUpgradeAccountTest()
        {
            // TODO unit test for the property 'DisableUpgradeAccount'
        }
        /// <summary>
        /// Test the property 'DownloadLinkWindows'
        /// </summary>
        [Test]
        public void DownloadLinkWindowsTest()
        {
            // TODO unit test for the property 'DownloadLinkWindows'
        }
        /// <summary>
        /// Test the property 'DownloadUrls'
        /// </summary>
        [Test]
        public void DownloadUrlsTest()
        {
            // TODO unit test for the property 'DownloadUrls'
        }
        /// <summary>
        /// Test the property 'DynamicWorldRows'
        /// </summary>
        [Test]
        public void DynamicWorldRowsTest()
        {
            // TODO unit test for the property 'DynamicWorldRows'
        }
        /// <summary>
        /// Test the property 'Events'
        /// </summary>
        [Test]
        public void EventsTest()
        {
            // TODO unit test for the property 'Events'
        }
        /// <summary>
        /// Test the property 'GearDemoRoomId'
        /// </summary>
        [Test]
        public void GearDemoRoomIdTest()
        {
            // TODO unit test for the property 'GearDemoRoomId'
        }
        /// <summary>
        /// Test the property 'HomepageRedirectTarget'
        /// </summary>
        [Test]
        public void HomepageRedirectTargetTest()
        {
            // TODO unit test for the property 'HomepageRedirectTarget'
        }
        /// <summary>
        /// Test the property 'HomeWorldId'
        /// </summary>
        [Test]
        public void HomeWorldIdTest()
        {
            // TODO unit test for the property 'HomeWorldId'
        }
        /// <summary>
        /// Test the property 'HubWorldId'
        /// </summary>
        [Test]
        public void HubWorldIdTest()
        {
            // TODO unit test for the property 'HubWorldId'
        }
        /// <summary>
        /// Test the property 'JobsEmail'
        /// </summary>
        [Test]
        public void JobsEmailTest()
        {
            // TODO unit test for the property 'JobsEmail'
        }
        /// <summary>
        /// Test the property 'MessageOfTheDay'
        /// </summary>
        [Test]
        public void MessageOfTheDayTest()
        {
            // TODO unit test for the property 'MessageOfTheDay'
        }
        /// <summary>
        /// Test the property 'ModerationEmail'
        /// </summary>
        [Test]
        public void ModerationEmailTest()
        {
            // TODO unit test for the property 'ModerationEmail'
        }
        /// <summary>
        /// Test the property 'ModerationQueryPeriod'
        /// </summary>
        [Test]
        public void ModerationQueryPeriodTest()
        {
            // TODO unit test for the property 'ModerationQueryPeriod'
        }
        /// <summary>
        /// Test the property 'NotAllowedToSelectAvatarInPrivateWorldMessage'
        /// </summary>
        [Test]
        public void NotAllowedToSelectAvatarInPrivateWorldMessageTest()
        {
            // TODO unit test for the property 'NotAllowedToSelectAvatarInPrivateWorldMessage'
        }
        /// <summary>
        /// Test the property 'Plugin'
        /// </summary>
        [Test]
        public void PluginTest()
        {
            // TODO unit test for the property 'Plugin'
        }
        /// <summary>
        /// Test the property 'ReleaseAppVersionStandalone'
        /// </summary>
        [Test]
        public void ReleaseAppVersionStandaloneTest()
        {
            // TODO unit test for the property 'ReleaseAppVersionStandalone'
        }
        /// <summary>
        /// Test the property 'ReleaseSdkUrl'
        /// </summary>
        [Test]
        public void ReleaseSdkUrlTest()
        {
            // TODO unit test for the property 'ReleaseSdkUrl'
        }
        /// <summary>
        /// Test the property 'ReleaseSdkVersion'
        /// </summary>
        [Test]
        public void ReleaseSdkVersionTest()
        {
            // TODO unit test for the property 'ReleaseSdkVersion'
        }
        /// <summary>
        /// Test the property 'ReleaseServerVersionStandalone'
        /// </summary>
        [Test]
        public void ReleaseServerVersionStandaloneTest()
        {
            // TODO unit test for the property 'ReleaseServerVersionStandalone'
        }
        /// <summary>
        /// Test the property 'SdkDeveloperFaqUrl'
        /// </summary>
        [Test]
        public void SdkDeveloperFaqUrlTest()
        {
            // TODO unit test for the property 'SdkDeveloperFaqUrl'
        }
        /// <summary>
        /// Test the property 'SdkDiscordUrl'
        /// </summary>
        [Test]
        public void SdkDiscordUrlTest()
        {
            // TODO unit test for the property 'SdkDiscordUrl'
        }
        /// <summary>
        /// Test the property 'SdkNotAllowedToPublishMessage'
        /// </summary>
        [Test]
        public void SdkNotAllowedToPublishMessageTest()
        {
            // TODO unit test for the property 'SdkNotAllowedToPublishMessage'
        }
        /// <summary>
        /// Test the property 'SdkUnityVersion'
        /// </summary>
        [Test]
        public void SdkUnityVersionTest()
        {
            // TODO unit test for the property 'SdkUnityVersion'
        }
        /// <summary>
        /// Test the property 'ServerName'
        /// </summary>
        [Test]
        public void ServerNameTest()
        {
            // TODO unit test for the property 'ServerName'
        }
        /// <summary>
        /// Test the property 'SupportEmail'
        /// </summary>
        [Test]
        public void SupportEmailTest()
        {
            // TODO unit test for the property 'SupportEmail'
        }
        /// <summary>
        /// Test the property 'TimeOutWorldId'
        /// </summary>
        [Test]
        public void TimeOutWorldIdTest()
        {
            // TODO unit test for the property 'TimeOutWorldId'
        }
        /// <summary>
        /// Test the property 'TutorialWorldId'
        /// </summary>
        [Test]
        public void TutorialWorldIdTest()
        {
            // TODO unit test for the property 'TutorialWorldId'
        }
        /// <summary>
        /// Test the property 'UpdateRateMsMaximum'
        /// </summary>
        [Test]
        public void UpdateRateMsMaximumTest()
        {
            // TODO unit test for the property 'UpdateRateMsMaximum'
        }
        /// <summary>
        /// Test the property 'UpdateRateMsMinimum'
        /// </summary>
        [Test]
        public void UpdateRateMsMinimumTest()
        {
            // TODO unit test for the property 'UpdateRateMsMinimum'
        }
        /// <summary>
        /// Test the property 'UpdateRateMsNormal'
        /// </summary>
        [Test]
        public void UpdateRateMsNormalTest()
        {
            // TODO unit test for the property 'UpdateRateMsNormal'
        }
        /// <summary>
        /// Test the property 'UpdateRateMsUdonManual'
        /// </summary>
        [Test]
        public void UpdateRateMsUdonManualTest()
        {
            // TODO unit test for the property 'UpdateRateMsUdonManual'
        }
        /// <summary>
        /// Test the property 'UploadAnalysisPercent'
        /// </summary>
        [Test]
        public void UploadAnalysisPercentTest()
        {
            // TODO unit test for the property 'UploadAnalysisPercent'
        }
        /// <summary>
        /// Test the property 'UrlList'
        /// </summary>
        [Test]
        public void UrlListTest()
        {
            // TODO unit test for the property 'UrlList'
        }
        /// <summary>
        /// Test the property 'UseReliableUdpForVoice'
        /// </summary>
        [Test]
        public void UseReliableUdpForVoiceTest()
        {
            // TODO unit test for the property 'UseReliableUdpForVoice'
        }
        /// <summary>
        /// Test the property 'UserUpdatePeriod'
        /// </summary>
        [Test]
        public void UserUpdatePeriodTest()
        {
            // TODO unit test for the property 'UserUpdatePeriod'
        }
        /// <summary>
        /// Test the property 'UserVerificationDelay'
        /// </summary>
        [Test]
        public void UserVerificationDelayTest()
        {
            // TODO unit test for the property 'UserVerificationDelay'
        }
        /// <summary>
        /// Test the property 'UserVerificationRetry'
        /// </summary>
        [Test]
        public void UserVerificationRetryTest()
        {
            // TODO unit test for the property 'UserVerificationRetry'
        }
        /// <summary>
        /// Test the property 'UserVerificationTimeout'
        /// </summary>
        [Test]
        public void UserVerificationTimeoutTest()
        {
            // TODO unit test for the property 'UserVerificationTimeout'
        }
        /// <summary>
        /// Test the property 'ViveWindowsUrl'
        /// </summary>
        [Test]
        public void ViveWindowsUrlTest()
        {
            // TODO unit test for the property 'ViveWindowsUrl'
        }
        /// <summary>
        /// Test the property 'WhiteListedAssetUrls'
        /// </summary>
        [Test]
        public void WhiteListedAssetUrlsTest()
        {
            // TODO unit test for the property 'WhiteListedAssetUrls'
        }
        /// <summary>
        /// Test the property 'WorldUpdatePeriod'
        /// </summary>
        [Test]
        public void WorldUpdatePeriodTest()
        {
            // TODO unit test for the property 'WorldUpdatePeriod'
        }
        /// <summary>
        /// Test the property 'YoutubedlHash'
        /// </summary>
        [Test]
        public void YoutubedlHashTest()
        {
            // TODO unit test for the property 'YoutubedlHash'
        }
        /// <summary>
        /// Test the property 'YoutubedlVersion'
        /// </summary>
        [Test]
        public void YoutubedlVersionTest()
        {
            // TODO unit test for the property 'YoutubedlVersion'
        }

    }

}
