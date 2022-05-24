using CLIGAR.GUI.Confirmaciones;
using CLIGAR.GUI.Modales;
using CLIGAR.Modelos;
using System;
using System.Data;
using System.Windows.Forms;

namespace CLIGAR.GUI.MEDICO
{
    public partial class HistorialConsultas : Form
    {
        ConsultaMedica consulta = new ConsultaMedica();
        int idPaciente = 0;
        string nomPaciente;
        public HistorialConsultas()
        {
            InitializeComponent();
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
                this.lblPaciente.Text = "NOMBRE PACIENTE : " + ipm.nombreCompleto;
                this.nomPaciente = ipm.nombreCompleto;
                DataTable historial = consulta.obtenerHistorialConsultas(ipm.idPaciente);

                this.dgv.DataSource = historial;


            }


        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreColumna = dgv.Columns[e.ColumnIndex].Name;



            if (nombreColumna == "Detalles")
            {
                ModalConfirmar pm = new ModalConfirmar();
                pm.titulo.Text = "Confirma si quieres ver el detalle";
                pm.btnConfirmar.Text = "VER DETALLE";
               
                pm.ShowDialog();


                if (pm.seConfirmo)
                {
                    int indexColumna = dgv.CurrentRow.Index;
                    var idConsulta = Int32.Parse(dgv[1, indexColumna].Value.ToString());
                    RegistrarConsultaView rc = new RegistrarConsultaView(idConsulta,nomPaciente);
                        rc.ShowDialog();
                   

                }






            }
        }
    }
}
