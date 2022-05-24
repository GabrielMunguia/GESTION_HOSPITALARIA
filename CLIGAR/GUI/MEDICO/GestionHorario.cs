using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;
using CLIGAR.Modelos;
using CLIGAR.GUI.Modales;

namespace CLIGAR.GUI.ADMIN
{
    public partial class GestionHorario : Form
    {
        private int idMedico = 0;
        private Horario hor = new Horario();
        DataTable actualizar;
        public GestionHorario()
        {
            InitializeComponent();               
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void GestionUsuario_Load(object sender, EventArgs e)
        {
            //ActualizarTabla();           
        }

        private void ActualizarTabla()
        {            
            this.tablaHorario.DataSource = actualizar;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Inicio.Enabled = true;
                Final.Enabled = true;             
                Inicio.Text = tablaHorario.CurrentRow.Cells["Hora_inicio"].Value.ToString();
                Final.Text = tablaHorario.CurrentRow.Cells["Hora_final"].Value.ToString();
                txtDia.Text = tablaHorario.CurrentRow.Cells["Dia"].Value.ToString();
                btnConfirmar.Visible = true;
                
                
            }
            catch { }
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Horario horario = new Horario();

                    horario.Inicio = Inicio.Value.ToString("HH:mm");
                    horario.Final = Final.Value.ToString("HH:mm");
                    horario.Dia = txtDia.Text;                    
                    horario.IdMedico = idMedico.ToString();
                    horario.Actualizar();
                    actualizar = hor.obtenerHorariosMedico(idMedico);
                    this.tablaHorario.DataSource = actualizar;
                }
                
                btnConfirmar.Visible = false;
                Inicio.Enabled = false;
                Final.Enabled = false;
            }
            catch
            {

            }
        }


        private void btnSeleccionarDoctor_Click_1(object sender, EventArgs e)
        {
            try {
                IdMedicoModal idMedicoModal = new IdMedicoModal();

                idMedicoModal.ShowDialog();
                if (idMedicoModal.seSelecciono)
                {                    
                    this.idMedico = idMedicoModal.IdMedico;
                    this.labelDoctor.Text = "Doctor: " + idMedicoModal.nombreMedico;
                    actualizar = hor.obtenerHorariosMedico(idMedico);
                    this.tablaHorario.DataSource = actualizar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
