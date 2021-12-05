#!/bin/bash

npm install @openapitools/openapi-generator-cli

rm src docs *.nupkg *.snupkg -rf

curl https://raw.githubusercontent.com/vrchatapi/specification/gh-pages/openapi.yaml --output openapi.yaml

SPEC_VERSION=`grep "^  version:" openapi.yaml | cut -d " " -f 4`

./node_modules/\@openapitools/openapi-generator-cli/main.js generate \
-g csharp-netcore \
--additional-properties=packageName=VRChat.API,packageTags=vrchat,packageVersion=$SPEC_VERSION,targetFramework=netstandard2.0,licenseId=MIT \
--git-user-id=vrchatapi \
--git-repo-id=vrchatapi-csharp \
-o . \
-i openapi.yaml \
--http-user-agent="vrchatapi-csharp"

rm openapi.yaml

rmdir src/VRChat.API.Test/

# Enable global cookie storage
sed -i '/RestClient client = new RestClient/a \            client.CookieContainer = CookieContainer;\n' ./src/VRChat.API/Client/ApiClient.cs
sed -i '/readonly string _baseUrl/a \        public static readonly CookieContainer CookieContainer = new CookieContainer();\n' ./src/VRChat.API/Client/ApiClient.cs
sed -i '/result.Cookies.Add(cookie);/a \                    client.CookieContainer.Add(cookie);' ./src/VRChat.API/Client/ApiClient.cs

# Fix fields in csproj
sed -i 's/OpenAPI Library/VRChat API Library for .NET/' src/VRChat.API/VRChat.API.csproj
sed -i 's/A library generated from a OpenAPI doc/VRChat API Library for .NET/' src/VRChat.API/VRChat.API.csproj
sed -i 's/No Copyright/Copyright © 2021 Owners of GitHub organisation "vrchatapi" and individual contributors./' src/VRChat.API/VRChat.API.csproj
sed -i 's/OpenAPI/VRChat API Docs Community/' src/VRChat.API/VRChat.API.csproj
sed -i 's/Minor update/Automated deployment/' src/VRChat.API/VRChat.API.csproj

# Add README.md to fields
sed -i '/PackageTags/a \    <PackageReadmeFile>docs\\README.md<\/PackageReadmeFile>' src/VRChat.API/VRChat.API.csproj
sed -i '/System.ComponentModel.Annotations/a \    <None Include="..\/..\/README.md" Pack="true" PackagePath="docs\\"/>' src/VRChat.API/VRChat.API.csproj

# Remove messily pasted markdown at top of every file
for i in src/VRChat.API/*/*.cs; do
    sed -i '/VRChat API Banner/d' $i
done

#bash ./build.sh