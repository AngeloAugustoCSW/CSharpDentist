using System;
using System.Windows.Forms;
using ScrnLibs;
using Models;
using Controllers;
namespace Screens
{
    public class FormSchedulingScrn : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnSelect;
        Button btnDelete;
        Button btnUpdate;
        Button btnInsert;
        Button btnVoltar;

        ListView listView;
        public FormSchedulingScrn()
        {
            this.lblUser = new Fields.LabelFieldTam("Agendamento", 230, 15, 150, 30);

            btnVoltar = new Fields.ButtonField("Voltar", 50, 400, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnDelete = new Fields.ButtonField("Deletar", 150, 400, 100, 30);
			btnDelete.Click += new EventHandler(this.btnDeleteClick);

            btnUpdate = new Fields.ButtonField("Atualizar", 250, 400, 100, 30);
			btnUpdate.Click += new EventHandler(this.btnUpdateClick);

            btnInsert = new Fields.ButtonField("Inserir", 350, 400, 100, 30);
			btnInsert.Click += new EventHandler(this.btnInsertClick);

            listView = new Fields.FieldListView(50, 50, 400, 320);
			listView.View = View.Details;
			foreach (Agendamento i in AgendamentoController.VisualizarAgendamentos())
            {
                ListViewItem item = new ListViewItem(i.Id + "");
                item.SubItems.Add(i.Paciente.Nome);  
                item.SubItems.Add(i.Dentista.Nome);
                item.SubItems.Add(i.Sala.Numero);
                item.SubItems.Add(i.Data +"");
                item.SubItems.Add(i.Confirmado +"");
                listView.Items.AddRange(new ListViewItem[]{item});
            }
			listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Paciente", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Dentista", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Sala", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Confirmado", -2, HorizontalAlignment.Left);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listView);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Agendamento";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnInsertClick(object sender, EventArgs e)
        {
            FormInSchedulingScrn InSchedulingScrn = new FormInSchedulingScrn();
            InSchedulingScrn.ShowDialog();
        }
        public void btnUpdateClick(object sender, EventArgs e)
        {
            FormUpSchedulingScrn UpSchedulingScrn = new FormUpSchedulingScrn();
            UpSchedulingScrn.ShowDialog();
        }
        public void btnDeleteClick(object sender, EventArgs e)
        {
            string message = "Voce deseja deletar a especialidade?";
            string caption = "Confirmar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Agendamento removido!","Exclusão");
            } 
        }  
    }
}