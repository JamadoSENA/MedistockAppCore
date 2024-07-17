using System;
using System.Collections.Generic;

namespace MedistockAppCore.Models;

public partial class Prescription
{
    public int IdPrescription { get; set; }

    public string DateHour { get; set; } = null!;

    public string DescriptionP { get; set; } = null!;

    public string Medicines { get; set; } = null!;

    public int FkIdScheduling { get; set; }

    public virtual Scheduling FkIdSchedulingNavigation { get; set; } = null!;

    public virtual ICollection<Medicinesprescription> Medicinesprescriptions { get; set; } = new List<Medicinesprescription>();
}
