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
using CLIGAR.GUI.Confirmaciones;
using CLIGAR.Modelos;

namespace CLIGAR.GUI.ADMIN
{
    public partial class GestionUsuario : Form
    {
        
        public GestionUsuario()
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
            Usuario usuario = new Usuario();
            tablaUsuarios.DataSource = usuario.TablaDatos();
        }

        private void tablaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreColumna = tablaUsuarios.Columns[e.ColumnIndex].Name;
            if (nombreColumna == "Eliminar")
            {
                ModalConfirmar pm = new ModalConfirmar();
                pm.ShowDialog();
                if (pm.seConfirmo)
                {
                    try
                    {
                        Usuario usuario = new Usuario();

                        usuario.IdUsuario = tablaUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                        if (usuario.Eliminar())
                        {
                            MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarTabla();                            
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
                        EdicionUsuario f = new EdicionUsuario();
                        f.btnBuscar.Enabled = false;
                        f.txtEmpleado.Enabled = false;
                        f.txtIdUsuario .Text = tablaUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString();
                        f.txtEmpleado.Text = tablaUsuarios.CurrentRow.Cells["Nombres"].Value.ToString() + " " + tablaUsuarios.CurrentRow.Cells["Apellidos"].Value.ToString();                        
                        f.txtUsuario.Text = tablaUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                        f.txtUsuario.Enabled = false;
                        f.ShowDialog();
                        ActualizarTabla();
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
