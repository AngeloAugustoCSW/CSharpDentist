using System;
using System.Windows.Forms;
using ScrnLibs;
using Models;

namespace Screens
{
    public class FormDentistMenuScrn : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnDentista;
        Button btnSala;
        Button btnProcedimento;
        Button btnPaciente;
        Button btnAgendamento;
        Button btnEspecialidade;
        Button btnSair;
        public FormDentistMenuScrn()
        {
            this.lblUser = new Fields.LabelFieldTam($"Bem vindo {Auth.Dentista.Nome}!", 100, 15, 150, 30);

            btnDentista = new Fields.ButtonField("Dentistas", 30, 50, 100, 30);
			btnDentista.Click += new EventHandler(this.btnDentistaClick);

            btnSala = new Fields.ButtonField("Sala", 30, 90, 100, 30);
			btnSala.Click += new EventHandler(this.btnSalaClick);

            btnProcedimento = new Fields.ButtonField("Procedimento", 30, 130, 100, 30);
			btnProcedimento.Click += new EventHandler(this.btnProcedimentoClick);

            btnPaciente = new Fields.ButtonField("Paciente", 170, 50, 100, 30);
			btnPaciente.Click += new EventHandler(this.btnPacienteClick);

            btnAgendamento = new Fields.ButtonField("Agendamento", 170, 90, 100, 30);
			btnAgendamento.Click += new EventHandler(this.btnAgendamentoClick);

            btnEspecialidade = new Fields.ButtonField("Especialidade", 170, 130, 100, 30);
			btnEspecialidade.Click += new EventHandler(this.btnEspecialidadeClick);

            btnSair = new Fields.ButtonField("Sair", 100, 240, 100, 30);
			btnSair.Click += new EventHandler(this.btnSairClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.btnSala);
            this.Controls.Add(this.btnProcedimento);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnAgendamento);
            this.Controls.Add(this.btnEspecialidade);
            this.Controls.Add(this.btnSair);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Menu Dentista";
        }

        public void btnSairClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnPacienteClick(object sender, EventArgs e)
        {
            FormPatientListScrn PatientListScrn = new FormPatientListScrn();
            PatientListScrn.ShowDialog();
        }  

        public void btnEspecialidadeClick(object sender, EventArgs e)
        {
            FormSpecialtyScrn SpecialtyScrn = new FormSpecialtyScrn();
            SpecialtyScrn.ShowDialog();
        } 

        public void btnDentistaClick(object sender, EventArgs e)
        {
            FormDentistListScrn DentistListScrn = new FormDentistListScrn();
            DentistListScrn.ShowDialog();
        }

        public void btnSalaClick(object sender, EventArgs e)
        {
            FormRoomScrn RoomScrn = new FormRoomScrn();
            RoomScrn.ShowDialog();
        }

        public void btnProcedimentoClick(object sender, EventArgs e)
        {
            FormProcedureScrn ProcedureScrn = new FormProcedureScrn();
            ProcedureScrn.ShowDialog();
        }

        public void btnAgendamentoClick(object sender, EventArgs e)
        {
            FormSchedulingScrn ScheduleScrn = new FormSchedulingScrn();
            ScheduleScrn.ShowDialog();
        }

    }
}