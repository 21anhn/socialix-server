using System;
using System.Collections.Generic;

namespace Socialix.Models;

public partial class Friendship
{
    public Guid FriendshipId { get; set; }

    public Guid? UserId1 { get; set; }

    public Guid? UserId2 { get; set; }

    public string? Status { get; set; }

    public decimal? CreatedAt { get; set; }

    public decimal? UpdatedAt { get; set; }

    public virtual User? UserId1Navigation { get; set; }

    public virtual User? UserId2Navigation { get; set; }
}
