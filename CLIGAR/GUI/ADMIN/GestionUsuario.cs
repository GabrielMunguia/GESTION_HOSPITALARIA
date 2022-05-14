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
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            tablaUsuarios.DataSource = operacion.Consultar("SELECT u.idUsuario,u.Usuario,e.Nombres,e.Apellidos,c.Nombre as Cargo, e.Estado FROM cligar.usuarios u, cligar.empleados e, cligar.cargos c where u.idEmpleado=e.idEmpleado and e.idCargo=c.idCargo;");
        }
    }
}
