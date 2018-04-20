namespace ControleProblemasView
{
    partial class FrmTipo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblsdfs = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgTipo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(23, 66);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(180, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblsdfs
            // 
            this.lblsdfs.AutoSize = true;
            this.lblsdfs.Location = new System.Drawing.Point(23, 50);
            this.lblsdfs.Name = "lblsdfs";
            this.lblsdfs.Size = new System.Drawing.Size(55, 13);
            this.lblsdfs.TabIndex = 4;
            this.lblsdfs.Text = "Descrição";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(128, 102);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // dgTipo
            // 
            this.dgTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTipo.Location = new System.Drawing.Point(23, 146);
            this.dgTipo.Name = "dgTipo";
            this.dgTipo.Size = new System.Drawing.Size(381, 150);
            this.dgTipo.TabIndex = 6;
            // 
            // FrmTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 319);
            this.Controls.Add(this.dgTipo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblsdfs);
            this.Controls.Add(this.txtDescricao);
            this.Name = "FrmTipo";
            this.Text = "Tipo";
            this.Load += new System.EventHandler(this.FrmTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblsdfs;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgTipo;
    }
}

