using System;
using System.Collections.Generic;

namespace Volonter.Folder;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdRole { get; set; }

    public string Email { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual ICollection<RegistersVolonter> RegistersVolonters { get; set; } = new List<RegistersVolonter>();
}
