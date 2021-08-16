#!/bin/bash

openapi-generator-cli generate \
-g csharp \
--additional-properties=packageName=io.github.vrchatapi \
--git-user-id=vrchatapi \
--git-repo-id=vrchatapi-csharp \
-o . \
-i https://vrchatapi.github.io/specification/openapi.yaml \
--http-user-agent="vrchatapi-csharp"

# Modify package.json
sed -i 's/Unlicense/MIT/g' ./package.json

./build.bat