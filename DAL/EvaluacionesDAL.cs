﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RRHH.DAL
{
    public class EvaluacionesDAL
    {
        ConexionDAL conexion;
        wsRRHH.webServRRHH ws;

        public EvaluacionesDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        // SELECTS
        public DataSet getEvaluaciones (int top = 0)
        {
            return ws.getEvaluaciones(top);
        }

        public DataSet getTiposEvaluaciones ()
        {
            return ws.getTiposEvaluaciones();
        }

        public DataSet getDetallesEvaluacion(int idEval)
        {
            return ws.getDetallesEvaluacion(idEval);
        }

        public DataSet getAsignEvalApl (int idEval)
        {
            return ws.getAsignEvalApl(idEval);
        }

        public DataSet getAplicantesByVac (int idVac)
        {
            return ws.getAplicantesByVac(idVac);
        }

        public Boolean validateEvApl(int idEval, int idApl)
        {
            return ws.validateEvApl(idEval, idApl);
        }

        public DataSet getDetallesAsignEval(int idAsign)
        {
            return ws.getDetallesAsignEval(idAsign);
        }

        // INSERTS
        public void insertEvaluacion (string evaluacion, int idTipo, string objetivos, int maxScore)
        {
            ws.insertEvaluacion(evaluacion, idTipo, objetivos, maxScore);
        }

        public void asignAplEval (int idEval, int idAplicante, string fecha, string hora)
        {
            ws.asignarAplEval(idEval, idAplicante, fecha, hora);
        }

        // UPDATES
        public void updateEvaluacion(int idEval, string evaluacion, string objetivo, int idTipo, int maxScore)
        {
            ws.updateEvaluacion(idEval, evaluacion, objetivo, idTipo, maxScore);
        }

        // DELETES
        public void deleteAsignEval (int idAsign)
        {
            ws.deleteAsigEval(idAsign);
        }

        public void deleteEvaluacion(int idEval)
        {
            ws.deleteEvaluacion(idEval);
        }
    }
}
