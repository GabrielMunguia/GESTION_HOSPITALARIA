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
    public partial class VisorConsultaMensual : Form
    {
        private void cargar()
        {
            try
            {
                ConsultaMensualReporte oReporte = new ConsultaMensualReporte();
                oReporte.SetDataSource(DataSource.Consultas.ReporteConsultaMensual());
                crvVisor.ReportSource = oReporte;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public VisorConsultaMensual()
        {
            InitializeComponent();
            cargar();
        }
    }
}
