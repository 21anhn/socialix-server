namespace Socialix.Models
{
    /// <summary>
    /// Base Entity Interface
    /// </summary>
    public interface IBaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
