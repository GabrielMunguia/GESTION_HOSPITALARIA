using CLIGAR.GUI.Modales;
using CLIGAR.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIGAR.GUI.MEDICO
{
    public partial class RegistrarConsultaView : Form
    {
        SessionManager.Sesion session = SessionManager.Sesion.Instance;
        int idPaciente;
        public RegistrarConsultaView()
        {
            InitializeComponent();
            this.desactivarCampos();


        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSeleccionarPaciente_Click(object sender, EventArgs e)
        {
            IdPacienteModal ipm = new IdPacienteModal();
            ipm.ShowDialog();
            if (ipm.idPaciente > 0)
            {
                this.idPaciente = ipm.idPaciente;
                lblPaciente.Text = "NOMBRE PACIENTE : " + ipm.nombreCompleto;
                this.ActivarCampos();

            }
        }

        private void desactivarCampos()
        {
            txtAltura.Enabled = false;
            txtObservaciones.Enabled = false;
            txtPeso.Enabled = false;
            txtPresion.Enabled = false;
            txtReceta.Enabled = false;
            dtpFecha.Enabled = false;
            btnGuardar.Enabled = false;
        }

        public bool validarCampos()
        {
            bool esValido = false;

            if(txtAltura.Text.Length>0 && txtObservaciones.Text.Length>0 && txtPeso.Text.Length > 0 && txtPresion.Text.Length > 0 && txtReceta.Text.Length > 0)
            {
                esValido = true;
            }
           
            return esValido;

        }

        private void ActivarCampos()
        {
          
                txtAltura.Enabled = true;
                txtObservaciones.Enabled = true;
                txtPeso.Enabled = true;
                txtPresion.Enabled = true;
                txtReceta.Enabled = true;
                dtpFecha.Enabled = true;
                btnGuardar.Enabled = true;
            
        }

        private void reiniciarForm()
        {

            txtAltura.Text = "";
            txtObservaciones.Text = "";
            txtPeso.Text = "";
            txtPresion.Text = "";
            txtReceta.Text = "";

            lblPaciente.Text = "NOMBRE PACIENTE : ";

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

  

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPaciente_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ModalInformacion info = new ModalInformacion();
            bool esValido = this.validarCampos();
            if (!esValido)
            {
              
                info.titulo.Text = "Todos los campos son obligatorios";
                info.ShowDialog();
                return;
            }
            try
            {
                ConsultaMedica consulta = new ConsultaMedica();
                consulta.IdMedico = Int32.Parse(this.session.IdMedico);
                consulta.IdPaciente = this.idPaciente;
                consulta.Observacion = txtObservaciones.Text;
                consulta.Fecha = DateTime.Parse(dtpFecha.Text).ToString("yyyy-MM-dd H:mm:ss") ;
                consulta.Receta = txtReceta.Text;
                consulta.Peso = txtPeso.Text;
                consulta.Presion = txtPresion.Text;
                consulta.Altura = txtAltura.Text;
               bool seGuardo =  consulta.Guardar();
                if (seGuardo)
                {
                    info.titulo.Text = "Se guardo correctamente";
                    info.ShowDialog();
                    reiniciarForm();
                    this.idPaciente = 0;
                    this.desactivarCampos();


                }


            }
            catch (Exception)
            {
                info.titulo.Text = "Ocurrio un error al guardar!";
                info.ShowDialog();

            }

            

        }
    }
}
