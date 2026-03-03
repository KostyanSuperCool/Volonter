using System;
using System.Collections.Generic;

namespace Volonter;

public partial class StatusesEvent
{
    public int Id { get; set; }

    public string StatusEvent { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
