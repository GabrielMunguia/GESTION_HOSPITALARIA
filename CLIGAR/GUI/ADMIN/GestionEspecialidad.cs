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
using CLIGAR.GUI.Confirmaciones;
using CLIGAR.GUI.Modales;

namespace CLIGAR.GUI.ADMIN
{
    public partial class GestionEspecialidad : Form
    {
        Especialidad especialidad = new Especialidad();

        public GestionEspecialidad()
        {
            InitializeComponent();
            ActualizarTabla();
            if (tablaEspecialidades != null)
            {
                if (tablaEspecialidades.Rows.Count != 0)
                {
                    tablaEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    tablaEspecialidades.Columns[tablaEspecialidades.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    DataGridViewImageColumn bcEditar = new DataGridViewImageColumn();
                    DataGridViewImageColumn bcEliminar = new DataGridViewImageColumn();
                    bcEditar.Name = "Editar";
                    bcEliminar.Name = "Eliminar";
                    bcEditar.DataPropertyName = "Editar";
                    bcEliminar.DataPropertyName = "Eliminar";
                    bcEditar.Image = Image.FromFile(@"C:\Users\DELL\Downloads\editar.png");
                    bcEliminar.Image = Image.FromFile(@"C:\Users\DELL\Downloads\delete.png");
                    tablaEspecialidades.Columns.Add(bcEditar);
                    tablaEspecialidades.Columns.Add(bcEliminar);
                    ajustarTabla();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajustarTabla()
        {            
            tablaEspecialidades.Columns["Editar"].DisplayIndex = 2;
            tablaEspecialidades.Columns["Eliminar"].DisplayIndex = 3;
        }

        private void GestionUsuario_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
            ajustarTabla();          
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
            catch (Exception)
            {
                MessageBox.Show("Error al procesar el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable resultado = especialidad.busqueda(this.txtBuscar.Text);
            tablaEspecialidades.DataSource = resultado;
            ajustarTabla();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            AgregarEspecialidad f = new AgregarEspecialidad();
            f.ShowDialog();
            ActualizarTabla();
            ajustarTabla();
        }

        private void tablaEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreColumna = tablaEspecialidades.Columns[e.ColumnIndex].Name;
            if (nombreColumna == "Eliminar")
            {
                ModalConfirmar pm = new ModalConfirmar();
                pm.ShowDialog();
                if (pm.seConfirmo)
                {
                    try
                    {                        
                        Especialidad especialidad = new Especialidad();

                        especialidad.IdEspecialidad = tablaEspecialidades.CurrentRow.Cells["idEspecialidad"].Value.ToString();
                        if (especialidad.Eliminar())
                        {
                            MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarTabla();
                            ajustarTabla();
                        }
                        else
                        {
                            MessageBox.Show("El registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al procesar el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (nombreColumna == "Editar")
            {
                ModalConfirmar pm = new ModalConfirmar();
                pm.titulo.Text = "Estas seguro de editar este registro?";
                pm.btnConfirmar.Text = "EDITAR";
                pm.ShowDialog();
                if (pm.seConfirmo)
                {
                    try
                    {                        
                        AgregarEspecialidad f = new AgregarEspecialidad();
                        f.txtIdEspecialidad.Text = tablaEspecialidades.CurrentRow.Cells["idEspecialidad"].Value.ToString();
                        f.txtEspcialidad.Text = tablaEspecialidades.CurrentRow.Cells["Nombre"].Value.ToString();
                        f.ShowDialog();                    
                        ActualizarTabla();
                        ajustarTabla();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al procesar el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
