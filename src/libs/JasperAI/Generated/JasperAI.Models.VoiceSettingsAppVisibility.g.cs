
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// Whether the voice is available in the Jasper app.<br/>
    /// Default Value: visible
    /// </summary>
    public enum VoiceSettingsAppVisibility
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
    public static class VoiceSettingsAppVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSettingsAppVisibility value)
        {
            return value switch
            {
                VoiceSettingsAppVisibility.Hidden => "hidden",
                VoiceSettingsAppVisibility.Visible => "visible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSettingsAppVisibility? ToEnum(string value)
        {
            return value switch
            {
                "hidden" => VoiceSettingsAppVisibility.Hidden,
                "visible" => VoiceSettingsAppVisibility.Visible,
                _ => null,
            };
        }
    }
}