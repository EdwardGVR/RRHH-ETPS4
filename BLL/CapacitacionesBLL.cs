using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRHH.DAL;
using System.Data;

namespace RRHH.BLL
{
    class CapacitacionesBLL
    {
        CapacitacionesDAL oCapsDAL = new CapacitacionesDAL();
        
        // SELECTS
        public DataSet getCapacitaciones (int top = 0)
        {
            return oCapsDAL.getCapacitaciones(top);
        }

        public DataSet getDetallesCapacitaciones (int idCap)
        {
            return oCapsDAL.getDetallesCapacitacion(idCap);
        }

        public DataSet getAsignCapacitacion (int idCap)
        {
            return oCapsDAL.getAsignCapacitaciones(idCap);
        }

        public Boolean validateCapEmp(int idCap, int idEmp)
        {
            return oCapsDAL.validateCapEmp(idCap, idEmp);
        }

        public DataSet getDetallesAsignCap(int idAsign)
        {
            return oCapsDAL.getDetallesAsignCap(idAsign);
        }

        public DataSet getEstadosCapacitaciones()
        {
            return oCapsDAL.getEstadosCapacitaciones();
        }

        // INSERTS
        public void insertCapacitacion (string titulo, string descripcion, int cupo, int idDpto)
        {
            oCapsDAL.insertCapacitacion(titulo, descripcion, cupo, idDpto);
        }

        public void asignarEmpCap(int idCap, int idEmp)
        {
            string code = "CAP" + idCap.ToString() + "EMP" + idEmp.ToString() + "ASGN";

            oCapsDAL.asignarEmpCap(idCap, idEmp, code);
        }

        // UPDATES
        public void updateCapacitacion(int idCap, string tiutlo, string decripcion, int cupo, int idDpto, int idEstado)
        {
            oCapsDAL.updateCapacitacion(idCap, tiutlo, decripcion, cupo, idDpto, idEstado);
        }

        // DELETES
        public void deleteAsignCap(int idAsign)
        {
            oCapsDAL.deleteAsignCap(idAsign);
        }

        public void deleteCapacitacion(int idCap)
        {
            oCapsDAL.deleteCapacitacion(idCap);
        }
    }
}
