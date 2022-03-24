using System;
using System.Windows.Forms;
using ScrnLibs;
using Models;
using Controllers;
namespace Screens
{
    public class FormProcedureScrn : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnSelect;
        Button btnDelete;
        Button btnUpdate;
        Button btnInsert;
        Button btnVoltar;

        ListView listView;
        public FormProcedureScrn()
        {
            this.lblUser = new Fields.LabelFieldTam("Procedimento", 190, 15, 150, 30);

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
			foreach (Procedimento i in ProcedimentoControllers.VisualizarProcedimento())
            {
                ListViewItem item = new ListViewItem(i.Id + "");
                item.SubItems.Add(i.Descricao);  
                item.SubItems.Add(i.Preco + "");
                listView.Items.AddRange(new ListViewItem[]{item});
            }		
			listView.Items.AddRange(new ListViewItem[]{});
			listView.Columns.Add("Id", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Preço", -2, HorizontalAlignment.Left);
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
            this.Text = "Procedimento";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  
        public void btnInsertClick(object sender, EventArgs e)
        {
            FormInProcedureScrn InProcedureScrn = new FormInProcedureScrn();
            InProcedureScrn.ShowDialog();
        }

        public void btnUpdateClick(object sender, EventArgs e)
        {
            FormUpProcedureScrn UpProcedureScrn = new FormUpProcedureScrn();
            UpProcedureScrn.ShowDialog();
        }
        public void btnDeleteClick(object sender, EventArgs e)
        {
            string message = "Voce deseja apagar o procedimento?";
            string caption = "Confirmar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Procedimento apagado com sucesso!", "Exclusão");
            }
        }  
    }
}