using Controle;
using Entidade;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle2
{
    public class TipoDB
    {
        private DB db; 

        public bool insert (Tipo tipo)
        {
            try
            {
                string sql = "INSERT INTO TB_TIPO (DESCRICAO)" +
                         " VALUES ('" + tipo.Descricao + "')";
                using (db = new DB())
                {
                    db.ExecutaComando(sql);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Tipo> ListarTipo()
        {
            using (db = new DB())
            {
                var sql = "SELECT id, descricao FROM TB_TIPO";
                var retorno = db.ExecutaComandoRetorno(sql);
                return TransformaSQLReaderEmList(retorno);
            }
        }

        private List<Tipo> TransformaSQLReaderEmList(SqlDataReader retorno)
        {
            var listTipo = new List<Tipo>();

            while (retorno.Read())
            {
                var item = new Tipo()
                {
                    Id = Convert.ToInt32(retorno["id"]),
                    Descricao = retorno["descricao"].ToString(),
                };

                listTipo.Add(item);
            }
            return listTipo;
        }
    }
}
