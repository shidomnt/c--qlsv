using System;
using System.Collections.Generic;

namespace QLSV.EF.Models;

public partial class KetQua
{
    public int Mamon { get; set; }

    public string Masv { get; set; } = null!;

    public double Diem { get; set; }

    public virtual MonHoc MamonNavigation { get; set; } = null!;

    public virtual SinhVien MasvNavigation { get; set; } = null!;
}
