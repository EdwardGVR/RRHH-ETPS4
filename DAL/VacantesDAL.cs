using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RRHH.DAL
{
    public class VacantesDAL
    {
        ConexionDAL conexion;

        public VacantesDAL ()
        {
            conexion = new ConexionDAL();
        }

        public DataSet getVacantes (int top = 0)
        {
            if (top > 0) 
            {
                SqlCommand query = new SqlCommand();
                query.CommandText = "SELECT " +
                    "TOP (@top)" +
                    "vacantes.id_vacante AS ID, " +
                    "vacantes.vacante AS Vacante, " +
                    "departamentos.departamento AS Departamento, " +
                    "vacantes.cupo_vacante AS Cupo, " +
                    "vacantes.descripcion AS Descripcion, " +
                    "vacantes.fehca_creacion AS \"Fecha creacion\", " +
                    "estados_vacantes.estado AS Estado " +
                    "FROM vacantes " +
                    "JOIN departamentos ON vacantes.id_departamento = departamentos.id_departamento " +
                    "JOIN estados_vacantes ON vacantes.id_estado_vacante = estados_vacantes.id_estado_vacante " +
                    "ORDER BY vacantes.id_vacante DESC";
                query.Parameters.AddWithValue("@top", top);
                return conexion.selectQuery(query);
            } 
            else
            {
                SqlCommand query = new SqlCommand();
                query.CommandText = "SELECT " +
                    "vacantes.id_vacante AS ID, " +
                    "vacantes.vacante AS Vacante, " +
                    "departamentos.departamento AS Departamento, " +
                    "vacantes.cupo_vacante AS Cupo, " +
                    "vacantes.descripcion AS Descripcion, " +
                    "vacantes.fehca_creacion AS \"Fecha creacion\", " +
                    "estados_vacantes.estado AS Estado " +
                    "FROM vacantes " +
                    "JOIN departamentos ON vacantes.id_departamento = departamentos.id_departamento " +
                    "JOIN estados_vacantes ON vacantes.id_estado_vacante = estados_vacantes.id_estado_vacante " +
                    "ORDER BY vacantes.id_vacante DESC";
                return conexion.selectQuery(query);
            }
        }

        public void insertVacante (string vacante, int idDpto, int cupo, string descripcion)
        {
            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO vacantes(vacante, id_departamento, cupo_vacante, descripcion) " +
                "VALUES(@vacante, @idDpto, @cupo, @descripcion)";
            query.Parameters.AddWithValue("@vacante", vacante);
            query.Parameters.AddWithValue("@idDpto", idDpto);
            query.Parameters.AddWithValue("@cupo", cupo);
            query.Parameters.AddWithValue("@descripcion", descripcion);
            conexion.insertQuery(query);
        }

        public DataSet getPrioridades ()
        {
            SqlCommand query = new SqlCommand();
            query.CommandText = "SELECT prioridad_requisito FROM prioridades_requisitos";
            return conexion.selectQuery(query);
        }

        // Obtiene el correlativo de la vacante segun departamento
        public int getCorrVac(int idDpto) {
            SqlCommand query = new SqlCommand();
            query.CommandText = "SELECT * FROM vacantes WHERE id_departamento = @idDepartamento";
            query.Parameters.AddWithValue("@idDepartamento", idDpto);
        }
    }
}