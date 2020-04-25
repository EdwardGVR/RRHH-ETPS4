using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using RRHH.DAL;

namespace RRHH.BLL
{
    class EvaluacionesBLL
    {
        public DataSet getEvaluaciones (int top = 0)
        {
            EvaluacionesDAL oEvalDAL = new EvaluacionesDAL();
            return oEvalDAL.getEvaluaciones(top);
        }
    }
}
