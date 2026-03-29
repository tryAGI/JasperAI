
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::JasperAI.JsonConverters.CommandInputsRetrievalAddOnJsonConverter),

            typeof(global::JasperAI.JsonConverters.CommandInputsRetrievalAddOnNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.CommandOptionsLanguageFormalityJsonConverter),

            typeof(global::JasperAI.JsonConverters.CommandOptionsLanguageFormalityNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.CommandOptionsCompletionTypeJsonConverter),

            typeof(global::JasperAI.JsonConverters.CommandOptionsCompletionTypeNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.TaskRunRequestToolJsonConverter),

            typeof(global::JasperAI.JsonConverters.TaskRunRequestToolNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.TaskOutputTypeJsonConverter),

            typeof(global::JasperAI.JsonConverters.TaskOutputTypeNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.TaskContextItemTypeJsonConverter),

            typeof(global::JasperAI.JsonConverters.TaskContextItemTypeNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.TaskScopeJsonConverter),

            typeof(global::JasperAI.JsonConverters.TaskScopeNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.KnowledgeSettingsAppVisibilityJsonConverter),

            typeof(global::JasperAI.JsonConverters.KnowledgeSettingsAppVisibilityNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.VoiceSettingsAppVisibilityJsonConverter),

            typeof(global::JasperAI.JsonConverters.VoiceSettingsAppVisibilityNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.DocumentCreateRequestStatusJsonConverter),

            typeof(global::JasperAI.JsonConverters.DocumentCreateRequestStatusNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.DocumentUpdateRequestStatusJsonConverter),

            typeof(global::JasperAI.JsonConverters.DocumentUpdateRequestStatusNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.ListTasksScopeJsonConverter),

            typeof(global::JasperAI.JsonConverters.ListTasksScopeNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.GetAllDocumentsSortJsonConverter),

            typeof(global::JasperAI.JsonConverters.GetAllDocumentsSortNullableJsonConverter),

            typeof(global::JasperAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.CommandRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.CommandInputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.CommandOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.CommandInputsRetrievalAddOn), TypeInfoPropertyName = "CommandInputsRetrievalAddOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.CommandOptionsLanguageFormality), TypeInfoPropertyName = "CommandOptionsLanguageFormality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.WebScraperOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.WebSearchOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.CommandOptionsCompletionType), TypeInfoPropertyName = "CommandOptionsCompletionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.CommandResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.GeneratedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.GeneratedContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskContextItemPredefined))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskContextItemCustom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.TaskContextItemPredefined>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.TaskRunRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskRunRequestTool), TypeInfoPropertyName = "TaskRunRequestTool2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskOutputType), TypeInfoPropertyName = "TaskOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskRunResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.TaskOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskContextItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskContextItemType), TypeInfoPropertyName = "TaskContextItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.Task))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.TaskContextItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskScope), TypeInfoPropertyName = "TaskScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.Task>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.TaskGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.KnowledgeSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.KnowledgeSettingsAppVisibility), TypeInfoPropertyName = "KnowledgeSettingsAppVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.KnowledgeItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.KnowledgeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.KnowledgeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.KnowledgeItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.KnowledgeUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.KnowledgeSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.RelevantChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.KnowledgeSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.RelevantChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.KnowledgeSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.KnowledgeSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.VoiceCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.VoiceSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.VoiceUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.VoiceSettingsAppVisibility), TypeInfoPropertyName = "VoiceSettingsAppVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.VoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.VoiceListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.StyleTerm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.StyleRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.StyleGuide))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.StyleTerm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.StyleRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.StyleGuideListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.StyleGuide>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.StyleGuideResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.DocumentCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.DocumentCreateRequestStatus), TypeInfoPropertyName = "DocumentCreateRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.DocumentUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.DocumentUpdateRequestStatus), TypeInfoPropertyName = "DocumentUpdateRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.DocumentListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.DocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.UserListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.UserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.Audience))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.AudienceListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::JasperAI.Audience>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.AudienceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.UsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.UsageData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.UploadKnowledgeDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.ListTasksScope), TypeInfoPropertyName = "ListTasksScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::JasperAI.GetAllDocumentsSort), TypeInfoPropertyName = "GetAllDocumentsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.GeneratedContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.TaskContextItemPredefined>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.TaskRunRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.TaskOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.TaskContextItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.Task>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.KnowledgeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.RelevantChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.KnowledgeSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.StyleTerm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.StyleRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.StyleGuide>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::JasperAI.Audience>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}