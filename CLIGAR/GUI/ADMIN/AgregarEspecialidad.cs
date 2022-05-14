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
    public partial class AgregarEspecialidad : Form
    {
        public AgregarEspecialidad()
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
            txtEspcialidad.Text = "";
            
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Boolean esValidoElFormulario = this.validarCampos();
            if (esValidoElFormulario)
            {                
                Especialidad especialidad = new Especialidad();
                especialidad.IdEspecialidad = txtIdEspecialidad.Text;
                especialidad.Nombre = txtEspcialidad.Text;             
                
                if (txtIdEspecialidad.TextLength > 0)
                {
                    
                    if (especialidad.Actualizar())
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
                    if (especialidad.Guardar())
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
            if (this.txtEspcialidad.Text.Length>0)
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
