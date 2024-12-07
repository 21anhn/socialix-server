namespace Socialix.Models
{
    /// <summary>
    /// Post Entity
    /// </summary>
    public class Post
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; } = string.Empty;
        public List<string>? MediaUrls { get; set; }
        public decimal CreatedAt { get; set; } = 0;
        public decimal UpdatedAt { get; set; } = 0;
        public User? User { get; set; }
        public bool IsDelete { get; set; }
    }
}
