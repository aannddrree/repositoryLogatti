namespace ControleProblemasView
{
    partial class FrmProblema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdtcriacao = new System.Windows.Forms.TextBox();
            this.cbonivel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(34, 29);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(185, 20);
            this.txtdescricao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Criação:";
            // 
            // txtdtcriacao
            // 
            this.txtdtcriacao.Location = new System.Drawing.Point(34, 79);
            this.txtdtcriacao.Name = "txtdtcriacao";
            this.txtdtcriacao.Size = new System.Drawing.Size(185, 20);
            this.txtdtcriacao.TabIndex = 2;
            // 
            // cbonivel
            // 
            this.cbonivel.FormattingEnabled = true;
            this.cbonivel.Location = new System.Drawing.Point(34, 125);
            this.cbonivel.Name = "cbonivel";
            this.cbonivel.Size = new System.Drawing.Size(185, 21);
            this.cbonivel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nível de Dificuldade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo:";
            // 
            // cbotipo
            // 
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(34, 171);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(185, 21);
            this.cbotipo.TabIndex = 6;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(144, 211);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 8;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // FrmProblema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 255);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbonivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdtcriacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescricao);
            this.Name = "FrmProblema";
            this.Text = "Cadastro de Prolemas";
            this.Load += new System.EventHandler(this.FrmProblema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdtcriacao;
        private System.Windows.Forms.ComboBox cbonivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.Button btnsalvar;
    }
}