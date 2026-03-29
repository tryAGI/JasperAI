
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// Task visibility scope.
    /// </summary>
    public enum TaskScope
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
    public static class TaskScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskScope value)
        {
            return value switch
            {
                TaskScope.Public => "PUBLIC",
                TaskScope.User => "USER",
                TaskScope.Workspace => "WORKSPACE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskScope? ToEnum(string value)
        {
            return value switch
            {
                "PUBLIC" => TaskScope.Public,
                "USER" => TaskScope.User,
                "WORKSPACE" => TaskScope.Workspace,
                _ => null,
            };
        }
    }
}