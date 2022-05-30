using CLIGAR.GUI.Confirmaciones;
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

namespace CLIGAR.GUI.Modales
{
    public partial class IdMedicoModal : Form
    {
        Medico medico = new Medico();
        public int IdMedico=0;
        public string nombreMedico = "";
        public Boolean seSelecciono = false;

        public IdMedicoModal()
        {
            InitializeComponent();
        }

 

   





        private void btnBuscarMedico_Click_1(object sender, EventArgs e)
        {
            DataTable resultadoBusqueda= medico.busqueda(txtBusqueda.Text);
            if (resultadoBusqueda.Rows.Count > 0)
            {
                dgv.DataSource = resultadoBusqueda;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.Columns[dgv.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ModalConfirmar mc = new ModalConfirmar();
                mc.titulo.Text = "Estas seguro de seleccionar este doctor? ";
                mc.btnConfirmar.Text = "CONFIRMAR";
                mc.btnConfirmar.BackColor = Color.DodgerBlue;
                mc.btnCancelar.BackColor = Color.Red;
                mc.ShowDialog();
                if (mc.seConfirmo)
                {
                    this.IdMedico = Int32.Parse(dgv.CurrentRow.Cells["Codigo"].Value.ToString());
                 
                    this.nombreMedico = dgv.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dgv.CurrentRow.Cells["Apellidos"].Value.ToString();
                    this.seSelecciono = true;
                    Close();
                }
            }
        }

        private void btnCerrar_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IdMedicoModal_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
