namespace Socialix.Commons.Constants
{
    public partial class Message
    {
        public static string GetMessageById (string messageId)
        {
            return messageId switch
            {
                // Success
                "I00001" => "The operation was successful.",
                "I00002" => "The operation has been completed successfully.",
                "I00003" => "Your request has been processed successfully.",

                // Error
                "E00001" => "An error occurred while processing your request. Please try again later.",
                "E00002" => "Invalid input. Please check your information and try again.",
                "E00003" => "Unauthorized access. You do not have permission to perform this action.",
                "E00004" => "The requested resource could not be found. Please check your information.",
                "E99999" => "A system error occurred. Please contact technical support.",

                // Warning
                "W00001" => "There might be an issue with your request. Please review and try again.",
                "W00002" => "The system storage is running low. Some functionalities may be affected.",
                "W99999" => "This feature will no longer be supported in the next version. Please refer to the documentation for more details.",

                // Default message
                _ => "Unknown message ID."
            };
        }
    }
}
