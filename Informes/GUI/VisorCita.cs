using Informes.REP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI
{
    public partial class VisorCita : Form
    {

        private void cargar()
        {
            try
            {
                CitasReporte oReporte = new CitasReporte();
                oReporte.SetDataSource(DataSource.Consultas.ReporteCitas());
                crvVisor.ReportSource = oReporte;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public VisorCita()
        {
            InitializeComponent();
            cargar();
        }
    }
}
