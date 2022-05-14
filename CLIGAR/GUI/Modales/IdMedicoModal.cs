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
    public partial class IdMedicoModal : Form
    {
        Medico medico = new Medico();
        public int IdMedico=0;
        public string nombreMedico = "";
        public Boolean seSelecciono = false;

        public IdMedicoModal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            string jvm = this.txtJVM.Text;
            DataTable medico = this.medico.obtenerMedicoPorJVM(jvm);
           
            if (medico.Rows.Count == 0)
            {
                 lblError.Visible = true;

                this.desactivarLbls();
                this.IdMedico = 0;
                return;
            }
            lblError.Visible = false;
            this.txtNombre.Text = medico.Rows[0][3].ToString() +" "+ medico.Rows[0][4].ToString();
       
            this.txtDui.Text = medico.Rows[0][10].ToString();
            this.txtNit.Text = medico.Rows[0][11].ToString();
            this.IdMedico = Int32.Parse(medico.Rows[0][0].ToString());
            this.activarLbls();
            this.nombreMedico = medico.Rows[0][3].ToString() + " " + medico.Rows[0][4].ToString();
       


        }

        private void activarLbls()
        {
            this.lblNombre.Visible = true;
            this.lblNIT.Visible = true;
            this.lblDUI.Visible = true;
            this.txtDui.Visible = true;
            this.txtNombre.Visible = true;
            this.txtNit.Visible = true;
        }

        private void desactivarLbls()
        {
            this.lblNombre.Visible = false;
            this.lblNIT.Visible = false;
            this.lblDUI.Visible = false;
            this.txtDui.Visible = false;
            this.txtNombre.Visible = false;
         
            this.txtNit.Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (IdMedico != 0)
            {
                this.seSelecciono = true;
                Close();
            }
        }
    }
}
