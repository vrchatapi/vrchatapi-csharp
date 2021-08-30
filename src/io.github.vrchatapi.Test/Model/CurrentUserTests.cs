/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself and is **not** officially supported by VRChat. The documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility.  The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee or support for external applications using the API. Access to API endpoints may break **at any time, without notice**. Therefore, please **do not ping** VRChat Staff in the VRChat Discord if you are having API problems, as they do not provide API support. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programmatically retrieve or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintains API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](https://github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open-source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.1.2
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
    ///  Class for testing CurrentUser
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CurrentUserTests
    {
        // TODO uncomment below to declare an instance variable for CurrentUser
        //private CurrentUser instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CurrentUser
            //instance = new CurrentUser();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CurrentUser
        /// </summary>
        [Test]
        public void CurrentUserInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" CurrentUser
            //Assert.IsInstanceOf(typeof(CurrentUser), instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Username'
        /// </summary>
        [Test]
        public void UsernameTest()
        {
            // TODO unit test for the property 'Username'
        }
        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Test]
        public void DisplayNameTest()
        {
            // TODO unit test for the property 'DisplayName'
        }
        /// <summary>
        /// Test the property 'UserIcon'
        /// </summary>
        [Test]
        public void UserIconTest()
        {
            // TODO unit test for the property 'UserIcon'
        }
        /// <summary>
        /// Test the property 'Bio'
        /// </summary>
        [Test]
        public void BioTest()
        {
            // TODO unit test for the property 'Bio'
        }
        /// <summary>
        /// Test the property 'BioLinks'
        /// </summary>
        [Test]
        public void BioLinksTest()
        {
            // TODO unit test for the property 'BioLinks'
        }
        /// <summary>
        /// Test the property 'ProfilePicOverride'
        /// </summary>
        [Test]
        public void ProfilePicOverrideTest()
        {
            // TODO unit test for the property 'ProfilePicOverride'
        }
        /// <summary>
        /// Test the property 'StatusDescription'
        /// </summary>
        [Test]
        public void StatusDescriptionTest()
        {
            // TODO unit test for the property 'StatusDescription'
        }
        /// <summary>
        /// Test the property 'PastDisplayNames'
        /// </summary>
        [Test]
        public void PastDisplayNamesTest()
        {
            // TODO unit test for the property 'PastDisplayNames'
        }
        /// <summary>
        /// Test the property 'HasEmail'
        /// </summary>
        [Test]
        public void HasEmailTest()
        {
            // TODO unit test for the property 'HasEmail'
        }
        /// <summary>
        /// Test the property 'HasPendingEmail'
        /// </summary>
        [Test]
        public void HasPendingEmailTest()
        {
            // TODO unit test for the property 'HasPendingEmail'
        }
        /// <summary>
        /// Test the property 'ObfuscatedEmail'
        /// </summary>
        [Test]
        public void ObfuscatedEmailTest()
        {
            // TODO unit test for the property 'ObfuscatedEmail'
        }
        /// <summary>
        /// Test the property 'ObfuscatedPendingEmail'
        /// </summary>
        [Test]
        public void ObfuscatedPendingEmailTest()
        {
            // TODO unit test for the property 'ObfuscatedPendingEmail'
        }
        /// <summary>
        /// Test the property 'EmailVerified'
        /// </summary>
        [Test]
        public void EmailVerifiedTest()
        {
            // TODO unit test for the property 'EmailVerified'
        }
        /// <summary>
        /// Test the property 'HasBirthday'
        /// </summary>
        [Test]
        public void HasBirthdayTest()
        {
            // TODO unit test for the property 'HasBirthday'
        }
        /// <summary>
        /// Test the property 'Unsubscribe'
        /// </summary>
        [Test]
        public void UnsubscribeTest()
        {
            // TODO unit test for the property 'Unsubscribe'
        }
        /// <summary>
        /// Test the property 'StatusHistory'
        /// </summary>
        [Test]
        public void StatusHistoryTest()
        {
            // TODO unit test for the property 'StatusHistory'
        }
        /// <summary>
        /// Test the property 'StatusFirstTime'
        /// </summary>
        [Test]
        public void StatusFirstTimeTest()
        {
            // TODO unit test for the property 'StatusFirstTime'
        }
        /// <summary>
        /// Test the property 'Friends'
        /// </summary>
        [Test]
        public void FriendsTest()
        {
            // TODO unit test for the property 'Friends'
        }
        /// <summary>
        /// Test the property 'FriendGroupNames'
        /// </summary>
        [Test]
        public void FriendGroupNamesTest()
        {
            // TODO unit test for the property 'FriendGroupNames'
        }
        /// <summary>
        /// Test the property 'CurrentAvatarImageUrl'
        /// </summary>
        [Test]
        public void CurrentAvatarImageUrlTest()
        {
            // TODO unit test for the property 'CurrentAvatarImageUrl'
        }
        /// <summary>
        /// Test the property 'CurrentAvatarThumbnailImageUrl'
        /// </summary>
        [Test]
        public void CurrentAvatarThumbnailImageUrlTest()
        {
            // TODO unit test for the property 'CurrentAvatarThumbnailImageUrl'
        }
        /// <summary>
        /// Test the property 'FallbackAvatar'
        /// </summary>
        [Test]
        public void FallbackAvatarTest()
        {
            // TODO unit test for the property 'FallbackAvatar'
        }
        /// <summary>
        /// Test the property 'CurrentAvatar'
        /// </summary>
        [Test]
        public void CurrentAvatarTest()
        {
            // TODO unit test for the property 'CurrentAvatar'
        }
        /// <summary>
        /// Test the property 'CurrentAvatarAssetUrl'
        /// </summary>
        [Test]
        public void CurrentAvatarAssetUrlTest()
        {
            // TODO unit test for the property 'CurrentAvatarAssetUrl'
        }
        /// <summary>
        /// Test the property 'AccountDeletionDate'
        /// </summary>
        [Test]
        public void AccountDeletionDateTest()
        {
            // TODO unit test for the property 'AccountDeletionDate'
        }
        /// <summary>
        /// Test the property 'AcceptedTOSVersion'
        /// </summary>
        [Test]
        public void AcceptedTOSVersionTest()
        {
            // TODO unit test for the property 'AcceptedTOSVersion'
        }
        /// <summary>
        /// Test the property 'SteamId'
        /// </summary>
        [Test]
        public void SteamIdTest()
        {
            // TODO unit test for the property 'SteamId'
        }
        /// <summary>
        /// Test the property 'SteamDetails'
        /// </summary>
        [Test]
        public void SteamDetailsTest()
        {
            // TODO unit test for the property 'SteamDetails'
        }
        /// <summary>
        /// Test the property 'OculusId'
        /// </summary>
        [Test]
        public void OculusIdTest()
        {
            // TODO unit test for the property 'OculusId'
        }
        /// <summary>
        /// Test the property 'HasLoggedInFromClient'
        /// </summary>
        [Test]
        public void HasLoggedInFromClientTest()
        {
            // TODO unit test for the property 'HasLoggedInFromClient'
        }
        /// <summary>
        /// Test the property 'HomeLocation'
        /// </summary>
        [Test]
        public void HomeLocationTest()
        {
            // TODO unit test for the property 'HomeLocation'
        }
        /// <summary>
        /// Test the property 'TwoFactorAuthEnabled'
        /// </summary>
        [Test]
        public void TwoFactorAuthEnabledTest()
        {
            // TODO unit test for the property 'TwoFactorAuthEnabled'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'DeveloperType'
        /// </summary>
        [Test]
        public void DeveloperTypeTest()
        {
            // TODO unit test for the property 'DeveloperType'
        }
        /// <summary>
        /// Test the property 'LastLogin'
        /// </summary>
        [Test]
        public void LastLoginTest()
        {
            // TODO unit test for the property 'LastLogin'
        }
        /// <summary>
        /// Test the property 'LastPlatform'
        /// </summary>
        [Test]
        public void LastPlatformTest()
        {
            // TODO unit test for the property 'LastPlatform'
        }
        /// <summary>
        /// Test the property 'AllowAvatarCopying'
        /// </summary>
        [Test]
        public void AllowAvatarCopyingTest()
        {
            // TODO unit test for the property 'AllowAvatarCopying'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'DateJoined'
        /// </summary>
        [Test]
        public void DateJoinedTest()
        {
            // TODO unit test for the property 'DateJoined'
        }
        /// <summary>
        /// Test the property 'IsFriend'
        /// </summary>
        [Test]
        public void IsFriendTest()
        {
            // TODO unit test for the property 'IsFriend'
        }
        /// <summary>
        /// Test the property 'FriendKey'
        /// </summary>
        [Test]
        public void FriendKeyTest()
        {
            // TODO unit test for the property 'FriendKey'
        }
        /// <summary>
        /// Test the property 'OnlineFriends'
        /// </summary>
        [Test]
        public void OnlineFriendsTest()
        {
            // TODO unit test for the property 'OnlineFriends'
        }
        /// <summary>
        /// Test the property 'ActiveFriends'
        /// </summary>
        [Test]
        public void ActiveFriendsTest()
        {
            // TODO unit test for the property 'ActiveFriends'
        }
        /// <summary>
        /// Test the property 'OfflineFriends'
        /// </summary>
        [Test]
        public void OfflineFriendsTest()
        {
            // TODO unit test for the property 'OfflineFriends'
        }

    }

}
