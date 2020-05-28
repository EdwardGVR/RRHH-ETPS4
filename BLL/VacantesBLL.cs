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

        public void insertVacante (string codVac, string vacante, int idDpto, int cupo, string descripcion)
        {
            oVacantesDAL.insertVacante(codVac, vacante, idDpto, cupo, descripcion);
        }

        public DataSet getPrioridades()
        {
            return oVacantesDAL.getPrioridades();
        }

        public int getCorrVac (int idDpto)
        {
            return oVacantesDAL.getCorrVac(idDpto);
        }

        // Crea el codigo de la vacante basado en parametros
        public string setVacCode(string dpto, int corrVac)
        {
            return "VAC" + dpto.ToUpper().Trim() + corrVac.ToString();
        }
    }
}
