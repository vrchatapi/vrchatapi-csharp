#!/bin/bash

npm install @openapitools/openapi-generator-cli

rm src docs -rf

./node_modules/\@openapitools/openapi-generator-cli/main.js generate \
-g csharp-netcore \
--additional-properties=packageName=VRChat.API,targetFramework=net5.0 \
--git-user-id=vrchatapi \
--git-repo-id=vrchatapi-csharp \
-o . \
-i https://raw.githubusercontent.com/vrchatapi/specification/gh-pages/openapi.yaml \
--http-user-agent="vrchatapi-csharp"

rmdir src/VRChat.API.Test/

#cp VRChat.API.csproj-template src/VRChat.API/VRChat.API.csproj

# Enable global cookie storage
#sed -i '/RestClient = new RestClient/a \\n            this.RestClient.CookieContainer = new CookieContainer();\n' ./src/VRChat.API/Client/ApiClient.cs

# Remove messily pasted markdown at top of every file
for i in src/VRChat.API/*/*.cs; do
    sed -i '/VRChat API Banner/d' $i
done

#bash ./build.sh