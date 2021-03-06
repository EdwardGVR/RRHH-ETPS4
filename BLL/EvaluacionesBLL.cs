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

        public DataSet getDetallesEvaluacion(int idEval)
        {
            return oEvalDAL.getDetallesEvaluacion(idEval);
        }

        public DataSet getAsignEvalApl(int idEval)
        {
            return oEvalDAL.getAsignEvalApl(idEval);
        }

        public DataSet getAplicantesByVac(int idVac)
        {
            return oEvalDAL.getAplicantesByVac(idVac);
        }

        public Boolean validateEvApl(int idEval, int idApl)
        {
            return oEvalDAL.validateEvApl(idEval, idApl);
        }

        public DataSet getDetallesAsignEval(int idAsign)
        {
            return oEvalDAL.getDetallesAsignEval(idAsign);
        }

        // INSERTS
        public void insertEvaluacion (string evaluacion, int idTipo, string objetivos, int maxScore)
        {
            oEvalDAL.insertEvaluacion(evaluacion, idTipo, objetivos, maxScore);
        }

        public void asignAplEval(int idEval, int idAplicante, string fecha, string hora)
        {
            oEvalDAL.asignAplEval(idEval, idAplicante, fecha, hora);
        }

        // UPDATES
        public void updateEvaluacion(int idEval, string evaluacion, string objetivo, int idTipo, int maxScore)
        {
            oEvalDAL.updateEvaluacion(idEval, evaluacion, objetivo, idTipo, maxScore);
        }

        // DELETES
        public void deleteAsignEval(int idAsign)
        {
            oEvalDAL.deleteAsignEval(idAsign);
        }

        public void deleteEvaluacion(int idEval)
        {
            oEvalDAL.deleteEvaluacion(idEval);
        }
    }
}
