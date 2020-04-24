using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRHH.DAL;

namespace RRHH.BLL
{
    class VacantesBLL
    {
        public DataSet getVacantes ()
        {
            VacantesDAL oVacantesDAL = new VacantesDAL();
            return oVacantesDAL.getVacantes();
        }
    }
}
