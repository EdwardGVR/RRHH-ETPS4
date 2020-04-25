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
        public DataSet getCapacitaciones (int top = 0)
        {
            CapacitacionesDAL oCapsDAL = new CapacitacionesDAL();
            return oCapsDAL.getCapacitaciones(top);
        }
    }
}
