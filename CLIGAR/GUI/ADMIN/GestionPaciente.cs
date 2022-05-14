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
    public partial class GestionPaciente : Form
    {
        
        public GestionPaciente()
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
            tablaPacientes.DataSource = operacion.Consultar("SELECT * FROM cligar.pacientes;");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AgregarPaciente f = new AgregarPaciente();  
                    f.txtIdPaciente.Text = tablaPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();
                    f.txtNombres.Text = tablaPacientes.CurrentRow.Cells["Nombres"].Value.ToString();
                    f.txtApellidos.Text = tablaPacientes.CurrentRow.Cells["Apellidos"].Value.ToString();
                    f.txtDireccion.Text = tablaPacientes.CurrentRow.Cells["Direccion"].Value.ToString();
                    f.txtDui.Text = tablaPacientes.CurrentRow.Cells["DUI"].Value.ToString();
                    f.txtTelefono.Text = tablaPacientes.CurrentRow.Cells["Telefono"].Value.ToString();
                    f.dateTimePicker1.Text = tablaPacientes.CurrentRow.Cells["Fecha_nac"].Value.ToString();
                    if (tablaPacientes.CurrentRow.Cells["Genero"].Value.ToString() == "M")
                    {
                        f.cbxGenero.SelectedIndex = 0;
                    }
                    else
                    {
                        f.cbxGenero.SelectedIndex = 1;
                    }
                    

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
                    Paciente paciente = new Paciente();
                    
                    paciente.IdPaciente = tablaPacientes.CurrentRow.Cells["idPaciente"].Value.ToString();                    
                    if (paciente.Eliminar())
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
