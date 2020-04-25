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
        VacantesDAL oVacantesDAL = new VacantesDAL();
        
        public DataSet getVacantes (int top = 0)
        {
            return oVacantesDAL.getVacantes(top);
        }

        public void insertVacante (string vacante, int idDpto, int cupo, string descripcion)
        {
            oVacantesDAL.insertVacante(vacante, idDpto, cupo, descripcion);
        }
    }
}
