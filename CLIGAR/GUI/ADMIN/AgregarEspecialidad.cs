using CLIGAR.GUI.Modales;
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
                      
                        ModalInformacion mi = new ModalInformacion();
                        mi.titulo.Text = "El registro fue actualizado correctamente";
                        mi.ShowDialog();
                        Close();
                    }
                    else
                    {
                     
                        ModalInformacion mi = new ModalInformacion();
                        mi.titulo.Text = "El registro no fue actualizado";
                        mi.Show();
                    }
                }
                else
                {
                    if (especialidad.Guardar())
                    {
                    


                        ModalInformacion mi = new ModalInformacion();
                        mi.titulo.Text = "El registro fue agregado correctamente";
                        mi.Show();

                    }
                    else
                    {
                       
                        ModalInformacion mi = new ModalInformacion();
                        mi.titulo.Text = "El registro no fue agregado";
                        mi.Show();
                    }
                }
                reinciarFormulario();
            }
            else
            {
                ModalInformacion mi = new ModalInformacion();
                mi.titulo.Text = "Todos los campos son obligatorios";
                mi.Show();
            }

        }

        private Boolean validarCampos()
        {
            Boolean esValidoElFormulario = false;
            if (this.txtEspcialidad.Text.Length>0)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }        

        private void btnCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
