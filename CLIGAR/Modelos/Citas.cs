using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CLIGAR.Modelos
{
    class Citas
    {
        int idCita;
        string Urgencia;
        string Fecha;
        int idPaciente;
        int idMedico;
        string Responsable;
        string ContactoResponsable;

        public int IdCita
        {
            get
            {
                return idCita;
            }

            set
            {
                idCita = value;
            }
        }

        public string Urgencia1
        {
            get
            {
                return Urgencia;
            }

            set
            {
                Urgencia = value;
            }
        }

        public string Fecha1
        {
            get
            {
                return Fecha;
            }

            set
            {
                Fecha = value;
            }
        }

        public int IdPaciente
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

        public int IdMedico
        {
            get
            {
                return idMedico;
            }

            set
            {
                idMedico = value;
            }
        }

        public string Responsable1
        {
            get
            {
                return Responsable;
            }

            set
            {
                Responsable = value;
            }
        }

        public string ContactoResponsable1
        {
            get
            {
                return ContactoResponsable;
            }

            set
            {
                ContactoResponsable = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO `cligar`.`citas`(`idCita`,`Urgencia`,`Fecha`,`idPaciente`,`Responsable`,`Contacto_Responsable`,`idMedico`)VALUES(null,");
                Sentencia.Append("'" + this.Urgencia + "',");
                Sentencia.Append("'" + this.Fecha + "',");
                Sentencia.Append("'" + this.IdPaciente + "',");
                Sentencia.Append("'" + this.Responsable + "',");
                Sentencia.Append("'" + this.ContactoResponsable + "',");
                Sentencia.Append("'" + this.IdMedico + "' );");
    
            
              

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


        public DataTable obtenerCitasAgendadas(string dia,string mes,string anio)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {

               
                Sentencia.Append("SELECT idCita as Codigo , Urgencia,  DATE_FORMAT(Fecha, '%H:%I:%S' )as HORA  FROM cligar.citas where idMedico = " + this.idMedico + " and year(Fecha)=" + anio+ " and month(Fecha)=" + mes+ " and day(Fecha)=" + dia+ " and Estado=1 ;");

                Clipboard.SetText(Sentencia.ToString());

      

                


                Resultado = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Resultado = new DataTable();
            }
            return Resultado;
        }
        public DataTable obtenerCitasAgendadasDetalle(string dia, string mes, string anio)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {


                Sentencia.Append("SELECT idCita as Codigo , concat(Nombres,' ',Apellidos)as nombrePaciente,p.idPaciente as CodigoPaciente , Urgencia,  DATE_FORMAT(Fecha, '%H:%I:%S' )as HORA  FROM citas as c ,pacientes as p    where c.idPaciente=p.idPaciente and idMedico = " + this.idMedico + " and year(Fecha)=" + anio + " and month(Fecha)=" + mes + " and day(Fecha)=" + dia + " and Estado=1 ;");

                Clipboard.SetText(Sentencia.ToString());






                Resultado = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public Boolean eliminar(int id)
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE `cligar`.`citas`SET`Estado` = 0  WHERE `idCita` =  "+id);
                Clipboard.SetText(Sentencia.ToString());
      




                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    resultado = true;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                resultado = false;
            }

            return resultado;
        }






    }
}
