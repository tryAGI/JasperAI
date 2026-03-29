#nullable enable

namespace JasperAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class DocumentUpdateRequestStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::JasperAI.DocumentUpdateRequestStatus>
    {
        /// <inheritdoc />
        public override global::JasperAI.DocumentUpdateRequestStatus Read(
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
                        return global::JasperAI.DocumentUpdateRequestStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::JasperAI.DocumentUpdateRequestStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::JasperAI.DocumentUpdateRequestStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::JasperAI.DocumentUpdateRequestStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::JasperAI.DocumentUpdateRequestStatusExtensions.ToValueString(value));
        }
    }
}
