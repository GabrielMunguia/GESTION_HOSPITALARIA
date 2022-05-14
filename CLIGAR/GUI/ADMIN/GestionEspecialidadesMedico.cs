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

namespace CLIGAR.GUI.ADMIN
{
    public partial class GestionEspecialidadesMedico : Form

    {
        private int  idMedico = 0;
        private Especialidades_Medico em = new Especialidades_Medico();
        public GestionEspecialidadesMedico()
        {
            InitializeComponent();
           


        }

        private void GestionEspecialidadesMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void dgvEspecialidadesDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreColumna = dgvEspecialidadesDoctor.Columns[e.ColumnIndex].Name;



            if (nombreColumna == "Eliminar")
            {
                ModalConfirmar pm = new ModalConfirmar();
                pm.ShowDialog();


                if (pm.seConfirmo)
                {
                    int indexColumna = dgvEspecialidadesDoctor.CurrentRow.Index;
                    var idEspecialidad = Int32.Parse(dgvEspecialidadesDoctor[1, indexColumna].Value.ToString());
                    Boolean seElimino = this.em.EliminarEspecialidadMedico(this.idMedico, idEspecialidad);
                    DataTable especialidadesMedico = em.obtenerEspecialidadesMedico(this.idMedico);

                    ModalInformacion mf = new ModalInformacion();
                    mf.titulo.Text = "Se elimino el registro con exito";
                    mf.ShowDialog();
             
                    this.dgvEspecialidadesDoctor.DataSource = especialidadesMedico;

                }






            }
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarDoctor_Click(object sender, EventArgs e)
        {
            IdMedicoModal idMedicoModal = new IdMedicoModal();

            idMedicoModal.ShowDialog();
            if (idMedicoModal.seSelecciono)
            {
              
                int id = idMedicoModal.IdMedico;
                this.idMedico = id;
               
                this.lblDoctor.Text = "Doctor : " + idMedicoModal.nombreMedico;
                DataTable especialidadesMedico = em.obtenerEspecialidadesMedico(id);
                this.dgvEspecialidadesDoctor.DataSource = especialidadesMedico;
             

            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.idMedico == 0)
                {
                    bool error = true;
                    ModalInformacion modalInformacion = new ModalInformacion(error);
                    modalInformacion.titulo.Text = "SELECCIONE UN MEDICO";

                    modalInformacion.ShowDialog();
                    return;
                }

                AgregarEspecialidadDoctorModal aggEspecialidad = new AgregarEspecialidadDoctorModal(this.idMedico);
                aggEspecialidad.ShowDialog();
                DataTable especialidadesMedico = em.obtenerEspecialidadesMedico(this.idMedico);
                this.dgvEspecialidadesDoctor.DataSource = especialidadesMedico;
            }
            catch (Exception)
            {
                

               
            }


        }
    }
}
