namespace Socialix.Models
{
    /// <summary>
    /// Like Entity
    /// </summary>
    public class Like : IBaseEntity
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public Post? Post { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
