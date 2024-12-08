namespace Socialix.Commons.Constants
{
    public partial class Message
    {
        /// <summary>
        /// Success
        /// </summary>
        public static readonly string I00001 = "I00001"; // The operation was successful.
        public static readonly string I00002 = "I00002"; // The operation has been completed successfully.
        public static readonly string I00003 = "I00003"; // Your request has been processed successfully.

        /// <summary>
        /// Error
        /// </summary>
        public static readonly string E00001 = "E00001"; // An error occurred while processing your request. Please try again later.
        public static readonly string E00002 = "E00002"; // Invalid input. Please check your information and try again.
        public static readonly string E00003 = "E00003"; // Unauthorized access. You do not have permission to perform this action.
        public static readonly string E00004 = "E00004"; // The requested resource could not be found. Please check your information.
        public static readonly string E99999 = "E99999"; // A system error occurred. Please contact technical support.

        /// <summary>
        /// Warning
        /// </summary>
        public static readonly string W00001 = "W00001"; // Warning: There might be an issue with your request. Please review and try again.
        public static readonly string W00002 = "W00002"; // Warning: The system storage is running low. Some functionalities may be affected.
        public static readonly string W99999 = "W99999"; // Warning: This feature will no longer be supported in the next version. Please refer to the documentation for more details.
    }
}
