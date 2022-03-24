using System;
using System.Drawing;
using System.Windows.Forms;
using Models;

namespace Screens
{
    public class FormLoginScrn : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Label lblPassword;
        TextBox txtUser;
        TextBox txtPass;

        Button btnConfirmar;
        Button btnCancelar;
        public FormLoginScrn()
        {
            this.lblUser = new LabelField("Usuário", 120, 30);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(60, 60);
            this.txtUser.Size = new Size(180, 20);


            this.lblPassword = new Label();
            this.lblPassword.Text = "Senha";
            this.lblPassword.Location = new Point(120, 100);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(60, 130);
            this.txtPass.Size = new Size(180, 20);
            //this.txtPass.PasswordChar = "*";

            btnConfirmar = new Button();
			btnConfirmar.Text = "Confirmar";
			btnConfirmar.Size = new Size(75,30);
			btnConfirmar.Location = new Point(70, 180);
			btnConfirmar.Click += new EventHandler(this.btnLoginClick);

			btnCancelar = new Button();
			btnCancelar.Text = "Cancelar";
			btnCancelar.Size = new Size(75,30);
			btnCancelar.Location = new Point(150, 180);
			btnCancelar.Click += new EventHandler(this.btnQuitClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Text = "Area Login";
        }

        public void btnLoginClick(object sender, EventArgs e)
        {              
            try
            {
                Auth.Login(this.txtUser.Text, this.txtPass.Text);
                if (Auth.Dentista != null) 
                {
                    FormDentistMenuScrn DentistMainMenu = new FormDentistMenuScrn();
                    DentistMainMenu.ShowDialog();
                }
                if (Auth.Paciente != null) 
                {
                    FormPatientMenuScrn MenuPacienteTelas = new FormPatientMenuScrn();
                    MenuPacienteTelas.ShowDialog();
                }
                Auth.Logout();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void btnQuitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        public class LabelField : Label
        {
            public LabelField(string Text, int x, int y)
            {
                this.Text = Text;
                this.Location = new Point(x, y);
            }
        }

    }
}
