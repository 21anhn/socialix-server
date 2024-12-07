using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Socialix.Models
{
    /// <summary>
    /// User Entity
    /// </summary>
    public class User : IdentityUser<Guid>
    {
        public override Guid Id { get => base.Id; set => base.Id = value; }
        public override string? UserName { get => base.UserName; set => base.UserName = value; }
        public override string? Email { get => base.Email; set => base.Email = value; }
        public override string? PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }
        public string FullName { get; set; } = string.Empty;
        public decimal DoB { get; set; } = 0;
        public string Bio { get; set; } = string.Empty;
        public string AvatarPhotoUrl { get; set; } = string.Empty;
        public string CoverPhotoUrl { get; set; } = string.Empty;
        public decimal CreatedAt { get; set; } = 0;
        public decimal UpdatedAt { get; set; } = 0;
        public decimal LastLogin { get; set; } = 0;
        public bool IsActived { get; set; } = false;
        public ICollection<Post>? Posts { get; set; }
        public ICollection<Message>? Messages { get; set; }
        public ICollection<Like>? Likes { get; set; }
        public ICollection<Friendship>? Friendships { get; set; }
        public ICollection<Follow>? Follows { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<UserRole>? UserRoles { get; set; }
    }
}