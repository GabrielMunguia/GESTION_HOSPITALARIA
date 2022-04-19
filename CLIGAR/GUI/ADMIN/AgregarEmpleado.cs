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
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.reinciarFormulario();

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
                Boolean seGuardo = empleado.Guardar();


                if (seGuardo && cbxCargo.SelectedIndex == 1)
                {
                    Medico medico = new Medico();
                    medico.IdEmpleado = empleado.obtenerUltimoIDInsertador();
                    if (medico.Guardar())
                    {
                        exito = true;
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

        private void btnCerrar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
