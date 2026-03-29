
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// Formality level of the output.
    /// </summary>
    public enum CommandOptionsLanguageFormality
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Less,
        /// <summary>
        /// 
        /// </summary>
        More,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommandOptionsLanguageFormalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommandOptionsLanguageFormality value)
        {
            return value switch
            {
                CommandOptionsLanguageFormality.Default => "default",
                CommandOptionsLanguageFormality.Less => "less",
                CommandOptionsLanguageFormality.More => "more",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommandOptionsLanguageFormality? ToEnum(string value)
        {
            return value switch
            {
                "default" => CommandOptionsLanguageFormality.Default,
                "less" => CommandOptionsLanguageFormality.Less,
                "more" => CommandOptionsLanguageFormality.More,
                _ => null,
            };
        }
    }
}