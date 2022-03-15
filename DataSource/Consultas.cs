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
        public static DataTable INICIO_SESION(String pUsuario, String pClave)
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"SELECT 
            a.IDUsuario, a.Usuario, a.Clave, a.IDEmpleado, 
            b.Nombres,b.Apellidos, 
            CONCAT(b.Nombres,' ',b.Apellidos) Empleado,
            b.Genero ,a.IDRol, c.Rol  
            FROM usuarios a, empleados b, roles c 
            WHERE a.IDEmpleado=b.IDEmpleado 
            AND c.IDRol=a.IDRol 
            AND a.Usuario='"+pUsuario+@"' 
            AND a.Clave=MD5(SHA1('"+pClave+"'));";
            //TENEMOS LISTA LA CONSULTA
            //SOLO FALTA EL COMPONENTE PARA EJECUTARLA
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
