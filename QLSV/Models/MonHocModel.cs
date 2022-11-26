using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV;

namespace QLSV.Models
{
    internal class MonHocModel
    {
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public MonHocModel()
        {
            this.MaMH = Convert.ToInt32(string.Empty);
            this.TenMH = string.Empty;
        }
        public MonHocModel(int MaMH, string TenMH)
        {
            this.MaMH = MaMH;
            this.TenMH = TenMH;
        }

    }
}
