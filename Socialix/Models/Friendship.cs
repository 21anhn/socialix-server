namespace Socialix.Models
{
    /// <summary>
    /// Friendship Entity
    /// </summary>
    public class Friendship
    {
        public Guid Id { get; set; }
        public Guid UserId1 { get; set; }
        public Guid UserId2 { get; set; }
        public string Status { get; set; } = string.Empty;
        public decimal CreatedAt { get; set; } = 0;
        public decimal UpdatedAt { get; set; } = 0;
        public User? User1 { get; set; }
        public User? User2 { get; set; }
        public bool IsDelete { get; set; }
    }
}
