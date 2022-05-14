using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;
using CLIGAR.Modelos;

namespace CLIGAR.GUI.ADMIN
{
    public partial class GestionEspecialidad : Form
    {
        
        public GestionEspecialidad()
        {
            InitializeComponent();               
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void GestionUsuario_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            tablaEspecialidades.DataSource = operacion.Consultar("SELECT * FROM cligar.especialidades;");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AgregarEspecialidad f = new AgregarEspecialidad();  
                    f.txtIdEspecialidad.Text = tablaEspecialidades.CurrentRow.Cells["idEspecialidad"].Value.ToString();
                    f.txtEspcialidad.Text = tablaEspecialidades.CurrentRow.Cells["Nombre"].Value.ToString();                    

                    f.ShowDialog();
                }
                ActualizarTabla();
            }
            catch { }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Especialidad especialidad = new Especialidad();
                    
                    especialidad.IdEspecialidad = tablaEspecialidades.CurrentRow.Cells["idEspecialidad"].Value.ToString();                    
                    if (especialidad.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarTabla();
                    }
                    else
                    {
                        MessageBox.Show("El registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al procesar el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
