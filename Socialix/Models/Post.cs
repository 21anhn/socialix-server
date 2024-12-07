using System;
using System.Collections.Generic;

namespace Socialix.Models;

public partial class Post
{
    public Guid PostId { get; set; }

    public Guid? UserId { get; set; }

    public string? Content { get; set; }

    public string? MediaUrl { get; set; }

    public decimal? CreatedAt { get; set; }

    public decimal? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual User? User { get; set; }
}
