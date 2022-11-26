using QLSV.Models;

namespace QLSV.Controllers
{

    internal class SinhVienController : Controller
    {
        public SinhVienController(Database database, string tableName = "SinhVien") : base(database)
        {
            _tableName = tableName;
        }
        public List<SinhVienModel> Select()
        {
            string sql = $"select * from {_tableName}";
            List<SinhVienModel> listSV = new();
            _db.ExecQuery(sql, (err, reader) =>
            {
                if (err != null)
                {
                    Program.ShowError(err, "Loi khi select from sinh vien");
                }
                if (reader != null && !reader.IsClosed)
                {
                    var sinhVienEnumerable = Database.ExtractFromReader(reader, reader => new SinhVienModel(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetInt32(5),
                        reader.GetString(6),
                        reader.GetString(7)
                        )
                    );
                    listSV = new(sinhVienEnumerable);
                }
            });
            return listSV;
        }
        public void Insert(SinhVienModel sinhvienModel) 
        {
            string sql = @$"insert into 
SinhVien(MASV, HOSV, TENSV, DIACHI, NOISINH, GIOITINH, NGAYSINH, MANGANH) VALUES 
             ('{sinhvienModel.maSV}','{sinhvienModel.hoSV}',
                '{sinhvienModel.tenSV}','{sinhvienModel.diaChi}',
                '{sinhvienModel.noiSinh}','{sinhvienModel.gioiTinh}',
                '{sinhvienModel.ngaySinh}','{sinhvienModel.maNganh}')";
            _db.ExecQuery(sql, (err, _) =>
            {
                if (err is not null)
                {
                    Program.ShowError(err, "Loi khi Insert SinhVien");
                }
            });
        }
    }
}
