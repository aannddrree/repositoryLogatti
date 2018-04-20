using Controle2;
using Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleProblemasView
{
    public partial class FrmProblema : Form
    {
        public FrmProblema()
        {
            InitializeComponent();
        }

        private void FrmProblema_Load(object sender, EventArgs e)
        {
            CarregaComboTipo();
            //Falta carregar o combo Nivel
        }

        private void CarregaComboTipo()
        {
            cbotipo.DataSource = new TipoDB().ListarTipo();
            cbotipo.DisplayMember = "descricao";
            cbotipo.ValueMember = "id";
        }

        //Falta implementar o CarrageComboNivel

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbotipo.SelectedValue.ToString());
            MessageBox.Show("Id: "+ id);
            string descricao = txtdescricao.Text;
            //Receber as demais informações

            Problema problema = new Problema()
            {
                Descricao = descricao,
                Tipo = new Tipo() {Id = id},
                //Complementar
            };

            if (new ProblemaDB().Insert(problema))
            {
                MessageBox.Show("Registro inserido!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir registro");
            }


        }
    }
}
