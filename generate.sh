#!/bin/bash

npm install @openapitools/openapi-generator-cli

rm src docs *.nupkg *.snupkg -rf

./node_modules/\@openapitools/openapi-generator-cli/main.js generate \
-g csharp-netcore \
--additional-properties=packageName=VRChat.API,packageTags=vrchat,,targetFramework=net5.0,licenseId=MIT \
--git-user-id=vrchatapi \
--git-repo-id=vrchatapi-csharp \
-o . \
-i https://raw.githubusercontent.com/vrchatapi/specification/gh-pages/openapi.yaml \
--http-user-agent="vrchatapi-csharp"

rmdir src/VRChat.API.Test/

# Enable global cookie storage
sed -i '/RestClient client = new RestClient/a \            client.CookieContainer = cookieContainer;\n' ./src/VRChat.API/Client/ApiClient.cs
sed -i '/private readonly string _baseUrl/a \        private readonly CookieContainer cookieContainer = new CookieContainer();\n' ./src/VRChat.API/Client/ApiClient.cs

# Remove messily pasted markdown at top of every file
for i in src/VRChat.API/*/*.cs; do
    sed -i '/VRChat API Banner/d' $i
done

#bash ./build.sh