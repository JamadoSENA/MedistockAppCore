using System;
using System.Collections.Generic;

namespace MedistockAppCore.Models;

public partial class Scheduling
{
    public int IdScheduling { get; set; }

    public string Reason { get; set; } = null!;

    public string State { get; set; } = null!;

    public int FkIdPatient { get; set; }

    public int FkIdDoctor { get; set; }

    public virtual User FkIdDoctorNavigation { get; set; } = null!;

    public virtual Patient FkIdPatientNavigation { get; set; } = null!;

    public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}
