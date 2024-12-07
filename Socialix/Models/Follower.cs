using System;
using System.Collections.Generic;

namespace Socialix.Models;

public partial class Follower
{
    public Guid FollowerId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? FollowerUserId { get; set; }

    public decimal? CreatedAt { get; set; }

    public decimal? UpdatedAt { get; set; }

    public virtual User? FollowerUser { get; set; }

    public virtual User? User { get; set; }
}
