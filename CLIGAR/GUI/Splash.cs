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
                Login formLog = new Login();
                this.Hide();
                formLog.ShowDialog();
                this.Close();

            } 
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
