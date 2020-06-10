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
        
        // GETS
        public DataSet getVacantes (int top = 0)
        {
            return oVacantesDAL.getVacantes(top);
        }

        public DataSet getDetVac (string codVac)
        {
            return oVacantesDAL.getDetallesVac(codVac);
        }

        public DataSet getReqVac (string codVac)
        {
            return oVacantesDAL.getRequisitosVac(codVac);
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

        public DataSet getDetallesRequisito (int idReq)
        {
            return oVacantesDAL.getDetallesReqisito(idReq);
        }

        public DataSet getEstadosVacantes ()
        {
            return oVacantesDAL.getEstadosVacantes();
        }

        public DataSet getAplicantesVac(int idVac)
        {
            return oVacantesDAL.getAplicantesVac(idVac);
        }

        public DataSet getTiposAplicantes()
        {
            return oVacantesDAL.getTiposAplicantes();
        }

        public Boolean uniqueAplDui(string dui)
        {
            return oVacantesDAL.uniqueAplDui(dui);
        }

        // UPDATES
        public void updateVacante (string codVac, string newCodVac, string vacante, string descripcion, int idDpto, int idEstado, int cupo)
        {
            oVacantesDAL.updateVacante(codVac, newCodVac, vacante, descripcion, idDpto, idEstado, cupo);
        }

        public void updateRequisito (int idReq, string requisito, string detalles, int idPrioridad)
        {
            oVacantesDAL.updateRequisito(idReq, requisito, detalles, idPrioridad);
        }

        // INSERTS
        public void insertVacante(string codVac, string vacante, int idDpto, int cupo, string descripcion)
        {
            oVacantesDAL.insertVacante(codVac, vacante, idDpto, cupo, descripcion);
        }

        public void insertRequisito(int idVac, string codVac, string requisito, string detalles, int idPrioridad)
        {
            oVacantesDAL.insertRequisito(idVac, codVac, requisito, detalles, idPrioridad);
        }

        public void insertAplicante(int idVac, string nombre, string apellido, string correo, string telefono, string direccion, int idTipo, string dui)
        {
            oVacantesDAL.insertAplicante(idVac, nombre, apellido, correo, telefono, direccion, idTipo, dui);
        }

        // Crea el codigo de la vacante basado en parametros
        public string setVacCode(string dpto, int corrVac)
        {
            return "VAC" + dpto.ToUpper().Trim() + corrVac.ToString();
        }

        // DELETES
        public void deleteVacante (string codVac)
        {
            oVacantesDAL.deleteVacante(codVac);
        }

        public void deleteRequisito (int idReq)
        {
            oVacantesDAL.deleteRequisito(idReq);
        }
    }
}
