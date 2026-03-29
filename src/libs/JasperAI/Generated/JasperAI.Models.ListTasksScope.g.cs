
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListTasksScope
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTasksScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTasksScope value)
        {
            return value switch
            {
                ListTasksScope.Public => "PUBLIC",
                ListTasksScope.User => "USER",
                ListTasksScope.Workspace => "WORKSPACE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTasksScope? ToEnum(string value)
        {
            return value switch
            {
                "PUBLIC" => ListTasksScope.Public,
                "USER" => ListTasksScope.User,
                "WORKSPACE" => ListTasksScope.Workspace,
                _ => null,
            };
        }
    }
}