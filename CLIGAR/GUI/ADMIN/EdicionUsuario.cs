using CLIGAR.Modelos;
using DataManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIGAR.GUI.ADMIN
{
    public partial class EdicionUsuario : Form
    {


        DataTable _DATOS = new DataTable();
        public EdicionUsuario()
        {
            InitializeComponent();
        }

        private void reinciarFormulario()
        {
            this.txtEmpleado.Text = "";
            this.txtIdEmpleado.Text = "";
            this.txtRepClave.Text = "";
            this.txtUsuario.Text = "";
            this.txtClave.Text = "";
        }

        private Boolean validarCampos()
        {
            Boolean esValidoElFormulario = false;
            if (this.txtRepClave.Text.Length > 0 && this.txtEmpleado.Text.Length > 0 && this.txtIdEmpleado.Text.Length > 0 &&
                this.txtUsuario.Text.Length > 0 && this.txtClave.Text.Length > 0)
            {
                if (txtClave.Text == txtRepClave.Text)
                {
                    lblClave.Text = "";
                    esValidoElFormulario = true;
                }
                else
                {
                    lblClave.Text = "Las contraseñas no coinciden";
                }
                
            }
            return esValidoElFormulario;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reinciarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                Boolean valido = validarCampos();
                if (valido)
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = usuario.obtenerUltimoIDInsertador() + 1;
                    usuario.NombreUsuario = txtUsuario.Text;
                    usuario.Contrasena = txtClave.Text;
                    usuario.IdEmpleado = txtIdEmpleado.Text;
                    usuario.Guardar();
                    MessageBox.Show("El usuario se agregó con extito", "Usuario agreado", MessageBoxButtons.OK);
                    reinciarFormulario();
                }
            }
            catch (Exception ex)
            {
                reinciarFormulario();
                MessageBox.Show(ex.Message);
            }           
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int idE = int.Parse(txtIdEmpleado.Text);
                DBOperacion op = new DBOperacion();
                Empleado emp = new Empleado();
                if (idE <= emp.obtenerUltimoIDInsertador()) {
                    _DATOS = op.Consultar("select concat(Nombres, ' ', Apellidos ) Nombre from empleados where idEmpleado=" + idE);
                    txtEmpleado.Text = _DATOS.Rows[0][0].ToString();
                    if (txtEmpleado.Text != "")
                    {
                        txtClave.Enabled = true;
                        txtUsuario.Enabled = true;
                        txtRepClave.Enabled = true;
                        lblEmpleado.Text = "";
                    }
                }            
                else
                {
                    txtClave.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtRepClave.Enabled = false;
                    txtEmpleado.Text = "";
                    lblEmpleado.Text = "No se encontró el empleado";
                }
            }
            catch (Exception)
            {

                
            }
           
        }
    }
}
