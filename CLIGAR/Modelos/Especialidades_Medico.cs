using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIGAR.Modelos
{
    class Especialidades_Medico
    {
        int id;
        int idMedico;
        int idEspecialidad;

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

        public int IdEspecialidad
        {
            get
            {
                return idEspecialidad;
            }

            set
            {
                idEspecialidad = value;
            }
        }

        public Boolean Guardar()
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT * FROM cligar.especialidades_medicos;INSERT INTO `cligar`.`especialidades_medicos`(`idEspecialidades_Medico`,`idMedico`,`idEspecialidad`)VALUES(null,");
                Sentencia.Append("'" + this.IdMedico + "',");
                Sentencia.Append("'" + this.IdEspecialidad + "');");


                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    resultado = true;
                }




            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

                resultado = false;
            }

            return resultado;
        }


        public DataTable obtenerEspecialidadesMedico(int idMedico)
        {
            DataTable Resultado = new DataTable();
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("SELECT esp.idEspecialidad as Codigo, esp.Nombre FROM especialidades as esp , especialidades_medicos as e where esp.idEspecialidad=e.idEspecialidad and idMedico= " + idMedico + ";");
             
                Resultado = operacion.Consultar(Sentencia.ToString());

            }
            catch (Exception)
            {

                Resultado = new DataTable();
            }
            return Resultado;
        }

        public Boolean EliminarEspecialidadMedico (int idMedico,int idEspecialidad)
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("DELETE FROM `cligar`.`especialidades_medicos`WHERE idMedico ="+ idMedico + " and idEspecialidad ="+ idEspecialidad + "; ");
             


                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    resultado = true;
                }




            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

                resultado = false;
            }

            return resultado;
        }



    }
}
