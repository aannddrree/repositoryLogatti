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
    public partial class FrmTipo : Form
    {
        public FrmTipo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Tipo tipo = new Tipo();
            tipo.Id = Convert.ToInt32(txtId.Text);
            tipo.Descricao = txtDescricao.Text;

            //MessageBox.Show("Olá turma!" + tipo);

            if (new TipoDB().insert(tipo))
            {
                MessageBox.Show("Registro inserido!");
            }
            else
            {
                MessageBox.Show("Erro ao inserir registro!");
            }

        }

        private void FrmTipo_Load(object sender, EventArgs e)
        {
            dgTipo.DataSource = new TipoDB().ListarTipo();
        }
    }
}
