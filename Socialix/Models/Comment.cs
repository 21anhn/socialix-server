
namespace Socialix.Models
{
    /// <summary>
    /// Comment Entity
    /// </summary>
    public class Comment 
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; } = string.Empty;
        public decimal CreatedAt { get; set; } = 0;
        public decimal UpdatedAt { get; set; } = 0;
        public Post? Post { get; set; }
        public User? User { get; set; }
        public bool IsDeleted { get; set; }
    }
}
