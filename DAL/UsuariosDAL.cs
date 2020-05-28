using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RRHH.DAL
{
    public class UsuariosDAL
    {
        ConexionDAL conexion;
        wsRRHH.webServRRHH ws;

        public UsuariosDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        public DataSet getUsuarios ()
        {
            return ws.getUsuarios();
        }
    }
}
