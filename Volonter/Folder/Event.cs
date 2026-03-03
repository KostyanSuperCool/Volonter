using System;
using System.Collections.Generic;

namespace Volonter.Folder;

public partial class Event
{
    public int Id { get; set; }

    public string NameEvents { get; set; } = null!;

    public int IdCategories { get; set; }

    public DateOnly Data { get; set; }

    public string Place { get; set; } = null!;

    public int CountVolonter { get; set; }

    public int IdUser { get; set; }

    public int IdStatusEvents { get; set; }

    public virtual Category IdCategoriesNavigation { get; set; } = null!;

    public virtual StatusesEvent IdStatusEventsNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
