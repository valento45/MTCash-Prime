using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using MTBE_u;

namespace MtCash.BusinessEntities
{
    public class LOG
    {
        public static void Insert(string message, string stacktrace, DateTime data)
        {
            SqlCommand cmd = new SqlCommand($"insert into mtcash.u_log (messagem, stacktrace, detalhes, data_ocorreu) values ('{message}', '{stacktrace}', 'detalhes', '{data}');");
            Access.ExecuteNonQuery(cmd);
        }
    }
}
