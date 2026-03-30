# CLAUDE.md -- JasperAI SDK

## Overview

Auto-generated C# SDK for [Jasper AI](https://www.jasper.ai/) -- AI marketing content generation platform covering commands, agent tasks, knowledge management, brand voices, style guides, documents, audiences, and usage tracking.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Jasper AI API documentation at [developers.jasper.ai](https://developers.jasper.ai).

## Build & Test

```bash
dotnet build JasperAI.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth via `X-API-Key` header (native via `--security-scheme`):

```csharp
var client = new JasperAIClient(apiKey); // JASPERAI_API_KEY env var
```

## Key Files

- `src/libs/JasperAI/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Jasper)
- `src/libs/JasperAI/generate.sh` -- Runs autosdk with `--security-scheme ApiKey:Header:X-API-Key` (no download step)
- `src/libs/JasperAI/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/JasperAI/Extensions/JasperAIClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with API key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new JasperAIClient(apiKey);

// Command -- generate AI content
client.Command.CommandAsync(request)

// Tasks -- agent task workflows
client.Tasks.ListTasksAsync()
client.Tasks.GetTaskByIdAsync(id)
client.Tasks.RunTaskAsync(id, request)

// Knowledge -- knowledge base management
client.Knowledge.GetKnowledgeDocumentsAsync()
client.Knowledge.SearchKnowledgeAsync(request)
client.Knowledge.UploadKnowledgeDocumentAsync(...)

// Voices -- brand voice/tone management
client.Voices.GetAllTonesAsync()
client.Voices.CreateToneAsync(request)

// Styles -- style guide management
client.Styles.GetStylesAsync()
client.Styles.GetStyleByIdAsync(styleId)

// Documents -- document management
client.Documents.GetAllDocumentsAsync()
client.Documents.CreateDocumentAsync(request)

// Users -- workspace user management
client.Users.GetAllUsersAsync()

// Audiences -- target audience management
client.Audiences.GetAudiencesAsync()

// Usage -- API usage metrics
client.Usage.GetUsageAsync()
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsGenerateContentTool()` -- Generate AI marketing content via Jasper's command endpoint
- `AsSearchKnowledgeTool()` -- Search the knowledge base with natural language
- `AsListTasksTool()` -- List available agent tasks with optional search
- `AsListVoicesTool()` -- List brand voices/tones

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/command` | POST | Generate AI content from a command/prompt |
| `/tasks` | GET | List all agent tasks |
| `/tasks/{id}` | GET | Get agent task by ID |
| `/tasks/{id}/run` | POST | Run an agent task |
| `/knowledge` | POST | Upload knowledge document |
| `/knowledge` | GET | List knowledge items |
| `/knowledge/{knowledgeId}` | GET/PATCH/DELETE | CRUD knowledge item |
| `/knowledge/search` | POST | Search knowledge base |
| `/tones` | POST/GET | Create/list brand voices |
| `/tones/{toneId}` | GET/PATCH/DELETE | CRUD brand voice |
| `/styles` | GET | List style guides |
| `/styles/{styleId}` | GET | Get style guide by ID |
| `/documents` | GET/POST | List/create documents |
| `/documents/{documentId}` | GET/PATCH/DELETE | CRUD document |
| `/users` | GET | List workspace users |
| `/users/{userId}` | GET | Get user by ID |
| `/audiences` | GET | List audiences |
| `/audiences/{id}` | GET | Get audience by ID |
| `/usage` | GET | Get API usage metrics |

## Spec Notes

- Base URL: `https://api.jasper.ai/v1`
- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from [developers.jasper.ai](https://developers.jasper.ai) docs
- Auth: `X-API-Key` header -- native via `--security-scheme ApiKey:Header:X-API-Key`
- API requires Jasper Business plan for access
