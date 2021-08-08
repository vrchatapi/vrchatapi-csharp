#!/bin/bash

openapi-generator-cli generate \
-g csharp \
--additional-properties=packageName=io.github.vrchatapi \
--git-user-id=vrchatapi \
--git-repo-id=vrchatapi-javascript \
-o . \
-i ../specification/openapi.yaml \
--http-user-agent="vrchatapi-javascript"

# Modify package.json
sed -i 's/Unlicense/MIT/g' ./package.json

./build.bat