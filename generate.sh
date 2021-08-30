#!/bin/bash

rm src docs -rf

openapi-generator-cli generate \
-g csharp \
--additional-properties=packageName=io.github.vrchatapi \
--git-user-id=vrchatapi \
--git-repo-id=vrchatapi-csharp \
-o . \
-i https://vrchatapi.github.io/specification/openapi.yaml \
--http-user-agent="vrchatapi-csharp"

rmdir src/io.github.vrchatapi.Test/

cp io.github.vrchatapi.csproj-template src/io.github.vrchatapi/io.github.vrchatapi.csproj

# Enable global cookie storage
sed -i '/RestClient = new RestClient/a \\n            this.RestClient.CookieContainer = new CookieContainer();\n' ./src/io.github.vrchatapi/Client/ApiClient.cs

./build.bat