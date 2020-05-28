using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RRHH.BLL;
using System.Windows.Forms;

namespace RRHH.DAL
{
    class LoginDAL
    {
        ConexionDAL conexion;
        wsRRHH.webServRRHH ws;

        public LoginDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        public bool validar(string user, string clave)
        {
            return ws.validarLogin(user, clave);
        }
    }
}
