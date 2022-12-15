using System;
using System.Collections.Generic;

namespace QLSV.EF.Models;

public partial class Khoa
{
    public int Makhoa { get; set; }

    public string Tenkhoa { get; set; } = null!;

    public virtual ICollection<Nganh> Nganhs { get; } = new List<Nganh>();
}
