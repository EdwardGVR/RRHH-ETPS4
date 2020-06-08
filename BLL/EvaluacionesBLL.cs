﻿using System;
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
        EvaluacionesDAL oEvalDAL = new EvaluacionesDAL();

        // SELECTS
        public DataSet getEvaluaciones (int top = 0)
        {
            return oEvalDAL.getEvaluaciones(top);
        }

        public DataSet getTiposEvaluaciones()
        {
            return oEvalDAL.getTiposEvaluaciones();
        }

        // INSERTS
        public void insertEvaluacion (string evaluacion, int idTipo, string objetivos, int maxScore)
        {
            oEvalDAL.insertEvaluacion(evaluacion, idTipo, objetivos, maxScore);
        }
    }
}
