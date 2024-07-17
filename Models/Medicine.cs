using System;
using System.Collections.Generic;

namespace MedistockAppCore.Models;

public partial class Medicine
{
    public int IdMedicine { get; set; }

    public string NameM { get; set; } = null!;

    public string FormatM { get; set; } = null!;

    public int Stock { get; set; }

    public string ExpirationDate { get; set; } = null!;

    public int FkIdCategory { get; set; }

    public virtual Category FkIdCategoryNavigation { get; set; } = null!;

    public virtual ICollection<Medicinesprescription> Medicinesprescriptions { get; set; } = new List<Medicinesprescription>();
}
