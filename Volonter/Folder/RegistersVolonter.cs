using System;
using System.Collections.Generic;

namespace Volonter.Folder;

public partial class RegistersVolonter
{
    public int Id { get; set; }

    public int IdEvents { get; set; }

    public int IdUser { get; set; }

    public DateOnly DateRegister { get; set; }

    public int IdStatusRegister { get; set; }

    public virtual EventsName EventsName { get; set; } = null!;

    public virtual StatusesRegister StatusesRegister { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
