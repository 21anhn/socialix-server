namespace Socialix.Models
{
    /// <summary>
    /// Message Entity
    /// </summary>
    public class Message 
    {
        public Guid Id { get; set; }    
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Content { get; set; } = string.Empty;
        public List<string>? FileUrls { get; set; }
        public decimal CreatedAt { get; set; } = 0;
        public decimal UpdatedAt { get; set; } = 0;
        public User? Sender { get; set; }
        public User? Receiver { get; set; }
        public bool IsDelete { get; set; }  
    }
}
