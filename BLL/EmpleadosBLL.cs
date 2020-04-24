using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RRHH.DAL;

namespace RRHH.BLL
{
    class EmpleadosBLL
    {
        public DataSet getEmpleados()
        {
            EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();
            return oEmpleadosDAL.getEmpleados();
        }
        
    }
}
