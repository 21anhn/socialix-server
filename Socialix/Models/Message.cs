namespace Socialix.Models
{
    /// <summary>
    /// Message Entity
    /// </summary>
    public class Message : IBaseEntity
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public User? Sender { get; set; }
        public Guid ReceiverId { get; set; }
        public User? Receiver { get; set; }
        public string? Content { get; set; }
        public List<string>? ImageUrls { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
