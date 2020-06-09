using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRHH.DAL;
using System.Data;

namespace RRHH.BLL
{
    class UsuariosBLL
    {
        UsuariosDAL oUsersDAL = new UsuariosDAL();
        
        // SELECTS
        public DataSet getUsuarios ()
        {
            return oUsersDAL.getUsuarios();
        }

        public DataSet getNiveles ()
        {
            return oUsersDAL.getNiveles();
        }

        public DataSet getDetallesUsuario(int idUsuario)
        {
            return oUsersDAL.getDetallesUsuario(idUsuario);
        }

        // INSERTS
        public void insertUsuario (string nombres, string apellidos, string email, string usuario, string password, int idNivel)
        {
            oUsersDAL.insertUsuario(nombres, apellidos, email, usuario, password, idNivel);
        }
    }
}
