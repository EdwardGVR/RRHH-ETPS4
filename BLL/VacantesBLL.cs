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

        public void insertRequisito(int idVac, string codVac, string requisito, string detalles, int idPrioridad)
        {
            oVacantesDAL.insertRequisito(idVac, codVac, requisito, detalles, idPrioridad);
        }

        public DataSet getPrioridades()
        {
            return oVacantesDAL.getPrioridades();
        }

        public int getCorrVac (int idDpto)
        {
            return oVacantesDAL.getCorrVac(idDpto);
        }

        public int getIdVac (string codVac)
        {
            return oVacantesDAL.getIdVac(codVac);
        }

        // Crea el codigo de la vacante basado en parametros
        public string setVacCode(string dpto, int corrVac)
        {
            return "VAC" + dpto.ToUpper().Trim() + corrVac.ToString();
        }
    }
}
