namespace Socialix.Models
{
    /// <summary>
    /// Role Entity
    /// </summary>
    public class Role
    {
        public Guid Id { get; set; }
        public string? RoleName { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
