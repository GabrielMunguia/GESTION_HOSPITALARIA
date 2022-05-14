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

namespace CLIGAR.GUI.Modales
{
    public partial class AgregarEspecialidadDoctorModal : Form
    {
        private int idMedico;


        public AgregarEspecialidadDoctorModal(int id)
        {
            InitializeComponent();
            this.idMedico = id;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        

            try
            {


                ModalInformacion infoModal = new ModalInformacion();
                DataRowView dv = (DataRowView)cbxEspecialidades.SelectedItem;
                int idEspecialidad = Int32.Parse(dv.Row["idEspecialidad"].ToString());
                Especialidades_Medico especialidadMedico = new Especialidades_Medico();
                especialidadMedico.IdEspecialidad = idEspecialidad;
                especialidadMedico.IdMedico = this.idMedico;


                bool seGuardo = especialidadMedico.Guardar();
                if (seGuardo)
                {
                   
                    Close();

                }
                else
                {
                    infoModal.titulo.Text = "OCURRIO UN ERROR AL GUARDAR";
                    infoModal.panelTitulo.BackColor = Color.Red;
                    infoModal.button2.BackColor= Color.Red; 
                    infoModal.ShowDialog();
                }

            }
            catch (Exception)
            {

                Close();
            }

    

        }

        private void AgregarEspecialidadDoctor_Load(object sender, EventArgs e)
        {
            Especialidades ep = new Especialidades();
            DataTable lst = ep.obtenerEspecialidadesDisponiblesMedico(this.idMedico);
            if (lst.Rows.Count < 1)
            {
                this.btnAgregar.Enabled = false;
                this.cbxEspecialidades.Enabled = false;

                return;
            }
        
            cbxEspecialidades.DisplayMember = "Nombre";
            cbxEspecialidades.ValueMember = "idEspecialidad";
            cbxEspecialidades.DataSource = lst;


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
