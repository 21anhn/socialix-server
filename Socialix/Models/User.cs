using Microsoft.AspNetCore.Identity;

namespace Socialix.Models
{
    /// <summary>
    /// User Entity
    /// </summary>
    public class User : IdentityUser<Guid>, IBaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
        public string CoverPhotoUrl { get; set; } = string.Empty;
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
