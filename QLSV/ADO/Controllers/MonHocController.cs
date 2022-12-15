using QLSV.Models;
using QLSV.ADO;

namespace QLSV.Controllers
{
    internal class MonHocController
    {
        private readonly Database db;
        private readonly string name = "MonHoc";
        public MonHocController(Database database)
        {
            db = database;
        }
        public List<MonHocModel> Select()
        {
            string sql = $"select * from {name}";
            List<MonHocModel> monHoc = new();
            db.ExecQuery(sql, (err, reader) =>
            {
                if (err != null)
                {
                    Program.ShowError(err, "Loi khi Select Monhoc");
                }

                if (reader != null)
                {
                    if (!reader.IsClosed)
                    {
                        var monHocEnumerable =
                            Database.ExtractFromReader<MonHocModel>(
                                reader,
                                reader => new MonHocModel(reader.GetInt32(0), reader.GetString(1))
                             );
                        monHoc = new(monHocEnumerable);
                    }
                }

            });
            return monHoc;
        }

        public void Insert(string tenMon)
        {
            string sql = $"insert into {name}(TENMON) VALUES ('{tenMon}')";
            db.ExecQuery(sql, (err, _) =>
            {
                if (err != null)
                {
                    Program.ShowError(err, "Loi khi Insert MonHoc");
                }
            });
        }

    }
}
