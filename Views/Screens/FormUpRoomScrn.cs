using System;

using System.Windows.Forms;
using ScrnLibs;

namespace Screens
{
    public class FormUpRoomScrn : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnVoltar;
        Button btnSalvar;
        Label IdSala;
        TextBox txtIdSala;
        Label NumSala;
        TextBox txtNumSala;
        Label EquipSala;
        TextBox txtEquipSala;

        public FormUpRoomScrn()
        {
            this.lblUser = new Fields.LabelFieldTam("Atualizar sala", 120, 15, 150, 30);

            this.IdSala = new Fields.LabelField("Id da sala:", 50, 40);
            this.txtIdSala = new Fields.TextBoxField(50, 70, 200, 20);

            this.NumSala = new Fields.LabelField("Número da sala:", 50, 100);
            this.txtNumSala = new Fields.TextBoxField(50, 130, 200, 20);

            this.EquipSala = new Fields.LabelField("Equipamentos:", 50, 160);
            this.txtEquipSala = new Fields.TextBoxField(50, 190, 200, 20);

            btnVoltar = new Fields.ButtonField("Voltar", 50, 250, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Fields.ButtonField("Salvar", 150, 250, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtIdSala);
            this.Controls.Add(this.txtNumSala);
            this.Controls.Add(this.txtEquipSala);
            this.Controls.Add(this.IdSala);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.NumSala);
            this.Controls.Add(this.EquipSala);
            

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar sala";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  
        public void btnSalvarClick(object sender, EventArgs e)
        {
            String Message = "Sala atualizada com sucesso!";
            String Title = "Operação feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }  

}