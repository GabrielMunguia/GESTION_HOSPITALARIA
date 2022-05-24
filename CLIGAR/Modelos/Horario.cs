using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIGAR.Modelos
{
    class Horario
    {
        String _idHorario;
        String _inicio;
        String _final;
        String _dia;
        String _idMedico;

        public string IdHorario
        {
            get
            {
                return _idHorario;
            }

            set
            {
                _idHorario = value;
            }
        }

        public string Inicio
        {
            get
            {
                return _inicio;
            }

            set
            {
                _inicio = value;
            }
        }

        public string Final
        {
            get
            {
                return _final;
            }

            set
            {
                _final = value;
            }
        }

        public string Dia
        {
            get
            {
                return _dia;
            }

            set
            {
                _dia = value;
            }
        }

        public string IdMedico
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

        public Boolean Guardar()
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO cligar.horarios(idHorario,Hora_inicio,Hora_final,Dia,idMedico) VALUES(null,");
                Sentencia.Append("'" + this.Inicio + "',");
                Sentencia.Append("'" + this.Final + "',");
                Sentencia.Append("'" + this.Dia + "',");
                Sentencia.Append("" + this.IdMedico + ");");      
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
                Sentencia.Append("UPDATE cligar.horarios SET ");
                Sentencia.Append("Hora_inicio='" + this.Inicio + "', ");
                Sentencia.Append("Hora_final='" + this.Final + "'");                
                Sentencia.Append(" where idMedico=" + IdMedico + " ");
                Sentencia.Append("and Dia='" + this.Dia + "';");


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
        public DataTable obtenerHorariosMedico(int idMedico)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT hor.Dia, hor.Hora_inicio, hor.Hora_final FROM horarios as hor, medicos as me where hor.idMedico=me.idMedico and hor.idMedico= "+ idMedico + ";");

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
