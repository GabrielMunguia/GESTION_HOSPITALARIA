using CLIGAR.GUI.Confirmaciones;
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

namespace CLIGAR.GUI.Recepcion
{
    public partial class AgregarCita : Form

    {
        IdMedicoModal idm = new IdMedicoModal();
        IdPacienteModal ipm = new IdPacienteModal();
         int IdMedico = 0;
        int IdPaciente = 0;
        string nombrePaciente = "";
        public string nombreMedico = "";
        Medico medico = new Medico();
        Citas cita = new Citas();
        ModalInformacion mf = new ModalInformacion();
        ModalConfirmar mc = new ModalConfirmar();
        public AgregarCita()
        {
            InitializeComponent();


            this.desactivarOpciones();
            this.btnSeleccionarPaciente.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionarDoctor_Click(object sender, EventArgs e)
        {
            this.idm.ShowDialog();
            if (idm.seSelecciono)
            {
                this.IdMedico = idm.IdMedico;
                this.nombreMedico = idm.nombreMedico;
                this.btnSeleccionarPaciente.Enabled = true;
            
                lblDoctor.Text ="NOMBRE DOCTOR : "+ this.nombreMedico;
                this.cita.IdMedico = this.IdMedico;
                medico.IdMedico = this.IdMedico;
                this.obtenerCitasAgendadas();
                this.lblHorarioLunes.Text = "LUNES : ";
                this.lblHorarioMartes.Text = "MARTES : ";
                this.lblHorarioMiercoles.Text = "MIERCOLES : ";
                this.lblHorarioJueves.Text = "JUEVES : ";
                this.lblHorarioViernes.Text = "VIERNES : ";
                this.lblHorarioSabado.Text = "SABADO : ";
                this.lblHorarioDomingo.Text = "DOMINGO : ";
                DataTable horarios = medico.obtenerHorarios();
                this.lblHorarioLunes.ForeColor = Color.Black;
                this.lblHorarioMartes.ForeColor = Color.Black;
                this.lblHorarioMiercoles.ForeColor = Color.Black;
                this.lblHorarioJueves.ForeColor = Color.Black;
                this.lblHorarioViernes.ForeColor = Color.Black;
                this.lblHorarioSabado.ForeColor = Color.Black;
                this.lblHorarioDomingo.ForeColor = Color.Black;
                foreach (DataRow row in horarios.Rows)
                {

                    string dia = row["Dia"].ToString();
                    string hInicio = row["Hora_inicio"].ToString();
                    string hFinal = row["Hora_final"].ToString();

                    DateTime TestTime = DateTime.Parse(hFinal);
                    // Add 30 minutes
                    TestTime = TestTime + TimeSpan.Parse("00:30:00");
                   
                    var x = TestTime.ToString("HH:mm");

                  


                    switch (dia)
                    {
                        case "L":
                            {
                                this.lblHorarioLunes.Text = "LUNES : " + hInicio + " - " +x;
                                this.lblHorarioLunes.ForeColor = Color.Green;
                            }
                            break;
                        case "M":
                            {
                                this.lblHorarioMartes.Text = "MARTES : " + hInicio + " - " + hFinal;
                                this.lblHorarioMartes.ForeColor = Color.Green;
                            }
                            break;
                        case "X":
                            {
                                this.lblHorarioMiercoles.Text = "MIERCOLES : " + hInicio + " - " + hFinal;
                               this.lblHorarioMiercoles.ForeColor = Color.Green;
                            }
                            break;
                        case "J":
                            {
                                this.lblHorarioJueves.Text = "JUEVES : " + hInicio + " - " + hFinal;
                                this.lblHorarioJueves.ForeColor = Color.Green;
                            }
                            break;
                        case "V":
                            {
                                this.lblHorarioViernes.Text = "VIERNES : " + hInicio + " - " + hFinal;
                                this.lblHorarioViernes.ForeColor = Color.Green;
                            }
                            break;
                        case "S":
                            {
                                this.lblHorarioSabado.Text = "SABADO : " + hInicio + " - " + hFinal;
                                this.lblHorarioSabado.ForeColor = Color.Green;
                            }
                            break;
                        case "D":
                            {
                                this.lblHorarioDomingo.Text = "DOMINGO : " + hInicio + " - " + hFinal;
                                this.lblHorarioDomingo.ForeColor = Color.Green;
                            }
                            break;
                    }
                  
                }

            }
        }

        private void btnSeleccionarPaciente_Click(object sender, EventArgs e)
        {
            if (IdMedico != 0)
            {
                ipm.ShowDialog();
                if (ipm.seSelecciono)
                {
                    this.activarOpciones();
                    this.IdPaciente = ipm.idPaciente;
                    this.nombrePaciente = ipm.nombreCompleto;
                    this.lblPaciente.Text = "NOMBRE PACIENTE : "+ this.nombrePaciente;
                }

                


            }else
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                bool esValido = this.validarGuardar();

                if (esValido)
                {

                    mc.titulo.Text = "Estas seguro de registrar esta cita?";
                    mc.btnConfirmar.Text = "CONFIRMAR";
                    mc.ShowDialog();
               
                    if (mc.seConfirmo)
                    {
                        string urgencia = cbxUrgencia.SelectedItem.ToString();
                        string conctacto = txtContacto.Text;
                        string responsable = txtResonsable.Text;

                        cita.IdMedico = this.IdMedico;
                        cita.IdPaciente = this.IdPaciente;
                        cita.Urgencia1 = urgencia;
                        cita.Responsable1 = responsable;
                        cita.ContactoResponsable1 = txtContacto.Text;
                        cita.Fecha1 = DateTime.Parse(dtpFechaCita.Text).ToString("yyyy-MM-dd H:mm:ss");
                        cita.Guardar();
                        this.obtenerCitasAgendadas();
                        this.ReinciarFormulario();

                        mf.titulo.Text = "SE AGREGO CORRECTAMENTE";
                        mf.Show();
                    }

                    Informes.GUI.VisorCita visor = new Informes.GUI.VisorCita();
                    visor.ShowDialog();
                }
            
              
                // cita.Guardar();
            }
            catch (Exception ex )
            {
              
                MessageBox.Show(ex.Message);
            }
            

        }


        private bool validarGuardar() {
            bool esValido = false;

            if(this.IdMedico>0 && this.IdPaciente > 0)
            {
                esValido = true;
              
            }

            return esValido;
        }

        private void  obtenerCitasAgendadas()
        {
            
            string dia = dtpFechaCita.Value.Day.ToString();
            string mes = dtpFechaCita.Value.Month.ToString();
            string anio = dtpFechaCita.Value.Year.ToString();
       
            DataTable citas =  this.cita.obtenerCitasAgendadas(dia,mes,anio);
         
            this.dgvCitas.DataSource = citas;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.Columns[dgvCitas.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {

           
            this.obtenerCitasAgendadas();
        }

        private void ReinciarFormulario()
        {
            txtContacto.Text = "";
            txtResonsable.Text = "";
            cbxUrgencia.SelectedIndex = 1;
            
        }

        private void desactivarOpciones() {
            this.dtpFechaCita.Enabled = false;
            this.txtContacto.Enabled = false;
            this.txtResonsable.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.cbxUrgencia.Enabled = false;
        }


         private void activarOpciones()
        {
            this.dtpFechaCita.Enabled = Enabled;
            this.txtContacto.Enabled = Enabled;
            this.txtResonsable.Enabled = Enabled;
            this.btnGuardar.Enabled = Enabled;
            this.cbxUrgencia.Enabled = Enabled;
        }
    }
}
