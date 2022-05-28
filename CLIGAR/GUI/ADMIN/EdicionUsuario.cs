using CLIGAR.GUI.Modales;
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
            this.txtRepClave.Text = "";
            this.txtUsuario.Text = "";
            this.txtClave.Text = "";
            this.txtIdEmpleado.Text = "";
        }

        private Boolean validarCampos()
        {
            Boolean esValidoElFormulario = false;
            if (this.txtRepClave.Text.Length > 0 && this.txtEmpleado.Text.Length > 0  &&
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
            Boolean esValidoElFormulario = this.validarCampos();
            if (esValidoElFormulario)
            {
                Usuario usuario = new Usuario();
                usuario.IdUsuario = txtIdUsuario.Text;
                usuario.NombreUsuario = txtIdUsuario.Text;
                usuario.Contrasena = txtClave.Text;

                if (txtIdUsuario.TextLength > 0)
                {

                    if (usuario.Actualizar())
                    {
                        MessageBox.Show("El registro fue actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (usuario.Guardar())
                    {
                        MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("El registro no fue agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                reinciarFormulario();
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
                IdEmpleadoModal idModal = new IdEmpleadoModal();

                idModal.ShowDialog();
                if (idModal.seSelecciono)
                {
                    txtIdEmpleado.Text = idModal.idEmpleado;
                    txtEmpleado.Text = idModal.nombreCompleto;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {
            if(txtEmpleado.Text.Length > 0)
            {
                txtUsuario.Enabled = true;
                txtClave.Enabled = true;
                txtRepClave.Enabled = true;
            }
            else
            {
                txtUsuario.Enabled = false;
                txtClave.Enabled = false;
                txtRepClave.Enabled = false;
            }
            
        }
    }
}
