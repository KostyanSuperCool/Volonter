using System;
using System.Collections.Generic;

namespace Volonter.Folder;

public partial class EventsName
{
    public int Id { get; set; }

    public string Event { get; set; } = null!;

    public virtual ICollection<RegistersVolonter> RegistersVolonters { get; set; } = new List<RegistersVolonter>();
}
