using System;
using System.Windows.Forms;
using ScrnLibs;

namespace Screens
{
    public class FormUpSchedulingScrn : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblUser;
        Button btnVoltar;
        Button btnSalvar;
        Label NomePaciente;
        Label NomeDentista;
        Label Sala;
        Label Data;
        Label Email;
        Label DataNascimento;
        Label Senha;
        Label Registro;
        Label Salario;
        Label EspecialidadeId;
        TextBox txtNmPaci;
        TextBox txtNmDent;
        TextBox txtSala;
        TextBox txtData;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtRegistro;
        TextBox txtSalario;
        TextBox txtEspecialidadeId;
        ListView listView;

        public FormUpSchedulingScrn()
        {
            this.lblUser = new Fields.LabelFieldTam("Atualizar Agendamento", 100, 15, 150, 30);

            this.NomePaciente = new Fields.LabelFieldTam("Nome paciente:", 50, 40, 150, 30);
            this.txtNmPaci = new Fields.TextBoxField(50, 70, 180, 20);

            this.NomeDentista = new Fields.LabelField("Nome dentista:", 50, 100);
            this.txtNmDent = new Fields.TextBoxField(50, 130, 180, 20);

            this.Sala = new Fields.LabelFieldTam("Sala nº:", 50, 160, 150, 30);
            this.txtSala = new Fields.TextBoxField(50, 190, 180, 20);

            this.Data = new Fields.LabelFieldTam("Data:", 50, 220, 150, 30);
            this.txtData = new Fields.TextBoxField(50, 250, 180, 20);

            btnVoltar = new Fields.ButtonField("Voltar", 50, 290, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Fields.ButtonField("Salvar", 150, 290, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.NomePaciente);
            this.Controls.Add(this.NomeDentista);
            this.Controls.Add(this.Sala);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txtNmPaci);
            this.Controls.Add(this.txtNmDent);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.txtData);
            
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Text = "Atualizar Agendamento";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnSalvarClick(object sender, EventArgs e)
        {
            String Message = "Agendamento atualizado com sucesso!";
            String Title = "Operação feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }
}