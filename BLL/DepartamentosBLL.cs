using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRHH.DAL;

namespace RRHH.BLL
{
    class DepartamentosBLL
    {
        public DataSet getNombresDepartamentos ()
        {
            DepartamentosDAL oDepartamentosDAL = new DepartamentosDAL();
            return oDepartamentosDAL.getNombresDepartamentos();
        }
    }
}
