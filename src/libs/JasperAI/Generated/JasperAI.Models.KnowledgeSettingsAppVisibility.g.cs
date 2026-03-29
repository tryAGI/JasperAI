
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// Whether the knowledge item is available in the Jasper app.<br/>
    /// Default Value: visible
    /// </summary>
    public enum KnowledgeSettingsAppVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Hidden,
        /// <summary>
        /// 
        /// </summary>
        Visible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeSettingsAppVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeSettingsAppVisibility value)
        {
            return value switch
            {
                KnowledgeSettingsAppVisibility.Hidden => "hidden",
                KnowledgeSettingsAppVisibility.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeSettingsAppVisibility? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => KnowledgeSettingsAppVisibility.Hidden,
                "visible" => KnowledgeSettingsAppVisibility.Visible,
                _ => null,
            };
        }
    }
}