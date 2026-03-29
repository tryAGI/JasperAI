
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// The status of the document.
    /// </summary>
    public enum DocumentCreateRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        InReview,
        /// <summary>
        /// 
        /// </summary>
        Published,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentCreateRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentCreateRequestStatus value)
        {
            return value switch
            {
                DocumentCreateRequestStatus.Completed => "COMPLETED",
                DocumentCreateRequestStatus.Draft => "DRAFT",
                DocumentCreateRequestStatus.InProgress => "IN_PROGRESS",
                DocumentCreateRequestStatus.InReview => "IN_REVIEW",
                DocumentCreateRequestStatus.Published => "PUBLISHED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentCreateRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => DocumentCreateRequestStatus.Completed,
                "DRAFT" => DocumentCreateRequestStatus.Draft,
                "IN_PROGRESS" => DocumentCreateRequestStatus.InProgress,
                "IN_REVIEW" => DocumentCreateRequestStatus.InReview,
                "PUBLISHED" => DocumentCreateRequestStatus.Published,
                _ => null,
            };
        }
    }
}