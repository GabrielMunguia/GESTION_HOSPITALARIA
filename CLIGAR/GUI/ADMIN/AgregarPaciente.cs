using CLIGAR.Modelos;
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
    public partial class AgregarPaciente : Form
    {
        public AgregarPaciente()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.reinciarFormulario();

        }

        private void reinciarFormulario() {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtDui.Text = "";
            
        }


        

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Boolean esValidoElFormulario = this.validarCampos();
            if (esValidoElFormulario)
            {                
                Paciente paciente = new Paciente();
                paciente.IdPaciente = txtIdPaciente.Text;
                paciente.Nombres = this.txtNombres.Text;
                paciente.Apellidos = this.txtApellidos.Text;
                paciente.Direccion = this.txtDireccion.Text;
                paciente.DUI = this.txtDui.Text;               
                paciente.Telefono = this.txtTelefono.Text;
                paciente.FechaNac = dateTimePicker1.Value.Date.ToString("yyyy/MM/dd");  
                if (this.cbxGenero.SelectedIndex == 0)
                {
                    paciente.Genero = "M";
                }
                else
                {
                    paciente.Genero = "F";
                }
                
                if (txtIdPaciente.TextLength > 0)
                {
                    
                    if (paciente.Actualizar())
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
                    if (paciente.Guardar())
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

        private Boolean validarCampos()
        {
            Boolean esValidoElFormulario = true;
            if (this.txtNombres.Text.Length>0&& this.txtApellidos.Text.Length > 0 && this.txtDireccion.Text.Length > 0 &&
                this.txtDui.Text.Length > 0  && this.txtTelefono.Text.Length > 0 && this.cbxGenero.SelectedIndex>-1
               )
            {
                esValidoElFormulario = true;
            }
            else
            {
                esValidoElFormulario = true;
            }
            return esValidoElFormulario;
        }

        private void btnCerrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
