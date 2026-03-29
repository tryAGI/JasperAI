
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// Output item type.
    /// </summary>
    public enum TaskOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskOutputType value)
        {
            return value switch
            {
                TaskOutputType.Text => "TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskOutputType? ToEnum(string value)
        {
            return value switch
            {
                "TEXT" => TaskOutputType.Text,
                _ => null,
            };
        }
    }
}