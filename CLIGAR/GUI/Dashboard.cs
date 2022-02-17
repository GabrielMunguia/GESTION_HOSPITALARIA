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
    public partial class Dashboard : Form
    {

        private Form formularioActivo = null;

        public Dashboard()
        {
            InitializeComponent();
           this.estilos();
          
        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

             public void estilos()
        {
            panelBtn1SubMenu.Visible = false;
            panelBtn2SubMenu.Visible = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.panelBtn1SubMenu.Visible= !this.panelBtn1SubMenu.Visible;
        }

        private void ocultarMenus()
        {
            this.panelBtn1SubMenu.Visible = false;
            this.panelBtn2SubMenu.Visible = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.panelBtn2SubMenu.Visible = !this.panelBtn2SubMenu.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ocultarMenus();
            this.abrirFormulario(new ventana1());
        }



        private void btn_MouseHover(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            

       
                boton.BackColor = Color.FromArgb(47, 51, 56);
            boton.ForeColor = Color.FromArgb(15, 151, 241);
        


        }

        private void btn_MouseLeave(object sender,EventArgs e)
        {
            Button boton = sender as Button;
            boton.ForeColor = Color.FromArgb(255, 255, 255);
            boton.BackColor = Color.FromArgb(33, 37, 41);



        
        }

       


       
        private void abrirFormulario(Form childForm)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contenedor.Controls.Add(childForm);
            contenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
