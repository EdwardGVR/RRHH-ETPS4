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
    }
}
