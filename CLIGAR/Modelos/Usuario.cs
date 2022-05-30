using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CLIGAR.Modelos
{
    class Usuario
    {
        string idUsuario;
        string nombreUsuario;
        string contrasena;
        string idEmpleado;

        public string IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }


        public string Contrasena
        {
            get
            {
                return contrasena;
            }

            set
            {
                contrasena = value;
            }
        }

        public string IdEmpleado
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

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        public Boolean Guardar()
        {
        
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO usuarios(idUsuario,Usuario,Contrasena,idEmpleado)VALUES(null");              
                Sentencia.Append(",'" + this.nombreUsuario + "',");
                Sentencia.Append("MD5(SHA1('" + this.contrasena + "')),");
                Sentencia.Append("'" + this.idEmpleado + "')");
             
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
                Sentencia.Append("Update usuarios set ");
                Sentencia.Append("Contrasena=MD5(sha1('" + this.contrasena + "')) where idUsuario =" + this.idUsuario);

                if (operacion.Actualizar(Sentencia.ToString()) > 0)
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

        public Boolean Eliminar()
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("Delete from usuarios where ");
                Sentencia.Append("idUsuario='" + this.idUsuario + "'");
                if (operacion.Eliminar(Sentencia.ToString()) > 0)
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

        public int obtenerUltimoIDInsertador()
        {
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            int id = -1;
            try
            {
                Sentencia.Append("SELECT Max(idUsuario)FROM usuarios;");

                DataTable resultado = operacion.Consultar(Sentencia.ToString());
                if (resultado.Rows.Count > 0)
                {
                    id = Int32.Parse(resultado.Rows[0][0].ToString());
                }
            }
            catch (Exception)
            {
                id = -1;
            }
            return id;
        }

        public DataTable TablaDatos()
        {
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable tabla = new DataTable();
            try
            {
                tabla = operacion.Consultar("SELECT u.idUsuario,u.Usuario,e.Nombres,e.Apellidos,c.Nombre as Cargo, e.Estado FROM cligar.usuarios u, cligar.empleados e, cligar.cargos c where u.idEmpleado=e.idEmpleado and e.idCargo=c.idCargo;");                
            }
            catch (Exception)
            {                
            }
            return tabla;
        }
    }
}
