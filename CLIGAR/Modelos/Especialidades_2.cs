using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CLIGAR.Modelos
{
   public  class Especialidades_2
    {

        int id;
        string Nombre;

        public Especialidades_2()
        {
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre1
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }

        public DataTable obtenerEspecialidadesDisponiblesMedico(int idMedico)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT esp.*FROM especialidades as esp LEFT JOIN(select esp.idEspecialidad as codigo  from especialidades as esp , especialidades_medicos as esp_m where esp.idEspecialidad = esp_m.idEspecialidad and idMedico = "+idMedico+"  ) as ct ON esp.idEspecialidad = ct.codigo where ct.codigo iS NULL; ");
            
                Clipboard.SetText(Sentencia.ToString());

           
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
