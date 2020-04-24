using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RRHH.DAL
{
    public class EmpleadosDAL
    {
        ConexionDAL conexion;

        public EmpleadosDAL ()
        {
            conexion = new ConexionDAL();
        }

        public DataSet getEmpleados ()
        {
            SqlCommand query = new SqlCommand();
            query.CommandText = 
                "SELECT " +
                "empleados.id_empleado AS ID, " +
                "empleados.nombres AS Nombres, " +
                "empleados.apellidos AS Apellidos, " +
                "empleados.correo AS Correo, " +
                "empleados.direccion AS Direccion, " +
                "cargos_empleados.cargo_empleado AS Cargo " +
                "FROM empleados " +
                "JOIN cargos_empleados " +
                "ON empleados.id_cargo_empleado = cargos_empleados.id_cargo_empleado";
            return conexion.selectQuery(query);
        }
    }
}
