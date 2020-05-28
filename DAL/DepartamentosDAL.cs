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
        wsRRHH.webServRRHH ws;

        public DepartamentosDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        public DataSet getNombresDepartamentos ()
        {
            return ws.getNombresDepartamentos();
        }

        public int getDptoID (string departamento)
        {
            return ws.getDptoID(departamento);
        }

        //Obtiene la abreviatura del departamento
        public string getDptoAbv (int idDpto)
        {
            SqlCommand query = new SqlCommand();
            query.CommandText = "SELECT abreviatura FROM departamentos WHERE id_departamento = @idDpto";
            query.Parameters.AddWithValue("@idDpto", idDpto);
            DataSet result = conexion.selectQuery(query);
            return result.Tables[0].Rows[0][0].ToString();
        }
    }
}
