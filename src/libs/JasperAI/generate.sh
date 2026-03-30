#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec available)

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# Jasper AI has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: Jasper uses X-API-Key header.
autosdk generate openapi.yaml \
  --namespace JasperAI \
  --clientClassName JasperAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:X-API-Key
