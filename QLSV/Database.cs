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

        public void ExecQuery(SqlCommand cmd, Action<Exception?, SqlDataReader?> onData)
        {
            if (connection == null)
            {
                return;
            }
            try
            {
                connection.Open();

                cmd.Connection = connection;

                cmd.Prepare();

                var sqlDataReader = cmd.ExecuteReader();

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

        public void ExecQuery(string query, Action<Exception?, SqlDataReader?> onData)
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

        public static 
            IEnumerable<TResult> ExtractFromReader<TResult>
            (SqlDataReader reader, Func<SqlDataReader, TResult> selector)
        {
            if (reader.IsClosed)
            {
                Program.ShowError
                    (new Exception("Reader is Closed"), "Loi khi doc tu Reader");
            }
            while (!reader.IsClosed && reader.Read())
            {
                TResult instance = selector(reader);
                yield return instance;
            }
        }
    }
}
