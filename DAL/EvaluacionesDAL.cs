using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RRHH.DAL
{
    public class EvaluacionesDAL
    {
        ConexionDAL conexion;
        wsRRHH.webServRRHH ws;

        public EvaluacionesDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        // SELECTS
        public DataSet getEvaluaciones (int top = 0)
        {
            return ws.getEvaluaciones(top);
        }

        public DataSet getTiposEvaluaciones ()
        {
            return ws.getTiposEvaluaciones();
        }

        // INSERTS
        public void insertEvaluacion (string evaluacion, int idTipo, string objetivos, int maxScore)
        {
            ws.insertEvaluacion(evaluacion, idTipo, objetivos, maxScore);
        }
    }
}
