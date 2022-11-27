using Microsoft.Data.SqlClient;
using QLSV.Models;

namespace QLSV.Controllers
{

    internal class SinhVienController : Controller<SinhVienModel>
    {
        public SinhVienController(Database database, string tableName = "SinhVien") 
            : base(database, tableName)
        {}
        public override List<SinhVienModel> Select()
        {
            string sql = $"select * from @TABLENAME";
            SqlCommand cmd = _db.connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@TABLENAME", _tableName);
            List<SinhVienModel> listSV = new();
            _db.ExecQuery(cmd, (err, reader) =>
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
                        reader.GetDateTime(6),
                        reader.GetString(7)
                        )
                    );
                    listSV = new(sinhVienEnumerable);
                }
            });
            return listSV;
        }
        public override void Insert(SinhVienModel sinhvienModel)
        {
            string sql = @$"insert into 
            {_tableName}
            (MASV, HOSV, TENSV, 
            DIACHI, NOISINH, GIOITINH, 
            NGAYSINH, MANGANH) VALUES 
             (   @MASV,@HOSV,
                @TENSV,@DIACHI,
                @NOISINH,@GIOITINH,
                @NGAYSINH,@MANGANH)";
            var cmd = CommandMaker(sql, sinhvienModel);
            _db.ExecQuery(cmd, (err, _) =>
            {
                if (err is not null)
                {
                    Program.ShowError(err, "Loi khi Insert SinhVien");
                }
            });
        }
        public override void Update(SinhVienModel sinhvienModel)
        {
            string sql = @$"update {_tableName} set
                MASV = @MASV,
                HOSV = @HOSV,
                TENSV = @TENSV,
                DIACHI = @DIACHI,
                NOISINH = @NOISINH,
                GIOITINH = @GIOITINH,
                NGAYSINH = @NGAYSINH,
                MANGANH = @MANGANH
                where MASV = @MASV
                ";
            var cmd = CommandMaker(sql, sinhvienModel);
            _db.ExecQuery(cmd, (err, _) =>
            {
                if (err is not null)
                {
                    Program.ShowError(err, "Loi khi Update SinhVien");
                }
            });
        }
        public override void Delete(SinhVienModel sinhvienModel)
        {
            string sql = @$"delete from {_tableName} where MASV = @MASV";
            var cmd = CommandMaker(sql, sinhvienModel);
            _db.ExecQuery(cmd, (err, _) =>
            {
                if (err is not null)
                {
                    Program.ShowError(err, "Loi khi Delete SinhVien");
                }
            });
        }
        private SqlCommand CommandMaker(string query, SinhVienModel sinhvienModel)
        {
            SqlCommand cmd = _db.connection.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.Add("@MASV", System.Data.SqlDbType.VarChar, 10).Value = sinhvienModel.maSV;
            cmd.Parameters.Add("@HOSV", System.Data.SqlDbType.NVarChar, 20).Value = sinhvienModel.hoSV;
            cmd.Parameters.Add("@TENSV", System.Data.SqlDbType.NVarChar, 20).Value = sinhvienModel.tenSV;
            cmd.Parameters.Add("@DIACHI", System.Data.SqlDbType.NVarChar, 20).Value = sinhvienModel.diaChi;
            cmd.Parameters.Add("@NOISINH", System.Data.SqlDbType.NVarChar, 20).Value = sinhvienModel.noiSinh;
            cmd.Parameters.Add("@GIOITINH", System.Data.SqlDbType.TinyInt).Value = sinhvienModel.gioiTinh;
            cmd.Parameters.Add("@NGAYSINH", System.Data.SqlDbType.Date).Value = sinhvienModel.ngaySinh;
            cmd.Parameters.Add("@MANGANH", System.Data.SqlDbType.Int).Value = sinhvienModel.maNganh;
            return cmd;
        }
    }
}
