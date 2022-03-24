using System;
using System.Windows.Forms;
using ScrnLibs;
using Models;
namespace Screens
{
    public class FormPatientMenuScrn : Form
    {   
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnConfirmarConsulta;
       
        Button btnSair;

        ListView listView;
        public FormPatientMenuScrn()
        {
            this.lblUser = new Fields.LabelFieldTam($"Bem vindo {Auth.Paciente.Nome}", 100, 15, 150, 30);

            btnConfirmarConsulta = new Fields.ButtonField("Confirmar", 20, 250, 100, 30);
			btnConfirmarConsulta.Click += new EventHandler(this.btnConfirmarConsultaClick);

            btnSair = new Fields.ButtonField("Sair", 180, 250, 100, 30);
			btnSair.Click += new EventHandler(this.btnSairClick);

            listView = new Fields.FieldListView(20, 50, 250, 170);
			listView.View = View.Details;
			ListViewItem filme1 = new ListViewItem("Kill Bill");
			filme1.SubItems.Add("3");
			filme1.SubItems.Add("2001");
			ListViewItem filme2 = new ListViewItem("Rei Leão");
			filme2.SubItems.Add("2");
			filme2.SubItems.Add("1994");
			ListViewItem filme3 = new ListViewItem("Coringa");
			filme3.SubItems.Add("1");	
			filme3.SubItems.Add("2020");		
			listView.Items.AddRange(new ListViewItem[]{filme1, filme2, filme3});
			listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Estoque", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Ano", -2, HorizontalAlignment.Left);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnConfirmarConsulta);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnSair);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Menu Paciente";
        }

        public void btnConfirmarConsultaClick(object sender, EventArgs e)
        {
            string message = "Voce deseja confirmar o agendamento?";
            string caption = "Confirmar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Agendamento confirmado com sucesso!", "Confirmado");
            } 
        }  

        public void btnSairClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
