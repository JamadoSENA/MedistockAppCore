using System;
using System.Collections.Generic;

namespace MedistockAppCore.Models;

public partial class Patient
{
    public int IdPatient { get; set; }

    public string DocumentType { get; set; } = null!;

    public string NameU { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Birthdate { get; set; } = null!;

    public int Age { get; set; }

    public string Gender { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Profession { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Scheduling> Schedulings { get; set; } = new List<Scheduling>();
}
