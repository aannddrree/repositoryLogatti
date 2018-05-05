using ProjController;
using ProjModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjWeb1
{
    public partial class Default : System.Web.UI.Page
    {
        string nomeArquivo;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnOK_Click(object sender, EventArgs e)
        {
            LblMSG.Text = "Cliquei no botão - " + TxtDescricao.Text;
            Log(LblMSG.Text);
            //Insere no banco de dados
            InsertBanco(LblMSG.Text);
        }

        public void Log(String msg)
        {
            nomeArquivo = @"C:\Users\andre\Documents\dados.txt";
            // Cria o nome do arquivo com ano, mês, dia, hora minuto e segundo
            string[] msgOld;
            try
            {
                msgOld = System.IO.File.ReadAllLines(nomeArquivo);
            }
            catch (Exception)
            {

                msgOld = null;
            }
            
            // Cria um novo arquivo e devolve um StreamWriter para ele
            StreamWriter writer = new StreamWriter(nomeArquivo);

            // Agora é só sair escrevendo
            if (msgOld == null)
                writer.WriteLine(msg);
            else
            {
                foreach (var item in msgOld)
                {
                    writer.WriteLine(item);
                }
                writer.WriteLine(msg);
            }
                
            // Não esqueça de fechar o arquivo ao terminar
            writer.Close();

        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            ListarLog();
        }

        public void ListarLog()
        {
            nomeArquivo = @"C:\Users\andre\Documents\dados.txt";
            // Cria o nome do arquivo com ano, mês, dia, hora minuto e segundo
            string[] msgOld;
            try
            {
                msgOld = System.IO.File.ReadAllLines(nomeArquivo);
            }
            catch (Exception)
            {

                msgOld = null;
            }

            // Agora é só sair escrevendo
            if (msgOld == null)
                Lista.Text = "Registro não encontrado!";
            else
            {
                string list = "";

                foreach (var item in msgOld)
                {
                    list = list + item + "<br>";
                }
                Lista.Text = list;
            }
        }

        private void InsertBanco(string valor)
        {

            new ControllerMensagem().Insert
                (new Mensagem() { Descricao = valor });

           /* ControllerMensagem c = new ControllerMensagem();
            Mensagem m = new Mensagem();
            m.Descricao = valor;
            c.Insert(m);*/

        }
    }
}