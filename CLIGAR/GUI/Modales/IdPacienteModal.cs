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
    public partial class IdPacienteModal : Form
    {

        public int idPaciente=0;
        public string nombreCompleto = "";
        public IdPacienteModal()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente();
            DataTable listaPacientes = p.busqueda(txtBusqueda.Text);
            this.dgv.DataSource = listaPacientes;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns[dgv.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
           
           if (dgv.SelectedRows.Count>0)
            {
                ModalConfirmar mc = new ModalConfirmar();
                mc.titulo.Text = "Estas seguro de seleccionar este paciente? ";
                mc.btnConfirmar.Text = "CONFIRMAR";
                mc.btnConfirmar.BackColor = Color.DodgerBlue;
                mc.btnCancelar.BackColor = Color.Red;
                mc.ShowDialog();
                if (mc.seConfirmo)
                {
                    this.idPaciente = Int32.Parse(dgv.CurrentRow.Cells["Codigo"].Value.ToString());
                    this.nombreCompleto = dgv.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dgv.CurrentRow.Cells["Apellidos"].Value.ToString();
                    Close();
                }
            }
        }
    }
}
