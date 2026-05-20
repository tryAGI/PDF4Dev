#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease

tmp_openapi="$(mktemp)"
if curl --fail --silent --show-error --location \
  --retry 5 \
  --retry-delay 5 \
  --retry-all-errors \
  -o "$tmp_openapi" \
  https://pdf4.dev/api/v1/openapi.json &&
  grep -Eq '"openapi"[[:space:]]*:|^openapi[[:space:]]*:' "$tmp_openapi"; then
  mv "$tmp_openapi" openapi.yaml
else
  rm -f "$tmp_openapi"
  if [ ! -s openapi.yaml ]; then
    echo "Failed to download PDF4Dev OpenAPI spec and no committed fallback is available." >&2
    exit 1
  fi

  echo "Warning: Failed to download a valid PDF4Dev OpenAPI spec; using committed openapi.yaml fallback." >&2
fi

rm -rf Generated
autosdk generate openapi.yaml \
  --namespace PDF4Dev \
  --clientClassName PDF4DevClient \
  --targetFramework net10.0 \
  --security-scheme Http:Header:Bearer \
  --output Generated \
  --exclude-deprecated-operations
