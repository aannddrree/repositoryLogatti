using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class DB
    {
        private SqlConnection conexao;

        public DB()
        {
            conexao = new SqlConnection(
                ConfigurationManager.
                ConnectionStrings["ConexaoSQLServer"]
                .ConnectionString);
            conexao.Open();
        }
    }
}
