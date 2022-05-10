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
    public partial class ListaEmpleados : Form

    
    {
         private  DataTable _DATA= new DataTable();
        private Empleado empleado = new Empleado();
        public ListaEmpleados()
        {
            InitializeComponent();

            AgregarEmpleado ag = new AgregarEmpleado();
        

            this.dgvEmpleados.DataSource = this.empleado.obtenerEmpleados();
            if (dgvEmpleados != null)
            {
                if (dgvEmpleados.Rows.Count != 0)
                {
                    Icon iconoEditar = new Icon(Environment.CurrentDirectory + @"\\editar.ico");
                    dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvEmpleados.Columns[dgvEmpleados.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                     DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                    DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();


                    btnEliminar.Name = "Eliminar";
                    btnEliminar.Text = "X";
                    btnEditar.Text = "*";
                    btnEditar.Name = "Editar";

                    dgvEmpleados.Columns.Add(btnEliminar);
                    dgvEmpleados.Columns.Add(btnEditar);
               
                    var Amarillo = System.Drawing.Color.Red;
                    dgvEmpleados.Columns["Editar"].InheritedStyle.ForeColor = Amarillo;
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable resultado = empleado.busqueda(this.txtBuscar.Text);
            this.dgvEmpleados.DataSource = resultado;
        }

        private void dgvEmpleados_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            /*

              if (e.ColumnIndex >= 0 && this.dgvEmpleados.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
             {
                 e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                 DataGridViewButtonCell btnEliminar = this.dgvEmpleados.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;

                 Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\editar.ico");
                 e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                 this.dgvEmpleados.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                 this.dgvEmpleados.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                 e.Handled = true;
             } else if (e.ColumnIndex >= 0 && this.dgvEmpleados.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
             {
                 e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                 DataGridViewButtonCell btnEliminar = this.dgvEmpleados.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;

                 Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\remove.ico");
                 e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                 this.dgvEmpleados.Rows[e.RowIndex].Height = icoAtomico.Height + 20;
                 this.dgvEmpleados.Columns[e.ColumnIndex].Width = icoAtomico.Width + 20;

                 e.Handled = true;
             }
             */
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
