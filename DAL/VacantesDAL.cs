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
        wsRRHH.webServRRHH ws;

        public VacantesDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        public DataSet getVacantes (int top = 0)
        {
            return ws.getVacantes(top);
        }

        public void insertVacante (string vacante, int idDpto, int cupo, string descripcion)
        {
            ws.insertVacante(vacante, idDpto, cupo, descripcion);
        } 

        public DataSet getPrioridades ()
        {
            return ws.getPrioridadesRequisitos();
        }

        // Obtiene el correlativo de la vacante segun departamento
        //public int getCorrVac(int idDpto) {
        //    SqlCommand query = new SqlCommand();
        //    query.CommandText = "SELECT * FROM vacantes WHERE id_departamento = @idDepartamento";
        //    query.Parameters.AddWithValue("@idDepartamento", idDpto);
        //}
    }
}