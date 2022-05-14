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
