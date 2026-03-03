using System;
using System.Collections.Generic;

namespace Volonter;

public partial class StatusesRegister
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<RegistersVolonter> RegistersVolonters { get; set; } = new List<RegistersVolonter>();
}
