using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRHH.DAL;
using RRHH.PL;

namespace RRHH.BLL
{
    class LoginBLL
    {
        public string user { get; set; }
        public string clave { get; set; }

        public void validar (string user, string clave)
        {
            LoginDAL oLoginDal = new LoginDAL();
            oLoginDal.validar(user, clave);
        }
    }
}
