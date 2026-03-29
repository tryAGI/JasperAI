
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// Completion quality trade-off.<br/>
    /// Default Value: performance
    /// </summary>
    public enum CommandOptionsCompletionType
    {
        /// <summary>
        /// 
        /// </summary>
        Performance,
        /// <summary>
        /// 
        /// </summary>
        Quality,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommandOptionsCompletionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommandOptionsCompletionType value)
        {
            return value switch
            {
                CommandOptionsCompletionType.Performance => "performance",
                CommandOptionsCompletionType.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommandOptionsCompletionType? ToEnum(string value)
        {
            return value switch
            {
                "performance" => CommandOptionsCompletionType.Performance,
                "quality" => CommandOptionsCompletionType.Quality,
                _ => null,
            };
        }
    }
}