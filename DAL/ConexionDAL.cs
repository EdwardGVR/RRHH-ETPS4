using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RRHH.DAL
{
    class ConexionDAL
    {
        public wsRRHH.webServRRHH conectarWS ()
        {
            wsRRHH.webServRRHH ws = new wsRRHH.webServRRHH();
            return ws;
        }
    }
}
