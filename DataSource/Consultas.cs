using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataSource
{
    public static class Consultas
    {
        public static DataTable INICIO_SESION(String usuario, String password)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"select *   from usuarios as u,empleados as e where u.Usuario = '" + usuario + "' and u.contrasena=MD5(SHA1('" + password + "')) and u.idEmpleado=e.idEmpleado and e.Estado=1;";
           
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable PERMISOS(String pIDRol)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT IDOpcion,
            (Select Opcion FROM opciones z WHERE z.IDOpcion=a.IDOpcion) Opcion 
            FROM permisos a where IDRol="+ pIDRol + ";";
            DataManager.DBOperacion op = new DataManager.DBOperacion();
            try
            {
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
    }
}
