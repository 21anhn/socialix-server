using System;
using System.Collections.Generic;

namespace Socialix.Models;

public partial class Message
{
    public Guid MessageId { get; set; }

    public Guid? SenderId { get; set; }

    public Guid? ReceiverId { get; set; }

    public string? Content { get; set; }

    public decimal? CreatedAt { get; set; }

    public decimal? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual User? Receiver { get; set; }

    public virtual User? Sender { get; set; }
}
