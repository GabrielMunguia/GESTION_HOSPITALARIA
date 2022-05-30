using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informes.GUI
{
    public partial class VisorConsultasMedicos : Form
    {



        private void cargar()
        {
            try
            {
                DateTime fechaActual = DateTime.Today;
                DateTimeFormatInfo mfi = new DateTimeFormatInfo();
                string sMonth = DateTime.Now.ToString("MM");
                int mes = Int32.Parse(sMonth);
                int anio = fechaActual.Year;
                REP.Especialidades oReporte = new REP.Especialidades();
                oReporte.SetDataSource(DataSource.Consultas.reportConsultasMedicos(anio,mes));
                crvConsultas.ReportSource = oReporte;

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public VisorConsultasMedicos()
        {
            InitializeComponent();
            cargar();
        }
    }
}
