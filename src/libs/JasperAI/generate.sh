#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec available)

dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated

# Jasper AI has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: Jasper uses X-API-Key header. We generate with Http:Header:Bearer for constructor,
#       then PrepareRequest hook converts Bearer → X-API-Key at runtime.
autosdk generate openapi.yaml \
  --namespace JasperAI \
  --clientClassName JasperAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
