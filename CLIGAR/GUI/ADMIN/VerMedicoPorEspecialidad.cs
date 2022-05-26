using CLIGAR.GUI.Confirmaciones;
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

namespace CLIGAR.GUI.ADMIN
{
    public partial class VerMedicoPorEspecialidad : Form

    
    {
         private  DataTable _DATA= new DataTable();
        private Empleado empleado = new Empleado();
        public VerMedicoPorEspecialidad()
        {
            InitializeComponent();

            AgregarEmpleado ag = new AgregarEmpleado();
        

            this.dgvEmpleados.DataSource = this.empleado.obtenerEmpleados();
            if (dgvEmpleados != null)
            {
                if (dgvEmpleados.Rows.Count != 0)
                {
                   
                    dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvEmpleados.Columns[dgvEmpleados.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                   
                }



            }
        }

      
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvEmpleados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string nombreColumna = dgvEmpleados.Columns[e.ColumnIndex].Name;



            if (nombreColumna == "Eliminar")
            {
                ModalConfirmar pm = new ModalConfirmar();
                pm.ShowDialog();


                if (pm.seConfirmo)
                {
                    int indexColumna = dgvEmpleados.CurrentRow.Index;
                    var id = Int32.Parse(dgvEmpleados[2, indexColumna].Value.ToString());
                    Boolean seElimino = this.empleado.eliminarEmpleado(id);
                    this.dgvEmpleados.DataSource = this.empleado.obtenerEmpleados();

                    ModalInformacion mf = new ModalInformacion();
                    mf.titulo.Text = "Se elimino el registro con exito";
                    mf.ShowDialog();
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
                    int indexColumna = dgvEmpleados.CurrentRow.Index;
                    var id = Int32.Parse(dgvEmpleados[2, indexColumna].Value.ToString());
                    AgregarEmpleado ag = new AgregarEmpleado(id);
                    ag.ShowDialog();
                    this.dgvEmpleados.DataSource = this.empleado.obtenerEmpleados();
                }
                

            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
      

        private void dgvEmpleados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
           
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {            
            Medico medico = new Medico();
            dgvEmpleados.DataSource = medico.obtenerMedicoPorEspecialidad(cmbEspecialidad.SelectedValue.ToString    ());
        }

        private void VerMedicoPorEspecialidad_Load(object sender, EventArgs e)
        {
            Especialidad ep = new Especialidad();
            DataTable lst = ep.TablaDatos();
            cmbEspecialidad.DisplayMember = "Nombre";
            cmbEspecialidad.ValueMember = "idEspecialidad";
            cmbEspecialidad.DataSource = lst;
        }
    }
}
