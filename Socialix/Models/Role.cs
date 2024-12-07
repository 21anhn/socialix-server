using Microsoft.AspNetCore.Identity;

namespace Socialix.Models
{
    /// <summary>
    /// Role Entity
    /// </summary>
    public class Role : IdentityRole<Guid>
    {
        public override Guid Id { get => base.Id; set => base.Id = value; }
        public override string? Name { get => base.Name; set => base.Name = value; }
        public ICollection<UserRole>? UserRoles { get; set; }
    }
}
