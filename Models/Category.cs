using System;
using System.Collections.Generic;

namespace MedistockAppCore.Models;

public partial class Category
{
    public int IdCategory { get; set; }

    public string NameC { get; set; } = null!;

    public virtual ICollection<Medicine> Medicines { get; set; } = new List<Medicine>();
}
