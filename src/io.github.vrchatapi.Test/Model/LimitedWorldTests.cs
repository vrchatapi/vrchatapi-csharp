/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself and is **not** officially supported by VRChat. The documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility.  The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee or support for external applications using the API. Access to API endpoints may break **at any time, without notice**. Therefore, please **do not ping** VRChat Staff in the VRChat Discord if you are having API problems, as they do not provide API support. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programmatically retrieve or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintains API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open-source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.0
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
    ///  Class for testing LimitedWorld
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LimitedWorldTests
    {
        // TODO uncomment below to declare an instance variable for LimitedWorld
        //private LimitedWorld instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LimitedWorld
            //instance = new LimitedWorld();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LimitedWorld
        /// </summary>
        [Test]
        public void LimitedWorldInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" LimitedWorld
            //Assert.IsInstanceOf(typeof(LimitedWorld), instance);
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
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'AuthorId'
        /// </summary>
        [Test]
        public void AuthorIdTest()
        {
            // TODO unit test for the property 'AuthorId'
        }
        /// <summary>
        /// Test the property 'AuthorName'
        /// </summary>
        [Test]
        public void AuthorNameTest()
        {
            // TODO unit test for the property 'AuthorName'
        }
        /// <summary>
        /// Test the property 'Capacity'
        /// </summary>
        [Test]
        public void CapacityTest()
        {
            // TODO unit test for the property 'Capacity'
        }
        /// <summary>
        /// Test the property 'ImageUrl'
        /// </summary>
        [Test]
        public void ImageUrlTest()
        {
            // TODO unit test for the property 'ImageUrl'
        }
        /// <summary>
        /// Test the property 'ThumbnailImageUrl'
        /// </summary>
        [Test]
        public void ThumbnailImageUrlTest()
        {
            // TODO unit test for the property 'ThumbnailImageUrl'
        }
        /// <summary>
        /// Test the property 'ReleaseStatus'
        /// </summary>
        [Test]
        public void ReleaseStatusTest()
        {
            // TODO unit test for the property 'ReleaseStatus'
        }
        /// <summary>
        /// Test the property 'Organization'
        /// </summary>
        [Test]
        public void OrganizationTest()
        {
            // TODO unit test for the property 'Organization'
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
        /// Test the property 'Favorites'
        /// </summary>
        [Test]
        public void FavoritesTest()
        {
            // TODO unit test for the property 'Favorites'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Test]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
        /// <summary>
        /// Test the property 'PublicationDate'
        /// </summary>
        [Test]
        public void PublicationDateTest()
        {
            // TODO unit test for the property 'PublicationDate'
        }
        /// <summary>
        /// Test the property 'LabsPublicationDate'
        /// </summary>
        [Test]
        public void LabsPublicationDateTest()
        {
            // TODO unit test for the property 'LabsPublicationDate'
        }
        /// <summary>
        /// Test the property 'UnityPackages'
        /// </summary>
        [Test]
        public void UnityPackagesTest()
        {
            // TODO unit test for the property 'UnityPackages'
        }
        /// <summary>
        /// Test the property 'Popularity'
        /// </summary>
        [Test]
        public void PopularityTest()
        {
            // TODO unit test for the property 'Popularity'
        }
        /// <summary>
        /// Test the property 'Heat'
        /// </summary>
        [Test]
        public void HeatTest()
        {
            // TODO unit test for the property 'Heat'
        }
        /// <summary>
        /// Test the property 'Occupants'
        /// </summary>
        [Test]
        public void OccupantsTest()
        {
            // TODO unit test for the property 'Occupants'
        }

    }

}
