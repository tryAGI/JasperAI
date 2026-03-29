#nullable enable

namespace JasperAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TaskRunRequestToolNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::JasperAI.TaskRunRequestTool?>
    {
        /// <inheritdoc />
        public override global::JasperAI.TaskRunRequestTool? Read(
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
                        return global::JasperAI.TaskRunRequestToolExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::JasperAI.TaskRunRequestTool)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::JasperAI.TaskRunRequestTool?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::JasperAI.TaskRunRequestTool? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::JasperAI.TaskRunRequestToolExtensions.ToValueString(value.Value));
            }
        }
    }
}
