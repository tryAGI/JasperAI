
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllDocumentsSort
    {
        /// <summary>
        /// 
        /// </summary>
        Alphabetical,
        /// <summary>
        /// 
        /// </summary>
        LastUpdated,
        /// <summary>
        /// 
        /// </summary>
        NewestCreated,
        /// <summary>
        /// 
        /// </summary>
        OldestCreated,
        /// <summary>
        /// 
        /// </summary>
        OldestUpdated,
        /// <summary>
        /// 
        /// </summary>
        ReverseAlphabetical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllDocumentsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllDocumentsSort value)
        {
            return value switch
            {
                GetAllDocumentsSort.Alphabetical => "ALPHABETICAL",
                GetAllDocumentsSort.LastUpdated => "LAST_UPDATED",
                GetAllDocumentsSort.NewestCreated => "NEWEST_CREATED",
                GetAllDocumentsSort.OldestCreated => "OLDEST_CREATED",
                GetAllDocumentsSort.OldestUpdated => "OLDEST_UPDATED",
                GetAllDocumentsSort.ReverseAlphabetical => "REVERSE_ALPHABETICAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllDocumentsSort? ToEnum(string value)
        {
            return value switch
            {
                "ALPHABETICAL" => GetAllDocumentsSort.Alphabetical,
                "LAST_UPDATED" => GetAllDocumentsSort.LastUpdated,
                "NEWEST_CREATED" => GetAllDocumentsSort.NewestCreated,
                "OLDEST_CREATED" => GetAllDocumentsSort.OldestCreated,
                "OLDEST_UPDATED" => GetAllDocumentsSort.OldestUpdated,
                "REVERSE_ALPHABETICAL" => GetAllDocumentsSort.ReverseAlphabetical,
                _ => null,
            };
        }
    }
}