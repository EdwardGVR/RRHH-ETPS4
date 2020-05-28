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
        wsRRHH.webServRRHH ws;

        public EmpleadosDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        public DataSet getEmpleados ()
        {
            return ws.getEmpleados();
        }
    }
}
