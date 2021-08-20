/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself and is **not** officially supported by VRChat. The documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility.  The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee or support for external applications using the API. Access to API endpoints may break **at any time, without notice**. Therefore, please **do not ping** VRChat Staff in the VRChat Discord if you are having API problems, as they do not provide API support. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programmatically retrieve or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintains API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open-source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using io.github.vrchatapi.Client;
using io.github.vrchatapi.Api;
using io.github.vrchatapi.Model;

namespace io.github.vrchatapi.Test
{
    /// <summary>
    ///  Class for testing WorldsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WorldsApiTests
    {
        private WorldsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorldsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorldsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' WorldsApi
            //Assert.IsInstanceOf(typeof(WorldsApi), instance);
        }

        
        /// <summary>
        /// Test CreateWorld
        /// </summary>
        [Test]
        public void CreateWorldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InlineObject5 inlineObject5 = null;
            //var response = instance.CreateWorld(inlineObject5);
            //Assert.IsInstanceOf(typeof(World), response, "response is World");
        }
        
        /// <summary>
        /// Test DeleteWorld
        /// </summary>
        [Test]
        public void DeleteWorldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string worldId = null;
            //instance.DeleteWorld(worldId);
            
        }
        
        /// <summary>
        /// Test GetActiveWorlds
        /// </summary>
        [Test]
        public void GetActiveWorldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featured = null;
            //string sort = null;
            //int? n = null;
            //string order = null;
            //int? offset = null;
            //string search = null;
            //string tag = null;
            //string notag = null;
            //string releaseStatus = null;
            //string maxUnityVersion = null;
            //string minUnityVersion = null;
            //string platform = null;
            //var response = instance.GetActiveWorlds(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform);
            //Assert.IsInstanceOf(typeof(List<LimitedWorld>), response, "response is List<LimitedWorld>");
        }
        
        /// <summary>
        /// Test GetFavoritedWorlds
        /// </summary>
        [Test]
        public void GetFavoritedWorldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featured = null;
            //string sort = null;
            //int? n = null;
            //string order = null;
            //int? offset = null;
            //string search = null;
            //string tag = null;
            //string notag = null;
            //string releaseStatus = null;
            //string maxUnityVersion = null;
            //string minUnityVersion = null;
            //string platform = null;
            //string userId = null;
            //var response = instance.GetFavoritedWorlds(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId);
            //Assert.IsInstanceOf(typeof(List<LimitedWorld>), response, "response is List<LimitedWorld>");
        }
        
        /// <summary>
        /// Test GetRecentWorlds
        /// </summary>
        [Test]
        public void GetRecentWorldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featured = null;
            //string sort = null;
            //int? n = null;
            //string order = null;
            //int? offset = null;
            //string search = null;
            //string tag = null;
            //string notag = null;
            //string releaseStatus = null;
            //string maxUnityVersion = null;
            //string minUnityVersion = null;
            //string platform = null;
            //string userId = null;
            //var response = instance.GetRecentWorlds(featured, sort, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform, userId);
            //Assert.IsInstanceOf(typeof(List<LimitedWorld>), response, "response is List<LimitedWorld>");
        }
        
        /// <summary>
        /// Test GetWorld
        /// </summary>
        [Test]
        public void GetWorldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string worldId = null;
            //var response = instance.GetWorld(worldId);
            //Assert.IsInstanceOf(typeof(World), response, "response is World");
        }
        
        /// <summary>
        /// Test GetWorldInstance
        /// </summary>
        [Test]
        public void GetWorldInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string worldId = null;
            //string instanceId = null;
            //var response = instance.GetWorldInstance(worldId, instanceId);
            //Assert.IsInstanceOf(typeof(Instance), response, "response is Instance");
        }
        
        /// <summary>
        /// Test GetWorldMetadata
        /// </summary>
        [Test]
        public void GetWorldMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string worldId = null;
            //var response = instance.GetWorldMetadata(worldId);
            //Assert.IsInstanceOf(typeof(InlineResponse2006), response, "response is InlineResponse2006");
        }
        
        /// <summary>
        /// Test GetWorldPublishStatus
        /// </summary>
        [Test]
        public void GetWorldPublishStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string worldId = null;
            //var response = instance.GetWorldPublishStatus(worldId);
            //Assert.IsInstanceOf(typeof(InlineResponse2007), response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test PublishWorld
        /// </summary>
        [Test]
        public void PublishWorldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string worldId = null;
            //instance.PublishWorld(worldId);
            
        }
        
        /// <summary>
        /// Test SearchWorlds
        /// </summary>
        [Test]
        public void SearchWorldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string featured = null;
            //string sort = null;
            //string user = null;
            //string userId = null;
            //int? n = null;
            //string order = null;
            //int? offset = null;
            //string search = null;
            //string tag = null;
            //string notag = null;
            //string releaseStatus = null;
            //string maxUnityVersion = null;
            //string minUnityVersion = null;
            //string platform = null;
            //var response = instance.SearchWorlds(featured, sort, user, userId, n, order, offset, search, tag, notag, releaseStatus, maxUnityVersion, minUnityVersion, platform);
            //Assert.IsInstanceOf(typeof(List<LimitedWorld>), response, "response is List<LimitedWorld>");
        }
        
        /// <summary>
        /// Test UnpublishWorld
        /// </summary>
        [Test]
        public void UnpublishWorldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string worldId = null;
            //instance.UnpublishWorld(worldId);
            
        }
        
        /// <summary>
        /// Test UpdateWorld
        /// </summary>
        [Test]
        public void UpdateWorldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string worldId = null;
            //InlineObject6 inlineObject6 = null;
            //var response = instance.UpdateWorld(worldId, inlineObject6);
            //Assert.IsInstanceOf(typeof(World), response, "response is World");
        }
        
    }

}
