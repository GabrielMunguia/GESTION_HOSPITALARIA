using CLIGAR.GUI.ADMIN;
using CLIGAR.GUI.MEDICO;
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
        SessionManager.Sesion session = SessionManager.Sesion.Instance;

        private Form formularioActivo = null;

        public Dashboard()
        {
            InitializeComponent();
            this.ocultarMenus();

        }

        public void ocultarMenus()
        {
            this.panelOpcConsultaMedica.Visible = false;
            this.panelOpcGestionPacientes.Visible = false;
            panelOpcConsultaMedica.Visible = false;
            panelOpcGestionPacientes.Visible = false;
            panelOpcGestionDeUsuarios.Visible = false;
            panelOpcGestionDeEmpleados.Visible = false;
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

      

        private void Dashboard_Load(object sender, EventArgs e)
        {

          

            //valido las opciones que tendra el menu segun el cargo
            this.validarPermisos();
            this.lblUsuarioOnline.Text = (session.Nombres + " " + session.Apellidos).ToUpper();
            switch (session.Cargo)
            {
                case "1": lblTipoUsuario.Text = "ADMINISTRADOR"; break;
                case "2": lblTipoUsuario.Text = "DOCTOR"; break;
                case "3": lblTipoUsuario.Text = "RECEPCIONISTA"; break;
                default:
                    break;
            }

        }

    

      


        //Esta funcion habilita  las opciones del menu segun el cargo del usuario
        public void validarPermisos() {
            //Desabilito todos los menus  luego se activaran segun el cargo
            opcGestionPaciente.Visible = false;
            opcConsultaMedica.Visible = false;
            opcGestionDeUsuarios.Visible = false;
            opcGestionDeEmpleados.Visible = false;


            //1-ADMIN
            //2-DOCTOR

            switch (Int32.Parse(session.Cargo))
            {                
                case 1:
                    {
                        opcGestionDeUsuarios.Visible = true;
                        opcGestionDeEmpleados.Visible = true;
                    }
                    break;

                case 2:
                    {
                        opcGestionPaciente.Visible = true;
                        opcConsultaMedica.Visible = true;
                      
                    }
                    break;                
            }
        }

       

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void opcConsultaMedica_Click(object sender, EventArgs e)
        {
            this.panelOpcConsultaMedica.Visible = !this.panelOpcConsultaMedica.Visible;
        }

        private void opcGestionDeUsuarios_Click(object sender, EventArgs e)
        {
            this.panelOpcGestionDeUsuarios.Visible = !this.panelOpcGestionDeUsuarios.Visible;
        }

        private void opcGestionPaciente_Click(object sender, EventArgs e)
        {
            this.panelOpcGestionPacientes.Visible = !this.panelOpcGestionPacientes.Visible;
        }

        private void btnNuevaConsultaView_Click(object sender, EventArgs e)
        {
            this.ocultarMenus();
            this.abrirFormulario(new RegistrarConsultaView());
        }

        private void btnNuevaAgregarEmpleadoView_Click(object sender, EventArgs e)
        {
            this.ocultarMenus();
            this.abrirFormulario(new AgregarEmpleado());
        }

        private void opcGestionDeEmpleados_Click(object sender, EventArgs e)
        {
            this.panelOpcGestionDeEmpleados.Visible = !this.panelOpcGestionDeEmpleados.Visible;
        }

        private void btnVerEmpleadosView_Click(object sender, EventArgs e)
        {
            this.ocultarMenus();
            this.abrirFormulario(new ListaEmpleados());
        }

     

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarEspecialidadMedico_Click(object sender, EventArgs e)
        {
            this.ocultarMenus();
            this.abrirFormulario(new GestionEspecialidadesMedico());
        }

        private void btnRegistrarConsulta_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new RegistrarConsultaView());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new GestionUsuario());
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new EdicionUsuario());
        }

        private void btnAggPaciente_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new AgregarPaciente());
        }

        private void AgregarEspecialidad_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new AgregarEspecialidad());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new GestionEspecialidad());
        }

        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new GestionPaciente());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.abrirFormulario(new GestionHorario());
        }
    }
}
