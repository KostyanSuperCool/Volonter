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

    public virtual EventsName IdEventsNavigation { get; set; } = null!;

    public virtual StatusesRegister IdStatusRegisterNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
