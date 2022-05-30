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
    public partial class VerCitas : Form
    {

        int idMedico;
        Citas citas = new Citas();

        public VerCitas()
        {
            InitializeComponent();
        }

        private void btnSeleccionarDoctor_Click(object sender, EventArgs e)
        {
            IdMedicoModal im = new IdMedicoModal();

            im.ShowDialog();
            if (im.seSelecciono)
            {
                this.idMedico = im.IdMedico;
                this.lblDoctor.Text = "NOMBRE DOCTOR : "+im.nombreMedico;
                citas.IdMedico = this.idMedico;

                string dia = dtpFechaCita.Value.Day.ToString();
                string mes = dtpFechaCita.Value.Month.ToString();
                string anio = dtpFechaCita.Value.Year.ToString();

                DataTable resultado = citas.obtenerCitasAgendadasDetalle(dia,mes,anio);
                this.dgvCitas.DataSource = resultado;


            }
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreColumna = dgvCitas.Columns[e.ColumnIndex].Name;
        



            switch (nombreColumna) {
                case "Detalle":
                    {
                        int indexColumna = dgvCitas.CurrentRow.Index;
                        var idPaciente = Int32.Parse(dgvCitas["CodigoPaciente", indexColumna].Value.ToString());

                        AgregarPaciente f = new AgregarPaciente(idPaciente);
                        f.btnCancelar.Visible = false;
                        f.btnGuardar.Visible = false;



                        f.ShowDialog();
                    }
                    break;
                case "Cancelar":
                    {
                        ModalConfirmar mc = new ModalConfirmar();
                        mc.titulo.Text = "ESTAS SEGURO DE ELIMINAR LA CITA?";
                        mc.ShowDialog();

                        if (mc.seConfirmo)
                        {


                            int indexColumna = dgvCitas.CurrentRow.Index;
                            var idCita = Int32.Parse(dgvCitas["Codigo", indexColumna].Value.ToString());
                            this.citas.IdCita = idCita;
                            ModalInformacion mf = new ModalInformacion();
                            MessageBox.Show(idCita + "");
                            if (this.citas.eliminar(idCita))
                            {
                                mf.titulo.Text = "SE ELIMINO CORRECTAMENTE!";


                            }
                            else
                            {
                                mf.titulo.Text = "NO SE  ELIMINO !";

                            }
                            mf.Show();
                            string dia = dtpFechaCita.Value.Day.ToString();
                            string mes = dtpFechaCita.Value.Month.ToString();
                            string anio = dtpFechaCita.Value.Year.ToString();

                            DataTable resultado = citas.obtenerCitasAgendadasDetalle(dia, mes, anio);
                            this.dgvCitas.DataSource = resultado;
                        }
                    }
                        break;
                case "Editar":
                    {
                        int indexColumna = dgvCitas.CurrentRow.Index;
                        var idPaciente = Int32.Parse(dgvCitas["CodigoPaciente", indexColumna].Value.ToString());
                        var idCita = Int32.Parse(dgvCitas["Codigo", indexColumna].Value.ToString());
                        AgregarCita ac = new AgregarCita(idCita,idPaciente);
                        ac.ShowDialog();
                        if (ac.exitoEdicion) {
                            ModalInformacion mf = new ModalInformacion();
                            mf.titulo.Text = "SE ACTUALIZO CON EXITO";
                            mf.Show();
                            string dia = dtpFechaCita.Value.Day.ToString();
                            string mes = dtpFechaCita.Value.Month.ToString();
                            string anio = dtpFechaCita.Value.Year.ToString();

                            DataTable resultado = citas.obtenerCitasAgendadasDetalle(dia, mes, anio);
                            this.dgvCitas.DataSource = resultado;
                        }

                    } break;
                default:
                    {
                        Clipboard.SetText(nombreColumna);
                    }
                    break;


            }


        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            if (this.idMedico != 0)
            {
                string dia = dtpFechaCita.Value.Day.ToString();
                string mes = dtpFechaCita.Value.Month.ToString();
                string anio = dtpFechaCita.Value.Year.ToString();

                DataTable resultado = citas.obtenerCitasAgendadasDetalle(dia, mes, anio);
                this.dgvCitas.DataSource = resultado;
            }
        }
    }
}
