namespace Socialix.Models
{
    /// <summary>
    /// Like Entity
    /// </summary>
    public class Like
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid PostId { get; set; }
        public Guid CommentId { get; set; }
        public decimal CreatedAt { get; set; } = 0;
        public decimal UpdatedAt { get; set; } = 0;
        public User? User { get; set; }
        public Post? Post { get; set; }
        public Comment? Comment { get; set; }
        public bool IsDelete { get; set; }
    }
}
