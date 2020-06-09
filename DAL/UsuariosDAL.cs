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

        // SELECTS
        public DataSet getUsuarios ()
        {
            return ws.getUsuarios();
        }

        public DataSet getNiveles ()
        {
            return ws.getNivelesUsuarios();
        }

        public DataSet getDetallesUsuario(int idUsuario)
        {
            return ws.getDetallesUsuario(idUsuario);
        }

        // INSERTS
        public void insertUsuario (string nombres, string apellidos, string email, string usuario, string password, int idNivel)
        {
            ws.insertUsuario(nombres, apellidos, email, usuario, password, idNivel);
        }
    }
}
