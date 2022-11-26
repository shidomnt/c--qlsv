using Microsoft.Data.SqlClient;
using System.Configuration;

namespace QLSV
{
    internal class Database
    {
        public readonly SqlConnection connection = new(
            ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString
        );
        private static Database? _instance = null;
        private Database()
        {
        }

        public static Database GetDB()
        {
            _instance ??= new Database();
            return _instance;
        }

        public delegate void OnData(Exception? err, SqlDataReader? reader);

        public void ExecQuery(string query, OnData onData)
        {
            if (connection == null)
            {
                return;
            }
            try
            {
                connection.Open();

                var command = connection.CreateCommand();

                command.CommandText = query;

                var sqlDataReader = command.ExecuteReader();

                onData(null, sqlDataReader);
            }
            catch (Exception ex)
            {
                onData(ex, null);
            }
            finally
            {
                connection.Close();
            }
        }

        public delegate T ReaderSelector<T>(SqlDataReader reader);

        public static IEnumerable<T> 
            ExtractFromReader<T>(SqlDataReader reader, ReaderSelector<T> selector)
        {
            if (reader.IsClosed)
            {
                Program.ShowError(new Exception("Reader is Closed"), "Loi khi doc tu Reader");
            }
            while (!reader.IsClosed && reader.Read())
            {
                T instance = selector(reader);
                yield return instance;
            }
        }
    }
}
