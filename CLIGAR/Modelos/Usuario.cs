using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIGAR.Modelos
{
    class Usuario
    {
        int idUsuario;
        string nombreUsuario;
        string contrasena;
        string idEmpleado;

        public int IdUsuario
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
                Sentencia.Append("INSERT INTO usuarios(idUsuario,Usuario,Contrasena,idEmpleado)VALUES("+ this.idUsuario);              
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
                Sentencia.Append("Usuario='" + this.nombreUsuario + "',");
                Sentencia.Append("Contrasena=MD5(SHA1('" + this.contrasena + "')),");
                Sentencia.Append("idEmpleado='" + this.idEmpleado + "',");

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
                Sentencia.Append("idUsuario='" + this.idUsuario + "',");
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
    }
}
