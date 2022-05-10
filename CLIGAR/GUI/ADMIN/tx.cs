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
    public partial class tx : Form
    {
        private Form formularioActivo = null;
        public tx()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new ListaEmpleados());
        }

        private void abrirFormulario(Form childForm)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = childForm;
           
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(childForm);
            panelHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

          

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
