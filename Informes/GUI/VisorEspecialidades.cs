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
    public partial class VisorEspecialidades : Form
    {

        public void cargar() {

            REP.Consultas oReporte = new REP.Consultas();
            oReporte.SetDataSource(DataSource.Consultas.reporteEspecilidades());
            crv.ReportSource = oReporte;
        }

        public VisorEspecialidades()
        {
            InitializeComponent();
            cargar();
        }
    }
}
