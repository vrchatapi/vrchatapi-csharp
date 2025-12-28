#!/usr/bin/env bash

if [ ${#} -le 1 ]
then
  echo "Usage: generate.sh <openapi.yaml> <version>" >&2
  exit 1
fi

rm src docs *.nupkg *.snupkg -rf

./node_modules/\@openapitools/openapi-generator-cli/main.js generate \
-g csharp \
--library httpclient \
--additional-properties=packageGuid=1c420561-97f1-4810-ad2d-cd344d27170a,packageName=VRChat.API,packageTags=vrchat,packageVersion="${2}",targetFramework=net8.0,licenseId=MIT,equatable=true \
--git-user-id=vrchatapi \
--git-repo-id=vrchatapi-csharp \
-o . \
-i "${1}" \
--http-user-agent="vrchatapi-csharp"

rm build.sh
rm build.bat
rm git_push.sh
rm mono_nunit_test.sh
rm nuget.exe
rm appveyor.yml

rm -rf docs/
rm -rf api/
rm -rf src/VRChat.API.Test/

# Move wrapper code to src/VRChat.API/Client/
cp -r wrapper/VRChat.API/Client/* src/VRChat.API/Client/

cp wrapper/VRChat.API.Extensions.Hosting/vrc_cat.ico src/VRChat.API/vrc_cat.ico
cp wrapper/VRChat.API.Extensions.Hosting/vrc_cat.png src/VRChat.API/vrc_cat.png

# Fix cookie handling
for file in $(find ./src/VRChat.API -name '*.cs'); do
    sed -i 's/new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth"))/new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth"), "\/", "api.vrchat.cloud")/g' $file
    sed -i 's/new Cookie("twoFactorAuth", this.Configuration.GetApiKeyWithPrefix("twoFactorAuth"))/new Cookie("twoFactorAuth", this.Configuration.GetApiKeyWithPrefix("twoFactorAuth"), "\/", "api.vrchat.cloud")/g' $file
    sed -i 's/new Cookie(cookie.Name, cookie.Value)/new Cookie(cookie.Name, cookie.Value, cookie.Path, cookie.Domain)/g' $file
done

# Add ITwoFactorCode to two-factor authentication types
sed -i 's/\(class.*IValidatableObject\)/\1, ITwoFactorCode/' src/VRChat.API/Model/TwoFactorAuthCode.cs
sed -i 's/\(class.*IValidatableObject\)/\1, ITwoFactorCode/' src/VRChat.API/Model/TwoFactorEmailCode.cs

# Add icons and readme to package
sed -i ':a;N;$!ba;s|\(.*\)</ItemGroup>|\1\t  <Content Include="vrc_cat.ico" />\n\t  <None Include="..\\README.md">\n\t    <Pack>True</Pack>\n\t    <PackagePath>\\</PackagePath>\n\t  </None>\n\t  <None Include="vrc_cat.png">\n\t    <Pack>True</Pack>\n\t    <PackagePath>\\</PackagePath>\n\t  </None>\n  </ItemGroup>|' src/VRChat.API/VRChat.API.csproj
sed -i '/<PackageTags>vrchat<\/PackageTags>/a\    <ApplicationIcon>vrc_cat.ico</ApplicationIcon>' src/VRChat.API/VRChat.API.csproj

# Adjust package tags
sed -i 's/<PackageTags>vrchat<\/PackageTags>/<PackageTags>vrchat,vrcapi,vrc-api,vrc<\/PackageTags>/' src/VRChat.API/VRChat.API.csproj

# Fix username and password encoding
sed -i 's/VRChat.API.Client.ClientUtils.Base64Encode(this.Configuration.Username + \":\" + this.Configuration.Password)/VRChat.API.Client.ClientUtils.Base64Encode(System.Web.HttpUtility.UrlEncode(this.Configuration.Username) + ":" + System.Web.HttpUtility.UrlEncode(this.Configuration.Password))/g' src/VRChat.API/Api/AuthenticationApi.cs

# Fix fields in csproj
sed -i 's/OpenAPI Library/VRChat API Library for .NET/' src/VRChat.API/VRChat.API.csproj
sed -i 's/A library generated from a OpenAPI doc/VRChat API Library for .NET/' src/VRChat.API/VRChat.API.csproj
sed -i 's/No Copyright/Copyright Â© 2021 Owners of GitHub organisation "vrchatapi" and individual contributors./' src/VRChat.API/VRChat.API.csproj
sed -i 's/OpenAPI/VRChat API Docs Community/' src/VRChat.API/VRChat.API.csproj
sed -i 's/Minor update/Automated deployment/' src/VRChat.API/VRChat.API.csproj

# Fix failure to compile
sed -i 's/<GenerateAssemblyInfo>false<\/GenerateAssemblyInfo>/<GenerateAssemblyInfo>true<\/GenerateAssemblyInfo>/' src/VRChat.API/VRChat.API.csproj

# Update VRChat.API.Extensions.Hosting version
sed -i "s|<Version>[^<]*</Version>|<Version>${2}</Version>|g" wrapper/VRChat.API.Extensions.Hosting/VRChat.API.Extensions.Hosting.csproj

# Add README.md to fields
sed -i '/PackageTags/a \    <PackageReadmeFile>README.md<\/PackageReadmeFile>' src/VRChat.API/VRChat.API.csproj
sed -i '/System.ComponentModel.Annotations/a \    <None Include="..\\README.md" Pack="true" PackagePath="\\"/>' src/VRChat.API/VRChat.API.csproj

# Add Otp.NET package to project
sed -i '/JsonSubTypes/a \    <PackageReference Include="Otp.NET" Version="1.4.0" \/>' src/VRChat.API/VRChat.API.csproj

# Make CurrentUser fields optional for 2FA response compatibility
sed -i 's/IsRequired = true/IsRequired = false/g' src/VRChat.API/Model/CurrentUser.cs

# Add RequiresTwoFactorAuth property to CurrentUser
sed -i '/public string UserIcon { get; set; }/a\\n        /// <summary>\n        /// An array of two-factor authentication methods available to use to with two factor authentication.\n        /// </summary>\n        [DataMember(Name = "requiresTwoFactorAuth", IsRequired = false, EmitDefaultValue = true)]\n        public List<string> RequiresTwoFactorAuth { get; set; }' src/VRChat.API/Model/CurrentUser.cs

# Remove messily pasted markdown at top of every file
for i in src/VRChat.API/*/*.cs; do
    sed -i '/VRChat API Banner/d' $i
done

cp README.md src/VRChat.API/
cp README.md src/
