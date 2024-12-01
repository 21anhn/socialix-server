
namespace Socialix.Models
{
    /// <summary>
    /// Follow Entity
    /// </summary>
    public class Follow : IBaseEntity
    {
        public Guid FollowerId { get; set; }
        public User? Follower { get; set; }
        public Guid FollowedId { get; set; }
        public User? Followed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
