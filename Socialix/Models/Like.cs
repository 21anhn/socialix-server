﻿using System;
using System.Collections.Generic;

namespace Socialix.Models;

public partial class Like
{
    public Guid LikeId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? PostId { get; set; }

    public Guid? CommentId { get; set; }

    public decimal? CreatedAt { get; set; }

    public decimal? UpdatedAt { get; set; }

    public virtual Comment? Comment { get; set; }

    public virtual Post? Post { get; set; }

    public virtual User? User { get; set; }
}
