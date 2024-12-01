namespace Socialix.Models
{
    /// <summary>
    /// Notification Entity
    /// </summary>
    public class Notification : IBaseEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public string? Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
