
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskContextItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Checkbox,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        ImageId,
        /// <summary>
        /// 
        /// </summary>
        Input,
        /// <summary>
        /// 
        /// </summary>
        Knowledge,
        /// <summary>
        /// 
        /// </summary>
        Multiselect,
        /// <summary>
        /// 
        /// </summary>
        Select,
        /// <summary>
        /// 
        /// </summary>
        TagsInput,
        /// <summary>
        /// 
        /// </summary>
        Textarea,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskContextItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskContextItemType value)
        {
            return value switch
            {
                TaskContextItemType.Checkbox => "CHECKBOX",
                TaskContextItemType.Custom => "CUSTOM",
                TaskContextItemType.ImageId => "IMAGE_ID",
                TaskContextItemType.Input => "INPUT",
                TaskContextItemType.Knowledge => "KNOWLEDGE",
                TaskContextItemType.Multiselect => "MULTISELECT",
                TaskContextItemType.Select => "SELECT",
                TaskContextItemType.TagsInput => "TAGS_INPUT",
                TaskContextItemType.Textarea => "TEXTAREA",
                TaskContextItemType.Tool => "TOOL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskContextItemType? ToEnum(string value)
        {
            return value switch
            {
                "CHECKBOX" => TaskContextItemType.Checkbox,
                "CUSTOM" => TaskContextItemType.Custom,
                "IMAGE_ID" => TaskContextItemType.ImageId,
                "INPUT" => TaskContextItemType.Input,
                "KNOWLEDGE" => TaskContextItemType.Knowledge,
                "MULTISELECT" => TaskContextItemType.Multiselect,
                "SELECT" => TaskContextItemType.Select,
                "TAGS_INPUT" => TaskContextItemType.TagsInput,
                "TEXTAREA" => TaskContextItemType.Textarea,
                "TOOL" => TaskContextItemType.Tool,
                _ => null,
            };
        }
    }
}