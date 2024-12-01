using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Socialix.Models
{
    /// <summary>
    /// User Entity
    /// </summary>
    public class User : IdentityUser, IBaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
        public string CoverPhotoUrl { get; set; } = string.Empty;
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? RoleId { get; set; }
        public virtual Role? Role { get; set; }
        public ICollection<Post>? Posts { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Follow>? Follows { get; set; }
        public ICollection<Friendship>? Friendships { get; set; }
        public ICollection<Message>? Messages { get; set; }
    }
}
