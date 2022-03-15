using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace DataManager
{
    public class DBOperacion:DBConexion
    {
        public Int32 Insertar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }

        public Int32 Actualizar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }

        public Int32 Eliminar(String pSentencia)
        {
            return EjecutarSentencia(pSentencia);
        }

        private Int32 EjecutarSentencia(String pSentencia)
        {
            MySqlCommand Comando = new MySqlCommand();
            Int32 FilasAfectadas = 0;
            try
            {
                if(Conectar())
                {
                    Comando.Connection = base._CONEXION;
                    Comando.CommandType = System.Data.CommandType.Text;
                    Comando.CommandText = pSentencia;
                    FilasAfectadas=Comando.ExecuteNonQuery();
                    Desconectar();
                }
            }
            catch (Exception)
            {
                FilasAfectadas = -1;
            }
            return FilasAfectadas;
        }

        public DataTable Consultar(String pConsulta)
        {
            MySqlCommand Comando = new MySqlCommand();
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();
            DataTable Resultado = new DataTable();
            try
            {
                if(base.Conectar())
                {
                    Comando.Connection = base._CONEXION;
                    Comando.CommandType = System.Data.CommandType.Text;
                    Comando.CommandText = pConsulta;
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(Resultado);
                    Desconectar();
                }
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}
