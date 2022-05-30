using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIGAR.Modelos
{
   public  class Empleado
    {
        int idEmpleado;
        string nombres;
        string apellidos;
        string direccion;
        string genero;
        int idCargo;
        string codigoRegistroMedico;
        string dui;
        string nit;
        string telefono;
        Boolean estado;

        public int IdEmpleado
        {
            get
            {
                return idEmpleado;
            }

            set
            {
                idEmpleado = value;
            }
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public int IdCargo
        {
            get
            {
                return idCargo;
            }

            set
            {
                idCargo = value;
            }
        }

        public string CodigoRegistroMedico
        {
            get
            {
                return codigoRegistroMedico;
            }

            set
            {
                codigoRegistroMedico = value;
            }
        }

        public string Dui
        {
            get
            {
                return dui;
            }

            set
            {
                dui = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public Boolean Guardar() {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO `cligar`.`empleados`(`idEmpleado`,`Nombres`,`Apellidos`,`Telefono`,`Direccion`,`Genero`,`idCargo`,`CodigoRegistroMedico`,`DUI`,`NIT`,`Estado`)VALUES(null,");
                Sentencia.Append("'"+this.nombres+"',");
                Sentencia.Append("'" + this.apellidos + "',");
                Sentencia.Append("'" + this.telefono + "',");
                Sentencia.Append("'" + this.direccion + "',");
                Sentencia.Append("'" + this.genero + "',");
                Sentencia.Append("'" + this.idCargo + "',");
                Sentencia.Append("'" + this.codigoRegistroMedico + "',");
                Sentencia.Append("'" + this.dui + "',");
                Sentencia.Append("'" + this.nit + "',");
                Sentencia.Append("1);");
                Clipboard.SetText(Sentencia.ToString());
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    resultado = true;
                }
               

            }
            catch (Exception)
            {
                 resultado = false;
            }

            return resultado;
        }

        public Boolean Actualizar()
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE `cligar`.`empleados`SET");
                Sentencia.Append("`Nombres` = '" + this.nombres + "',");
                Sentencia.Append("`Apellidos`='" + this.apellidos + "',");
                Sentencia.Append("`Telefono`='" + this.telefono + "',");
                Sentencia.Append("`Direccion`='" + this.direccion + "',");
                Sentencia.Append("`Genero` ='" + this.genero + "',");
                Sentencia.Append("`idCargo` ='" + this.idCargo + "',");
                Sentencia.Append("`CodigoRegistroMedico` ='" + this.codigoRegistroMedico + "',");
                Sentencia.Append("`DUI` ='" + this.dui + "',");
                Sentencia.Append("`NIT` ='" + this.nit + "' where idEmpleado="+idEmpleado+";");

                Clipboard.SetText(Sentencia.ToString());
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    resultado = true;
                }


            }
            catch (Exception ex )
            {
                resultado = false;
                MessageBox.Show(ex.Message);
            }

            return resultado;
        }



        public int obtenerUltimoIDInsertador() {
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            int id = -1;
            try
            {
                Sentencia.Append("SELECT Max(idEmpleado)FROM empleados;");

                DataTable resultado = operacion.Consultar(Sentencia.ToString());
                if (resultado.Rows.Count > 0) {
                    id = Int32.Parse(resultado.Rows[0][0].ToString());
                }



            }
            catch (Exception)
            {

                 id = -1;
            }

            return id;


        }

        public DataTable obtenerEmpleados() {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT  idEmpleado as Codigo, Nombres, Apellidos, Telefono, Direccion, Genero, DUI, NIT, c.Nombre as Cargo   FROM empleados as e, cargos as c  where ESTADO = 1 and e.idCargo = c.idCargo; ");

                Resultado = operacion.Consultar(Sentencia.ToString());
               
            }
            catch (Exception)
            {

                Resultado = new DataTable();
            }
            return Resultado;
        }
        public DataTable obtenerEmpleado(int id)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT  *	 FROM cligar.empleados where ESTADO=1 and idEmpleado = "+id);
             
                Resultado = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception)
            {

                Resultado = new DataTable();
            }
            return Resultado;
        }

        public Boolean eliminarEmpleado(int id)
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE `cligar`.`empleados`SET`Estado` = false  WHERE `idEmpleado` =  ");
                Clipboard.SetText(Sentencia.ToString());
                Sentencia.Append(id);
           



                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    resultado = true;
                }


            }
            catch (Exception)
            {
                resultado = false;
            }

            return resultado;
        }

        public DataTable busqueda(string q)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT  idEmpleado as Codigo  , Nombres,Apellidos,Telefono ,Direccion,Genero,DUI,NIT	 FROM cligar.empleados where");
                Sentencia.Append(" ( Nombres LIKE '%"+q+"%' or ");
                Sentencia.Append("  Apellidos LIKE '%" + q + "%' or ");
                Sentencia.Append("  idEmpleado LIKE '%" + q + "%' or ");
                Sentencia.Append("  idEmpleado LIKE '%" + q + "%' or ");
            
                Sentencia.Append("  DUI LIKE '%" + q + "%' or ");
                Sentencia.Append("  NIT LIKE '%" + q + "%') and estado=1; ");
          
         
                Clipboard.SetText(Sentencia.ToString());

                Resultado = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("error");
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public DataTable busquedaEmpleadosSinUsuario(string q)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT  e.idEmpleado as Codigo  , Nombres,Apellidos,Telefono ,Direccion,Genero,DUI,NIT FROM empleados as e LEFT JOIN usuarios as u ON e.idEmpleado=u.idEmpleado  where");
                Sentencia.Append(" ( Nombres LIKE '%" + q + "%' or ");
                Sentencia.Append("  Apellidos LIKE '%" + q + "%' or ");
                Sentencia.Append("  e.idEmpleado LIKE '%" + q + "%' or ");
                Sentencia.Append("  e.idEmpleado LIKE '%" + q + "%' or ");

                Sentencia.Append("  DUI LIKE '%" + q + "%' or ");
                Sentencia.Append("  NIT LIKE '%" + q + "%') and estado=1 and u.idEmpleado is null; ");


                Clipboard.SetText(Sentencia.ToString());

                Resultado = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("error");
                Resultado = new DataTable();
            }
            return Resultado;
        }

    }
}
