using System;
using System.Collections.Generic;

namespace Socialix.Models;

public partial class Notification
{
    public Guid NotificationId { get; set; }

    public Guid? UserId { get; set; }

    public string? Message { get; set; }

    public decimal? CreatedAt { get; set; }

    public decimal? UpdatedAt { get; set; }

    public bool? IsRead { get; set; }

    public virtual User? User { get; set; }
}
