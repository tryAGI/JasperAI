
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// External data enhancement method.
    /// </summary>
    public enum CommandInputsRetrievalAddOn
    {
        /// <summary>
        /// 
        /// </summary>
        WebScraper,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CommandInputsRetrievalAddOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CommandInputsRetrievalAddOn value)
        {
            return value switch
            {
                CommandInputsRetrievalAddOn.WebScraper => "webScraper",
                CommandInputsRetrievalAddOn.WebSearch => "webSearch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CommandInputsRetrievalAddOn? ToEnum(string value)
        {
            return value switch
            {
                "webScraper" => CommandInputsRetrievalAddOn.WebScraper,
                "webSearch" => CommandInputsRetrievalAddOn.WebSearch,
                _ => null,
            };
        }
    }
}