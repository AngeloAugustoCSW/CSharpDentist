using System;
using System.Windows.Forms;
using ScrnLibs;
using Models;
using Controllers;
namespace Screens
{
    public class FormSpecialtyScrn : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnDelete;
        Button btnUpdate;
        Button btnInsert;
        Button btnVoltar;

        ListView listView;
        public FormSpecialtyScrn()
        {
            this.lblUser = new Fields.LabelFieldTam("Especialidade", 230, 15, 150, 30);

            btnVoltar = new Fields.ButtonField("Voltar", 50, 400, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnDelete = new Fields.ButtonField("Deletar", 150, 400, 100, 30);
			btnDelete.Click += new EventHandler(this.btnDeleteClick);

            btnUpdate = new Fields.ButtonField("Atualizar", 250, 400, 100, 30);
			btnUpdate.Click += new EventHandler(this.btnUpdateClick);

            btnInsert = new Fields.ButtonField("Inserir", 350, 400, 100, 30);
			btnUpdate.Click += new EventHandler(this.btnInsertClick);

            listView = new Fields.FieldListView(50, 50, 400, 320);
			listView.View = View.Details;
			foreach (Especialidade i in EspecialidadeController.SelectEspecialidade())
            {
                ListViewItem item = new ListViewItem(i.Id + "");
                item.SubItems.Add(i.Descricao);  
                item.SubItems.Add(i.Tarefas);
                listView.Items.AddRange(new ListViewItem[]{item});
            }
			listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Tarefa", -2, HorizontalAlignment.Left);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;


            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listView);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Especialidade";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnUpdateClick(object sender, EventArgs e)
        {
            FormUpSpecialtyScrn UpSpecialtyScrn = new FormUpSpecialtyScrn();
            UpSpecialtyScrn.ShowDialog();
        }

        public void btnInsertClick(object sender, EventArgs e)
        {
            FormInSpecialtyScrn InSpecialtyScrn = new FormInSpecialtyScrn();
            InSpecialtyScrn.ShowDialog();
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
                MessageBox.Show("Especialidade excluida com sucesso!", "Exclusão");
            } 
        }  
    }
}