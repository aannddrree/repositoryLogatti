namespace Entidade
{
    public class Tipo
    {

        #region Propriedades

        public int Id { get; set; }
        public string Descricao { get; set; }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return "Id: " + this.Id +
                "\nDescrição: " + this.Descricao;
        }

        #endregion
    }
}