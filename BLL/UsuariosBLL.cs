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
        public DataSet getUsuarios ()
        {
            UsuariosDAL oUsersDAL = new UsuariosDAL();
            return oUsersDAL.getUsuarios();
        }
    }
}
