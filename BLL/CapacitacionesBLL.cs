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

        // INSERTS
        public void insertCapacitacion (string titulo, string descripcion, int cupo, int idDpto)
        {
            oCapsDAL.insertCapacitacion(titulo, descripcion, cupo, idDpto);
        }
    }
}
