#nullable enable

namespace JasperAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class VoiceSettingsAppVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::JasperAI.VoiceSettingsAppVisibility>
    {
        /// <inheritdoc />
        public override global::JasperAI.VoiceSettingsAppVisibility Read(
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
                        return global::JasperAI.VoiceSettingsAppVisibilityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::JasperAI.VoiceSettingsAppVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::JasperAI.VoiceSettingsAppVisibility);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::JasperAI.VoiceSettingsAppVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::JasperAI.VoiceSettingsAppVisibilityExtensions.ToValueString(value));
        }
    }
}
