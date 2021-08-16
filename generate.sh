#!/bin/bash

openapi-generator-cli generate \
-g csharp \
--additional-properties=packageName=io.github.vrchatapi \
--git-user-id=vrchatapi \
--git-repo-id=vrchatapi-csharp \
-o . \
-i https://vrchatapi.github.io/specification/openapi.yaml \
--http-user-agent="vrchatapi-csharp"

# Enable global cookie storage
sed -i '/partial void InterceptResponse(IRestRequest request, IRestResponse response);/a \\n        public CookieContainer CookieContainer { get; set; } = new CookieContainer();' ./src/io.github.vrchatapi/Client/ApiClient.cs
sed -i '/RestClient = new RestClient/a \\n            this.RestClient.CookieContainer = CookieContainer;\n' ./src/io.github.vrchatapi/Client/ApiClient.cs

./build.bat