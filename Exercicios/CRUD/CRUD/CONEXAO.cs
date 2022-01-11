using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD
{
    class CONEXAO
    {
        public static string stringConexao
        {
            get
            {
                return "server=localhost;port=3306;username=root;password=;database=db_centro";
            }
        }
    }
}
