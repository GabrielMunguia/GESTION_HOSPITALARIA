using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIGAR.GUI.Confirmaciones
{
    public partial class ModalConfirmar : Form
    {

       public  Boolean seConfirmo = false;

        public ModalConfirmar()
        {
            InitializeComponent();
  
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.seConfirmo = true;
           
            Close();
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Modal_Load(object sender, EventArgs e)
        {

        }
    }
}
