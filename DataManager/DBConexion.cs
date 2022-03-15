using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DataManager
{
    public class DBConexion
    {
        protected MySqlConnection _CONEXION = new MySqlConnection();
        String CadenaConexion = "Server=localhost;Port=3306;Database=cligar;Uid=root;Pwd=rc170797;";

        protected Boolean Conectar()
        {
            Boolean Conectado = false;
            try
            {
                _CONEXION.ConnectionString = CadenaConexion;
                _CONEXION.Open();
                Conectado = true;
            }
            catch (Exception)
            {
                Conectado = false;
            }
            return Conectado;
        }
        protected void Desconectar()
        {
            try
            {
                if(_CONEXION.State==System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
