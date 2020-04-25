using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RRHH.DAL
{
    public class CapacitacionesDAL
    {
        ConexionDAL conexion;

        public CapacitacionesDAL ()
        {
            conexion = new ConexionDAL();
        }

        public DataSet getCapacitaciones (int top = 0)
        {
            SqlCommand query = new SqlCommand();
            
            if (top > 0)
            {
                query.CommandText = "SELECT " +
                    "TOP (@top)" +
                    "capacitaciones.id_capacitacion AS ID, " +
                    "capacitaciones.titulo AS Capacitacion, " +
                    "capacitaciones.cupo AS Cupo, " +
                    "departamentos.departamento AS Departamento, " +
                    "capacitaciones.fecha_creacion AS \"Fecha creada\", " +
                    "estados_capacitaciones.estado AS Estado, " +
                    "capacitaciones.descripcion AS Descripcion " +
                    "FROM capacitaciones " +
                    "JOIN departamentos ON capacitaciones.id_departamento = departamentos.id_departamento " +
                    "JOIN estados_capacitaciones ON capacitaciones.id_estado_capacitacion = estados_capacitaciones.id_estado_capacitacion";
                query.Parameters.AddWithValue("@top", top);
            } 
            else
            {
                query.CommandText = "SELECT " +
                    "capacitaciones.id_capacitacion AS ID, " +
                    "capacitaciones.titulo AS Capacitacion, " +
                    "capacitaciones.cupo AS Cupo, " +
                    "departamentos.departamento AS Departamento, " +
                    "capacitaciones.fecha_creacion AS \"Fecha creada\", " +
                    "estados_capacitaciones.estado AS Estado, " +
                    "capacitaciones.descripcion AS Descripcion " +
                    "FROM capacitaciones " +
                    "JOIN departamentos ON capacitaciones.id_departamento = departamentos.id_departamento " +
                    "JOIN estados_capacitaciones ON capacitaciones.id_estado_capacitacion = estados_capacitaciones.id_estado_capacitacion";
            }
            return conexion.selectQuery(query);
        }
    }
}
