namespace Socialix.Models
{
    /// <summary>
    /// Friendship Entity
    /// </summary>
    public class Friendship : IBaseEntity
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Guid FriendId { get; set; }
        public User? Friend { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
