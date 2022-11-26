using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Models
{
    internal class SinhVienModel
    {
        public string maSV = string.Empty;
        public string hoSV = string.Empty;
        public string tenSV = string.Empty;
        public string diaChi = string.Empty;
        public string noiSinh = string.Empty;
        public int gioiTinh = 1;
        public string ngaySinh = string.Empty;
        public string maNganh = string.Empty;
        
        public SinhVienModel() { }
        public SinhVienModel(
            string _maSV,
            string _hoSV,
            string _tenSV,
            string _diaChi,
            string _noiSinh,
            int _gioiTinh,
            string _ngaySinh,
            string _maNganh
            ) {
            maSV = _maSV;
            hoSV = _hoSV;
            tenSV = _tenSV;
            diaChi = _diaChi;
            noiSinh = _noiSinh;
            gioiTinh = _gioiTinh;
            ngaySinh = _ngaySinh;
            maNganh = _maNganh;
        }
    }
}
