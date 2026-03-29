
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskRunRequestTool
    {
        /// <summary>
        /// 
        /// </summary>
        KnowledgeSearch,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskRunRequestToolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskRunRequestTool value)
        {
            return value switch
            {
                TaskRunRequestTool.KnowledgeSearch => "KNOWLEDGE_SEARCH",
                TaskRunRequestTool.WebSearch => "WEB_SEARCH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskRunRequestTool? ToEnum(string value)
        {
            return value switch
            {
                "KNOWLEDGE_SEARCH" => TaskRunRequestTool.KnowledgeSearch,
                "WEB_SEARCH" => TaskRunRequestTool.WebSearch,
                _ => null,
            };
        }
    }
}