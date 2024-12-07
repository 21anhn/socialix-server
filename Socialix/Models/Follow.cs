
namespace Socialix.Models
{
    /// <summary>
    /// Follow Entity
    /// </summary>
    public class Follow
    {
        public Guid Id { get; set; }
        public Guid FollowingId { get; set; }
        public Guid FollowedId { get; set; }
        public decimal CreatedAt { get; set; } = 0;
        public decimal UpdatedAt { get; set; } = 0;
        public User? Following { get; set; }
        public User? Followed { get; set; }
        public bool IsDeleted { get; set; }

    }
}
