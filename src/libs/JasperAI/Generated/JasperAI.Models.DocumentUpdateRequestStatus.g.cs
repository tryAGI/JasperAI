
#nullable enable

namespace JasperAI
{
    /// <summary>
    /// Updated document status.
    /// </summary>
    public enum DocumentUpdateRequestStatus
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
    public static class DocumentUpdateRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentUpdateRequestStatus value)
        {
            return value switch
            {
                DocumentUpdateRequestStatus.Completed => "COMPLETED",
                DocumentUpdateRequestStatus.Draft => "DRAFT",
                DocumentUpdateRequestStatus.InProgress => "IN_PROGRESS",
                DocumentUpdateRequestStatus.InReview => "IN_REVIEW",
                DocumentUpdateRequestStatus.Published => "PUBLISHED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentUpdateRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => DocumentUpdateRequestStatus.Completed,
                "DRAFT" => DocumentUpdateRequestStatus.Draft,
                "IN_PROGRESS" => DocumentUpdateRequestStatus.InProgress,
                "IN_REVIEW" => DocumentUpdateRequestStatus.InReview,
                "PUBLISHED" => DocumentUpdateRequestStatus.Published,
                _ => null,
            };
        }
    }
}