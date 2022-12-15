using System;
using System.Collections.Generic;

namespace QLSV.EF.Models;

public partial class Nganh
{
    public int Manganh { get; set; }

    public string Tennganh { get; set; } = null!;

    public int Makhoa { get; set; }

    public virtual Khoa MakhoaNavigation { get; set; } = null!;

    public virtual ICollection<SinhVien> SinhViens { get; } = new List<SinhVien>();
}
