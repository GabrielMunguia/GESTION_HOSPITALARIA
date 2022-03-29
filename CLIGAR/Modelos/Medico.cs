using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIGAR.Modelos
{
    class Medico
    {
        int idMedico;
        int idEmpleado;

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

        public int IdEmpleado
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


        public Boolean Guardar()
        {
            Boolean resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO `cligar`.`medicos`(`idMedico`,`idEmpleado`)VALUES(null,");
                Sentencia.Append("'" + this.IdEmpleado + "');");
        
       
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
