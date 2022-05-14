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

namespace CLIGAR.GUI
{
    public partial class AgregarEmpleado : Form
    {
        SessionManager.Sesion session = SessionManager.Sesion.Instance;
        public int id = -1;
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        public AgregarEmpleado(int id)
        {
            InitializeComponent();
            Empleado empleado = new Empleado();
            DataTable edEmpleado = empleado.obtenerEmpleado(id);

            if (edEmpleado.Rows.Count > 0){
                this.id = Int32.Parse(edEmpleado.Rows[0][0].ToString());
                
                this.txtNombres.Text = edEmpleado.Rows[0][1].ToString();
                this.txtApellidos.Text = edEmpleado.Rows[0][2].ToString();
                this.txtTelefono.Text = edEmpleado.Rows[0][3].ToString();
                this.txtDireccion.Text = edEmpleado.Rows[0][4].ToString();

                if (edEmpleado.Rows[0][5].ToString()=="M")
                {
                    empleado.Genero = "M";
                    this.cbxGenero.SelectedIndex = 0;
                }
                else
                {
                    this.cbxGenero.SelectedIndex = 1;
                }

                switch (edEmpleado.Rows[0][6].ToString())
                {
                    case "1":
                        {
                            this.cbxCargo.SelectedIndex = 0;
                        }break;
                    case "2":
                        {
                            this.cbxCargo.SelectedIndex = 1;
                        }
                        break;
                    case "3":
                        {
                            this.cbxCargo.SelectedIndex = 2;
                        }
                        break;
                }

                this.txtJVM.Text = edEmpleado.Rows[0][7].ToString();
                this.txtDui.Text= edEmpleado.Rows[0][8].ToString();
                this.txtNIT.Text = edEmpleado.Rows[0][9].ToString();

            }
         


            this.id = id;

         
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            if (this.id != -1)
            {
                Close();
            }
            else
            {
               
                this.reinciarFormulario();
            }

        }

        private void reinciarFormulario() {
            this.txtNombres.Text = "";
            this.txtApellidos.Text = "";
            this.txtDui.Text = "";
            this.txtNIT.Text = "";
            this.txtTelefono.Text = "";
            this.txtDireccion.Text = "";
            this.txtJVM.Text = "";
            this.cbxCargo.SelectedText = "";
            this.cbxGenero.SelectedText = "";
        }


        private void cbxCargo_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbxCargo.SelectedText);
        }

        private void cbxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {


            //Cargos 0-Administrador ,1-Doctor , 2-Recepcionista
            if (cbxCargo.SelectedIndex == 1)
            {
                lblJVM.Visible = true;
                txtJVM.Visible = true;
            }
            else
            {

                lblJVM.Visible = false;
                txtJVM.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
          Boolean esValidoElFormulario = this.validarCampos();
            
            if (esValidoElFormulario)
            {
                Empleado empleado = new Empleado();
                empleado.Nombres = this.txtNombres.Text;
                empleado.Apellidos = this.txtApellidos.Text;
                empleado.Direccion = this.txtDireccion.Text;
                empleado.Dui = this.txtDui.Text;
                empleado.Nit = this.txtNIT.Text;
                empleado.Telefono = this.txtTelefono.Text;

                if (this.id > 0)
                {
                    empleado.IdEmpleado = this.id;
                }
                //Valido el genero
                if (this.cbxGenero.SelectedIndex == 0)
                {
                    empleado.Genero = "M";
                }
                else
                {
                    empleado.Genero = "F";
                }

                //valido si es tipo doctor para asignarle el jvm



                if (this.cbxCargo.SelectedIndex == 1)
                {
                    empleado.CodigoRegistroMedico = txtJVM.Text;
                }
                empleado.IdCargo = this.cbxCargo.SelectedIndex + 1;
                Boolean exito = false;
                Boolean seGuardo = false;
                if (id > 0)
                {
                    seGuardo = empleado.Actualizar();
                }
                else
                {
                    seGuardo = empleado.Guardar();
                }

                if (seGuardo && cbxCargo.SelectedIndex == 1)
                {
                    Medico medico = new Medico();
                    medico.IdEmpleado = empleado.obtenerUltimoIDInsertador();
                    if (medico.Guardar())
                    {

                        int idMedico = medico.obtenerUltimoIDInsertado();
                        Especialidades_Medico esp_m = new Especialidades_Medico();
                        esp_m.IdMedico = idMedico;
                        esp_m.IdEspecialidad = 1;
                       bool seGuardoEspecialidad= esp_m.Guardar();
                        if (seGuardoEspecialidad)
                        {
                            exito = true;
                        }
                       

                        this.reinciarFormulario();
                    }
                    else
                    {
                        exito = false;
                    }


                }


                if (seGuardo && cbxCargo.SelectedIndex != 1)
                {

                    exito = true;
                    this.reinciarFormulario();
                }



                if (exito)
                {
                    MessageBox.Show("Se realizo el registro correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error notifique al administrador");
                }
            }
            else
            {
                MessageBox.Show("Error! Todos los campos son obligatorios");
            }

            if (this.id > 0)
            {
                Close();
            }
            



        }

        private Boolean validarCampos()
        {
            Boolean esValidoElFormulario = false;
            if (this.txtNombres.Text.Length>0&& this.txtApellidos.Text.Length > 0 && this.txtDireccion.Text.Length > 0 &&
                this.txtDui.Text.Length > 0 && this.txtNIT.Text.Length > 0 && this.txtTelefono.Text.Length > 0 && this.cbxCargo.SelectedIndex>-1
                &&this.cbxGenero.SelectedIndex>-1
               )
            {
                //valido si el cargo es doctor si es asi verifico si el campo jvm es valido
                if (this.cbxCargo.SelectedIndex == 1)
                {
                    if (txtJVM.Text.Length > 0)
                    {
                        esValidoElFormulario = true;
                    }

                }
                else
                {
                    esValidoElFormulario = true;
                }

            }


            return esValidoElFormulario;
        }

        private void tableLayoutPanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
