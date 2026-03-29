#nullable enable

namespace JasperAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class KnowledgeSettingsAppVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::JasperAI.KnowledgeSettingsAppVisibility>
    {
        /// <inheritdoc />
        public override global::JasperAI.KnowledgeSettingsAppVisibility Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::JasperAI.KnowledgeSettingsAppVisibilityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::JasperAI.KnowledgeSettingsAppVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::JasperAI.KnowledgeSettingsAppVisibility);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::JasperAI.KnowledgeSettingsAppVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::JasperAI.KnowledgeSettingsAppVisibilityExtensions.ToValueString(value));
        }
    }
}
