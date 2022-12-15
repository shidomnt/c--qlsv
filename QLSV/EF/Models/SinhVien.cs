using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace QLSV.EF.Models;

public partial class SinhVien
{
    public string Masv { get; set; } = null!;

    public string Hosv { get; set; } = null!;

    public string Tensv { get; set; } = null!;

    public string Diachi { get; set; } = null!;

    public string Noisinh { get; set; } = null!;

    public byte Gioitinh { get; set; } = 1;

    public DateTime Ngaysinh { get; set; } = DateTime.Now;

    public int Manganh { get; set; }

    [Browsable(false)]
    public virtual ICollection<KetQua> KetQuas { get; } = new List<KetQua>();

    [Browsable(false)]
    public virtual Nganh ManganhNavigation { get; set; } = null!;
}
