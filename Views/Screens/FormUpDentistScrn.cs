using System;
using System.Windows.Forms;
using ScrnLibs;

namespace Screens
{
    public class FormUpDentistScrn : Form
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
        Label Registro;
        Label Salario;
        Label EspecialidadeId;
        TextBox txtIdPaciente;
        TextBox txtNome;
        TextBox txtCPF;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtRegistro;
        TextBox txtSalario;
        TextBox txtEspecialidadeId;
        ListView listView;

        public FormUpDentistScrn()
        {
            this.lblUser = new Fields.LabelFieldTam("Atualziar Dentista", 200, 15, 150, 30);

            this.IdPaciente = new Fields.LabelFieldTam("Id do Dentista:", 50, 40, 150, 30);
            this.txtIdPaciente = new Fields.TextBoxField(50, 70, 180, 20);

            this.Nome = new Fields.LabelField("Nome:", 50, 100);
            this.txtNome = new Fields.TextBoxField(50, 130, 180, 20);

            this.CPF = new Fields.LabelFieldTam("CPF:", 50, 160, 150, 30);
            this.txtCPF = new Fields.TextBoxField(50, 190, 180, 20);

            this.Telefone = new Fields.LabelFieldTam("Telefone:", 50, 220, 150, 30);
            this.txtTelefone = new Fields.TextBoxField(50, 250, 180, 20);

            this.Email = new Fields.LabelFieldTam("Email:", 50, 280, 150, 30);
            this.txtEmail = new Fields.TextBoxField(50, 310, 180, 20);

            this.Registro = new Fields.LabelFieldTam("Registro:", 250, 100, 150, 30);
            this.txtRegistro = new Fields.TextBoxField(250, 130, 180, 20);

            this.Salario = new Fields.LabelFieldTam("Salario:", 250, 160, 150, 30);
            this.txtSalario = new Fields.TextBoxField(250, 190, 180, 20);

            this.EspecialidadeId = new Fields.LabelFieldTam("Especialidade Id:", 250, 220, 150, 30);
            this.txtEspecialidadeId = new Fields.TextBoxField(250, 250, 180, 20);

            this.Senha = new Fields.LabelFieldTam("Senha:", 250, 280, 150, 30);
            this.txtSenha = new Fields.TextBoxField(250, 310, 180, 20);

            listView = new Fields.FieldListView(50, 350, 380, 80);
			listView.View = View.Details;
			ListViewItem EspecialidadeUm = new ListViewItem("1");
			EspecialidadeUm.SubItems.Add("Limpar sala e dente do paciente");
			EspecialidadeUm.SubItems.Add("Limpar sala");
			listView.Items.AddRange(new ListViewItem[]{EspecialidadeUm});
			listView.Columns.Add("Id", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Tarefas", -2, HorizontalAlignment.Left);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;

            btnVoltar = new Fields.ButtonField("Voltar", 50, 450, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Fields.ButtonField("Salvar", 330, 450, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.IdPaciente);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.EspecialidadeId);
            this.Controls.Add(this.txtEspecialidadeId);
            this.Controls.Add(this.listView);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Atualizar Dentista";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnSalvarClick(object sender, EventArgs e)
        {
            String Message = "Dentista atualizado com sucesso!";
            String Title = "Operação feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }
}