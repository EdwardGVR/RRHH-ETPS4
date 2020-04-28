using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RRHH.DAL
{
    public class DepartamentosDAL
    {
        ConexionDAL conexion;

        public DepartamentosDAL ()
        {
            conexion = new ConexionDAL();
        }

        public DataSet getNombresDepartamentos ()
        {
            SqlCommand query = new SqlCommand();
            query.CommandText = "SELECT departamento FROM departamentos";
            return conexion.selectQuery(query);
        }

        public int getDptoID (string departamento)
        {
            int id;
            SqlCommand query = new SqlCommand();
            query.CommandText = "SELECT id_departamento FROM departamentos WHERE departamento = @departamento";
            query.Parameters.AddWithValue("@departamento", departamento);
            DataSet result = conexion.selectQuery(query);
            id = int.Parse(result.Tables[0].Rows[0][0].ToString());
            return id;
        }
    }
}
