namespace Socialix.Models
{
    /// <summary>
    /// Post Entity
    /// </summary>
    public class Post : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public List<string>? ImageUrls { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
