using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIGAR.GUI
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 4;
            if (panel1.Width >= panel2.Width)
            {
                timer1.Stop();
                DataManager.DBConexion con = new DataManager.DBConexion();
                if (con.Conectar())
                {
                    Login formLog = new Login();
                    this.Hide();
                    formLog.ShowDialog();
                    this.Close();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No se pudo establecer conexion con la base de datos", "Error conexion", MessageBoxButtons.OK);
                    System.Environment.Exit(1);
                }
            } 
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
