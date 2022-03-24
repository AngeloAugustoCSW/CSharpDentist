using System;
using System.Windows.Forms;
using ScrnLibs;
using Models;
using Controllers;

namespace Screens
{
    public class FormRoomScrn : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnSelect;
        Button btnDelete;
        Button btnUpdate;
        Button btnInsert;
        Button btnVoltar;

        ListView listView;
        public FormRoomScrn()
        {
            this.lblUser = new Fields.LabelFieldTam("Sala", 230, 15, 150, 30);

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
			foreach (Sala i in SalaController.VisualizarSalas())
            {
                ListViewItem item = new ListViewItem(i.Id + "");
                item.SubItems.Add(i.Numero);  
                item.SubItems.Add(i.Equipamentos);
                listView.Items.AddRange(new ListViewItem[]{item});
            }		
			listView.Columns.Add("ID", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Numero", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Equipamentos", -2, HorizontalAlignment.Left);
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
            this.Text = "Sala";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnUpdateClick(object sender, EventArgs e)
        {
            FormUpRoomScrn UpdtRooms = new FormUpRoomScrn();
            UpdtRooms.ShowDialog();
        }
        public void btnInsertClick(object sender, EventArgs e)
        {
            FormInRoomScrn InRoomScrn = new FormInRoomScrn();
            InRoomScrn.ShowDialog();
        }
        public void btnDeleteClick(object sender, EventArgs e)
        {
            string message = "Voce deseja deletar a sala?";
            string caption = "Confirmar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Sala excluida com sucesso!", "Exclusão");
            } 
        }  
    }
}