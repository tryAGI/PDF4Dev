#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://pdf4.dev/api/v1/openapi.json
autosdk generate openapi.yaml \
  --namespace PDF4Dev \
  --clientClassName PDF4DevClient \
  --targetFramework net10.0 \
  --security-scheme Http:Header:Bearer \
  --output Generated \
  --exclude-deprecated-operations
