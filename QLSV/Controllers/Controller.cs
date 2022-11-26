using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Controllers
{
    internal abstract class Controller
    {
        protected readonly Database _db;
        protected string _tableName = string.Empty;
        public Controller(Database database)
        {
            _db = database;
        }
    }
}
