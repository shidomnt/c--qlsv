using System;
using System.Collections.Generic;

namespace QLSV.EF.Models;

public partial class MonHoc
{
    public int Mamon { get; set; }

    public string Tenmon { get; set; } = null!;

    public virtual ICollection<KetQua> KetQuas { get; } = new List<KetQua>();
}
