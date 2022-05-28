using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIGAR.Modelos
{
    class Especialidad
    {
        string _idEspecialidad;
        string _nombre;

        public string IdEspecialidad
        {
            get
            {
                return _idEspecialidad;
            }

            set
            {
                _idEspecialidad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO cligar.especialidades(idEspecialidad,Nombre) VALUES(null");
                Sentencia.Append(",'" + this.Nombre + "')");

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
                Sentencia.Append("Update cligar.especialidades set ");
                Sentencia.Append("Nombre='" + this.Nombre + "' ");               
                Sentencia.Append("where idEspecialidad='" + int.Parse(this.IdEspecialidad) + "'");

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
                Sentencia.Append("Delete from cligar.especialidades where ");
                Sentencia.Append("idEspecialidad=" + this.IdEspecialidad);
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
                Sentencia.Append("SELECT Max(idPaciente)FROM pacientes;");

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

        public DataTable busqueda(string q)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT  idEspecialidad, Nombre FROM cligar.especialidades where");
                Sentencia.Append(" Nombre LIKE '%" + q + "%'");

                
                Resultado = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public DataTable TablaDatos()
        {
            DataTable resultado = new DataTable();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                resultado = operacion.Consultar("SELECT * FROM cligar.especialidades;");
            }
            catch (Exception)
            {
            }            
            return resultado;
        }
    }
}
