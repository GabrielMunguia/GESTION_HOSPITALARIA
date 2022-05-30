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
            Especialidad esp = new Especialidad();
            tablaEspecialidades.DataSource=esp.TablaDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                ModalConfirmar mc = new ModalConfirmar();
                mc.titulo.Text = "¿Realmente desea EDITAR el registro seleccionado?";
                mc.ShowDialog();
                if (mc.seConfirmo)
                {
                    AgregarEspecialidad f = new AgregarEspecialidad();  
                    f.txtIdEspecialidad.Text = tablaEspecialidades.CurrentRow.Cells["idEspecialidad"].Value.ToString();
                    f.txtEspcialidad.Text = tablaEspecialidades.CurrentRow.Cells["Nombre"].Value.ToString();                    
                    f.Show();
                }
                ActualizarTabla();
            }
            catch (Exception)
            {
               
                ModalInformacion mi = new ModalInformacion();
                mi.titulo.Text = "Error al procesar el comando";
                mi.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                ModalConfirmar mc = new ModalConfirmar();
                mc.titulo.Text = "¿Realmente desea ELIMINAR el registro seleccionado?";
                mc.ShowDialog();
                if (mc.seConfirmo)
                {
                    Especialidad especialidad = new Especialidad();                    
                    especialidad.IdEspecialidad = tablaEspecialidades.CurrentRow.Cells["idEspecialidad"].Value.ToString();                      
                    if (especialidad.Eliminar())
                    {
                      
                        ModalInformacion mi = new ModalInformacion();
                        mi.titulo.Text = "Registro eliminado correctamente";
                        mi.Show();
                        ActualizarTabla();
                    }
                    else
                    {
                     
                        ModalInformacion mi = new ModalInformacion();
                        mi.titulo.Text = "El registro no fue eliminado";
                        mi.Show();
                    }
                }
            }
            catch (Exception)
            {
              

                ModalInformacion mi = new ModalInformacion();
                mi.titulo.Text = "Error al procesar el comando";
                mi.Show();
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
                        

                            ModalInformacion mi = new ModalInformacion();
                            mi.titulo.Text = "Registro eliminado correctamente";
                            mi.Show();
                            ActualizarTabla();
                            ajustarTabla();
                        }
                        else
                        {
                       
                            ModalInformacion mi = new ModalInformacion();
                            mi.titulo.Text = "El registro no fue eliminado";
                            mi.Show();
                        }                        
                    }
                    catch (Exception)
                    {
                     

                        ModalInformacion mi = new ModalInformacion();
                        mi.titulo.Text = "Error al procesar el comando";
                        mi.Show();
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

                        ModalInformacion mi = new ModalInformacion();
                        mi.titulo.Text = "Error al procesar el comando";
                        mi.Show();
                    }
                }
            }
        }
    }
}
