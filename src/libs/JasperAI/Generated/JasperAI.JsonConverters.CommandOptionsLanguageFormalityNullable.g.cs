#nullable enable

namespace JasperAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CommandOptionsLanguageFormalityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::JasperAI.CommandOptionsLanguageFormality?>
    {
        /// <inheritdoc />
        public override global::JasperAI.CommandOptionsLanguageFormality? Read(
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
                        return global::JasperAI.CommandOptionsLanguageFormalityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::JasperAI.CommandOptionsLanguageFormality)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::JasperAI.CommandOptionsLanguageFormality?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::JasperAI.CommandOptionsLanguageFormality? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::JasperAI.CommandOptionsLanguageFormalityExtensions.ToValueString(value.Value));
            }
        }
    }
}
