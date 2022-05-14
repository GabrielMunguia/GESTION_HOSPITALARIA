using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CLIGAR.Modelos
{
    class Paciente
    {
        int idPaciente;

        string _idPaciente;
        string _Nombres;
        string _Apellidos;
        string _Telefono;
        string _Direccion;
        string _FechaNac;
        string _DUI;
        string _Genero;

        public string IdPaciente
        {
            get
            {
                return _idPaciente;
            }

            set
            {
                _idPaciente = value;
            }
        }

        public string Nombres
        {
            get
            {
                return _Nombres;
            }

            set
            {
                _Nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string FechaNac
        {
            get
            {
                return _FechaNac;
            }

            set
            {
                _FechaNac = value;
            }
        }

        public string DUI
        {
            get
            {
                return _DUI;
            }

            set
            {
                _DUI = value;
            }
        }

        public string Genero
        {
            get
            {
                return _Genero;
            }

            set
            {
                _Genero = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO cligar.pacientes(idPaciente,Nombres,Apellidos,Telefono,Direccion,Fecha_nac,DUI,Genero) VALUES(null");
                Sentencia.Append(",'" + this.Nombres + "'");
                Sentencia.Append(",'" + this.Apellidos + "'");
                Sentencia.Append(",'" + this.Telefono + "'");
                Sentencia.Append(",'" + this.Direccion + "'");
                Sentencia.Append(",'" + this.FechaNac + "'");
                Sentencia.Append(",'" + this.DUI + "'");
                Sentencia.Append(",'" + this.Genero + "')");

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
                Sentencia.Append("Update cligar.pacientes set ");
                Sentencia.Append("Nombres='" + this.Nombres + "',");
                Sentencia.Append("Apellidos='" + this.Apellidos + "',");
                Sentencia.Append("Telefono='" + this.Telefono + "',");
                Sentencia.Append("Direccion='" + this.Direccion + "',");
                Sentencia.Append("Fecha_nac='" + this.FechaNac + "',");
                Sentencia.Append("DUI='" + this.DUI + "',");
                Sentencia.Append("Genero='" + this.Genero + "' ");
                Sentencia.Append("where idPaciente='" + int.Parse(this.IdPaciente) + "'");

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
                Sentencia.Append("Delete from cligar.pacientes where ");
                Sentencia.Append("idPaciente=" + this.IdPaciente);
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
        public int IdMedico
        {
            get
            {
                return idPaciente;
            }

            set
            {
                idPaciente = value;
            }
        }

      


       
        public DataTable obtenerPacientes()
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT idPaciente as Codigo , Nombres,Apellidos,Direccion,Telefono,Fecha_nac,DUI,Genero FROM pacientes;");

                Resultado = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception)
            {

                Resultado = new DataTable();
            }
            return Resultado;
        }

        public DataTable busqueda(string q)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT idPaciente as Codigo , Nombres,Apellidos,Direccion,Telefono,Fecha_nac,DUI,Genero	 FROM pacientes where");
                Sentencia.Append(" ( Nombres LIKE '%" + q + "%' or ");
                Sentencia.Append("  Apellidos LIKE '%" + q + "%' or ");
                Sentencia.Append(" concat(Nombres,' ',Apellidos) LIKE '%" + q + "%' or ");
                Sentencia.Append("  DUI LIKE '%" + q + "%') ; ");
             


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
