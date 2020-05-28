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
        DepartamentosDAL oDepartamentosDAL = new DepartamentosDAL();
        
        public DataSet getNombresDepartamentos ()
        {
            return oDepartamentosDAL.getNombresDepartamentos();
        }

        public int getDptoID (string departamento)
        {
            return oDepartamentosDAL.getDptoID(departamento);
        }

        public string getDptoAbv(int idDpto)
        {
            return oDepartamentosDAL.getDptoAbv(idDpto);
        }
    }
}
