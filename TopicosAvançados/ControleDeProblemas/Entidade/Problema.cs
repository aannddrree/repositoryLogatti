using System;

namespace Entidade
{
    public class Problema
    {

        #region Propriedades

        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public Tipo Tipo { get; set; }
        public Nivel NivelDificuldade { get; set; }

        #endregion Propriedades

        #region Métodos

        public override string ToString()
        {
            return "Id: " + this.Id + 
                 "\nDescrição: " + this.Descricao +
                 "\nTipo: " + this.Tipo.Descricao +
                 "\nNivel: " 
                 + this.NivelDificuldade.Descricao;
        }

        #endregion

    }
}
