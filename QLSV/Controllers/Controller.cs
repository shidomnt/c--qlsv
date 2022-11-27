using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Controllers
{
    internal abstract class Controller<T>
    {
        protected readonly Database _db;
        protected readonly string _tableName;
        public Controller(Database database, string tableName)
        {
            _tableName = tableName;
            _db = database;
        }
        public abstract List<T> Select();
        public abstract void Insert(T model);
        public abstract void Update(T model);
        public abstract void Delete(T model);
    }
}
