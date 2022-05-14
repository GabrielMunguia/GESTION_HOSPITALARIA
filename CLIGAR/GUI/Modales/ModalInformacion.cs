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
    public partial class ModalInformacion : Form
    {
        public ModalInformacion()
        {
            InitializeComponent();
            this.titulo.Left = (this.ClientSize.Width - this.titulo.Size.Width) / 2;
        }

        public ModalInformacion(bool error)
        {
            InitializeComponent();
            if (error)
            {
                this.panelTitulo.BackColor = Color.Red;
                this.button2.BackColor = Color.Red;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
