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
        wsRRHH.webServRRHH ws;

        public CapacitacionesDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        public DataSet getCapacitaciones (int top = 0)
        {
            return ws.getCapacitaciones(top);
        }
    }
}
