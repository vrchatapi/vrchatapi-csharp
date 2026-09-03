#!/usr/bin/env bash
set -euo pipefail

if [ ${#} -le 1 ]
then
  echo "Usage: generate.sh <openapi.yaml> <version>" >&2
  exit 1
fi

spec="${1}"
version="${2}"

# Applies a sed expression to a file, but only after confirming the text it targets is still
# there. sed exits 0 when it matches nothing, so without this guard a patch that stopped
# applying after a generator upgrade would fail silently.
patch_generated() {
  local file="${1}" probe="${2}" expression="${3}"

  if ! grep -qF "${probe}" "${file}"
  then
    echo "generate.sh: '${probe}' is no longer present in ${file}; the patch below is stale" >&2
    exit 1
  fi

  sed -i "${expression}" "${file}"
}

rm -rf src docs ./*.nupkg ./*.snupkg

# Output this repository does not ship is listed in .openapi-generator-ignore, so it is never
# written. Everything VRChat-specific about the generated code lives in ./templates, and the
# csproj customisation in ./templates/netcore_project.additions.mustache.
openapi-generator generate \
-g csharp \
-t ./templates \
--library httpclient \
--additional-properties=packageGuid=1c420561-97f1-4810-ad2d-cd344d27170a,packageName=VRChat.API,packageVersion="${version}",targetFramework=net8.0,licenseId=MIT,equatable=true,packageAuthors="VRChat API Docs Community",packageCompany="VRChat API Docs Community",packageTitle="VRChat API Library for .NET",packageDescription="VRChat API Library for .NET",packageCopyright="Copyright © 2021 Owners of GitHub organisation \"vrchatapi\" and individual contributors." \
--git-user-id=vrchatapi \
--git-repo-id=vrchatapi-csharp \
-o . \
-i "${spec}" \
--http-user-agent="vrchatapi-csharp"

cp wrapper/VRChat.API.Extensions.Hosting/vrc_cat.ico src/VRChat.API/vrc_cat.ico
cp wrapper/VRChat.API.Extensions.Hosting/vrc_cat.png src/VRChat.API/vrc_cat.png

cp README.md src/VRChat.API/
cp README.md src/

# The only edit to generated code that no template or partial class can express: CurrentUser is
# also returned mid-login, before two-factor verification, with most of its fields absent. The
# specification marks them required, which makes deserialising that response throw, so the
# generated attributes are relaxed for this one model.
patch_generated src/VRChat.API/Model/CurrentUser.cs \
  'IsRequired = true' 's/IsRequired = true/IsRequired = false/g'

# VRChat.API.Extensions.Hosting is hand-maintained, so its version is stamped rather than generated.
patch_generated wrapper/VRChat.API.Extensions.Hosting/VRChat.API.Extensions.Hosting.csproj \
  '<Version>' "s|<Version>[^<]*</Version>|<Version>${version}</Version>|g"
