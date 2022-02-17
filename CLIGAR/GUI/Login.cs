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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(33, 37, 41);
            
            btnLogin.BackColor = Color.FromArgb(13, 110, 253);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
           
        {
            this.btnLogin.Text = "Cargando..";
            
            Dashboard dash = new Dashboard();
            this.Hide();
            dash.ShowDialog();
            this.Close();


        }

        private void inputCorreo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
