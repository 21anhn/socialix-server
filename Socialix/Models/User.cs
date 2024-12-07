using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Socialix.Models;

public partial class User : IdentityUser<Guid>
{
    public override Guid Id { get => base.Id; set => base.Id = value; }

    public override string? UserName { get => base.UserName; set => base.UserName = value; }

    public override string? Email { get => base.Email; set => base.Email = value; }

    public override string? PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }

    public string? FullName { get; set; }

    public decimal? DoB { get; set; }

    public string? AvatarPhotoUrl { get; set; }

    public string? CoverPhotoUrl { get; set; }

    public string? Bio { get; set; }

    public decimal? CreatedAt { get; set; }

    public decimal? UpdatedAt { get; set; }

    public decimal? LastLogin { get; set; }

    public bool? IsActivated { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Follower> FollowerFollowerUsers { get; set; } = new List<Follower>();

    public virtual ICollection<Follower> FollowerUsers { get; set; } = new List<Follower>();

    public virtual ICollection<Friendship> FriendshipUserId1Navigations { get; set; } = new List<Friendship>();

    public virtual ICollection<Friendship> FriendshipUserId2Navigations { get; set; } = new List<Friendship>();

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual ICollection<Message> MessageReceivers { get; set; } = new List<Message>();

    public virtual ICollection<Message> MessageSenders { get; set; } = new List<Message>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
