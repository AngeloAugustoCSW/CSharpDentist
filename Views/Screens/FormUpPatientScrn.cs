using System;
using System.Windows.Forms;
using ScrnLibs;

namespace Screens
{
    public class FormUpPatientScrn : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblUser;
        Button btnVoltar;
        Button btnSalvar;
        Label IdPaciente;
        Label Nome;
        Label CPF;
        Label Telefone;
        Label Email;
        Label DataNascimento;
        Label Senha;
        TextBox txtIdPaciente;
        TextBox txtNome;
        TextBox txtCPF;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtDataNascimento;
        TextBox txtSenha;

        public FormUpPatientScrn()
        {
            this.lblUser = new Fields.LabelFieldTam("Atualziar Paciente", 200, 15, 150, 30);

            this.IdPaciente = new Fields.LabelFieldTam("Id do Paciente:", 50, 40, 150, 30);
            this.txtIdPaciente = new Fields.TextBoxField(50, 70, 180, 20);

            this.Nome = new Fields.LabelField("Nome:", 50, 100);
            this.txtNome = new Fields.TextBoxField(50, 130, 180, 20);

            this.CPF = new Fields.LabelFieldTam("CPF:", 50, 160, 150, 30);
            this.txtCPF = new Fields.TextBoxField(50, 190, 180, 20);

            this.Telefone = new Fields.LabelFieldTam("Telefone:", 50, 220, 150, 30);
            this.txtTelefone = new Fields.TextBoxField(50, 250, 180, 20);

            this.Email = new Fields.LabelFieldTam("Email:", 250, 100, 150, 30);
            this.txtEmail = new Fields.TextBoxField(250, 130, 180, 20);

            this.DataNascimento = new Fields.LabelFieldTam("Data de Nascimento:", 250, 160, 150, 30);
            this.txtDataNascimento = new Fields.TextBoxField(250, 190, 180, 20);

            this.Senha = new Fields.LabelFieldTam("Senha:", 250, 220, 150, 30);
            this.txtSenha = new Fields.TextBoxField(250, 250, 180, 20);

            btnVoltar = new Fields.ButtonField("Voltar", 50, 450, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Fields.ButtonField("Salvar", 350, 450, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.IdPaciente);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtSenha);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Atualizar Paciente";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnSalvarClick(object sender, EventArgs e)
        {
            String Message = "Paciente atualizado com sucesso!";
            String Title = "Opera????o feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }
}