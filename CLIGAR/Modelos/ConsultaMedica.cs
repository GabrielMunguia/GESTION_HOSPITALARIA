using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIGAR.Modelos
{
    class ConsultaMedica
    {

        int _idConsulta;
        string _Observacion;
        string _Fecha;
        int _idMedico;
        int _idPaciente;
        string _Peso;
        string _Altura;
        String _Presion;
        string _receta;

        public int IdConsulta
        {
            get
            {
                return _idConsulta;
            }

            set
            {
                _idConsulta = value;
            }
        }

        public string Observacion
        {
            get
            {
                return _Observacion;
            }

            set
            {
                _Observacion = value;
            }
        }

        public string Fecha
        {
            get
            {
                return _Fecha;
            }

            set
            {
                _Fecha = value;
            }
        }

        public int IdMedico
        {
            get
            {
                return _idMedico;
            }

            set
            {
                _idMedico = value;
            }
        }

        public int IdPaciente
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

        public string Peso
        {
            get
            {
                return _Peso;
            }

            set
            {
                _Peso = value;
            }
        }

        public string Altura
        {
            get
            {
                return _Altura;
            }

            set
            {
                _Altura = value;
            }
        }

        public string Presion
        {
            get
            {
                return _Presion;
            }

            set
            {
                _Presion = value;
            }
        }

        public string Receta
        {
            get
            {
                return _receta;
            }

            set
            {
                _receta = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO `cligar`.`consultas`(`idConsulta`,`Observacion`,`Fecha`,`Receta`,`idMedico`,`idPaciente`,`Peso`,`Altura`,`Presion`) VALUES(null,");
                Sentencia.Append("'" + this.Observacion + "',");
                Sentencia.Append("'" + this.Fecha + "',");
                Sentencia.Append("'" + this.Receta + "',");
                Sentencia.Append("'" + this.IdMedico + "',");
                Sentencia.Append("'" + this.IdPaciente + "',");
                Sentencia.Append("'" + this.Peso + "',");
                Sentencia.Append("'" + this.Altura + "',");
                Sentencia.Append("'" + this.Presion + "');");
               


                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    resultado = true;
                }




            }
            catch (Exception EX)
            {

              
            
                resultado = false;
            }

            return resultado;
        }

        public DataTable obtenerHistorialConsultas(int idPaciente)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT idConsulta as Codigo,Fecha,Observacion FROM cligar.consultas where idPaciente="+idPaciente+";");

                Resultado = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception)
            {

                Resultado = new DataTable();
            }
            return Resultado;
        }

        public DataTable obtenerConsulta(int idConsulta)
        {

            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT * FROM cligar.consultas where idConsulta = " + idConsulta + ";");

                Resultado = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception)
            {

                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}
