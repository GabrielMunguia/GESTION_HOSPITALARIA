using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

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

        public static DataTable ReporteCitas()
        {
            DataTable Resultado = new DataTable();
            try
            {                
                String Consulta = @"SELECT concat(p.Nombres,' ',p.Apellidos) Paciente,
                concat(e.Nombres,' ', e.Apellidos) Doctor, c.Responsable, c.Fecha
                FROM citas c, pacientes p, medicos m, empleados e where c.idPaciente = p.idPaciente
                and c.idMedico = m.idMedico and m.idEmpleado = e.idEmpleado
                and c.idCita = (select max(ci.idCita) from citas ci)";
                DataManager.DBOperacion op = new DataManager.DBOperacion();
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable reportConsultasMedicos(int anio , int mes)
        {
            DataTable Resultado = new DataTable();
            try
            {
            

                String Consulta = "select concat(e.Nombres,' ',e.Apellidos)as Medico , Count(*)as Consultas,e.CodigoRegistroMedico as JVM from consultas as c ,medicos as m ,empleados as e where c.idMedico =m.idMedico and m.idEmpleado =e.idEmpleado and MONTH(c.Fecha)=" + mes+" and year(c.Fecha)="+anio+"  group by c.idMedico;";
                Clipboard.SetText(Consulta);

                DataManager.DBOperacion op = new DataManager.DBOperacion();
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }

        public static DataTable reporteEspecilidades()
        {
            DataTable Resultado = new DataTable();
            try
            {


                String Consulta = "select Nombre as Especialidad ,count(*)Medicos from especialidades as e , especialidades_medicos as em where em.idEspecialidad=e.idEspecialidad group by Nombre;";
                Clipboard.SetText(Consulta);

                DataManager.DBOperacion op = new DataManager.DBOperacion();
                Resultado = op.Consultar(Consulta);
            }
            catch (Exception)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }


        public static DataTable ReporteConsultaMensual()
        {
            DataTable Resultado = new DataTable();
            try
            {
                String Consulta = @"SELECT count(c.idConsulta) Cantidad, monthname(c.Fecha) Mes, year(c.Fecha) anio
                FROM consultas c, medicos m, pacientes p, empleados e 
                where c.idMedico=m.idMedico and m.idEmpleado=e.idEmpleado
                and c.idPaciente=p.idPaciente 
                group by date_format(c.Fecha,'%Y%m');";
                DataManager.DBOperacion op = new DataManager.DBOperacion();
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
