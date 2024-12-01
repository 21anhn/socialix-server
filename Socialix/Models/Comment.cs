
namespace Socialix.Models
{
    /// <summary>
    /// Comment Entity
    /// </summary>
    public class Comment : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public List<string>? ImageUrls { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
