using System;
using System.Windows.Forms;
using ScrnLibs;

namespace Screens
{
    public class FormUpProcedureScrn : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblUser;
        Button btnVoltar;
        Button btnSalvar;
        Label DescricaoProcedimento;
        TextBox txtDescricaoProcedimento;
        Label PrecoProcedimento;
        TextBox txtPrecoProcedimento;

        Label IdProcedimento;
        TextBox txtIdProcedimento;

        public FormUpProcedureScrn()
        {
            this.lblUser = new Fields.LabelFieldTam("Atualziar Procedimento", 80, 15, 150, 30);

            this.IdProcedimento = new Fields.LabelFieldTam("Id do Procedimento:", 50, 40, 150, 30);
            this.txtIdProcedimento = new Fields.TextBoxField(50, 70, 200, 20);

            this.DescricaoProcedimento = new Fields.LabelField("Descrição:", 50, 100);
            this.txtDescricaoProcedimento = new Fields.TextBoxField(50, 130, 200, 20);

            this.PrecoProcedimento = new Fields.LabelFieldTam("Preço:", 50, 160, 150, 30);
            this.txtPrecoProcedimento = new Fields.TextBoxField(50, 190, 200, 20);

            btnVoltar = new Fields.ButtonField("Voltar", 50, 250, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Fields.ButtonField("Salvar", 150, 250, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.IdProcedimento);
            this.Controls.Add(this.txtIdProcedimento);
            this.Controls.Add(this.DescricaoProcedimento);
            this.Controls.Add(this.txtDescricaoProcedimento);
            this.Controls.Add(this.PrecoProcedimento);
            this.Controls.Add(this.txtPrecoProcedimento);
            this.Controls.Add(this.btnSalvar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Procedimento";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnSalvarClick(object sender, EventArgs e)
        {
            String Message = "Procedimento atualizado com sucesso!";
            String Title = "Operação feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }
}