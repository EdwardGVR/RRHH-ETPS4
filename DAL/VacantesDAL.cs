﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RRHH.DAL
{
    public class VacantesDAL
    {
        ConexionDAL conexion;
        wsRRHH.webServRRHH ws;

        public VacantesDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        // SELECTS
        public DataSet getVacantes (int top = 0)
        {
            return ws.getVacantes(top);
        }

        public DataSet getDetallesVac (string codVac)
        {
            return ws.getDetallesVacante(codVac);
        }

        public DataSet getRequisitosVac (string codVac)
        {
            return ws.getRequisitosVac(codVac);
        }

        public DataSet getDetallesReqisito (int idReq)
        {
            return ws.getDetallesRequisito(idReq);
        }

        public DataSet getEstadosVacantes ()
        {
            return ws.getEstadosVacantes();
        }

        public DataSet getAplicantesVac (int idVac)
        {
            return ws.getAplicantesVac(idVac);
        }

        public DataSet getTiposAplicantes()
        {
            return ws.getTiposAplicantes();
        }

        public Boolean uniqueAplDui(string dui)
        {
            return ws.uniqueAplDui(dui);
        }

        public DataSet getDetallesAplicante(int idApl)
        {
            return ws.getDetallesAplicante(idApl);
        }

        public DataSet getResultadosAplicaciones()
        {
            return ws.getResultadosAplicaciones();
        }

        // INSERTS
        public void insertVacante (string codVac, string vacante, int idDpto, int cupo, string descripcion)
        {
            ws.insertVacante(codVac, vacante, idDpto, cupo, descripcion);
        }

        public void insertRequisito(int idVac, string codVac, string requisito, string detalles, int idPrioridad)
        {
            ws.insertRequisito(idVac, codVac, requisito, detalles, idPrioridad);
        }

        public void insertAplicante (int idVac, string nombre, string apellido, string correo, string telefono, string direccion, int idTipo, string dui)
        {
            ws.insertAplicante(idVac, nombre, apellido, correo, telefono, direccion, idTipo, dui);
        }

        public DataSet getPrioridades ()
        {
            return ws.getPrioridadesRequisitos();
        }

        // Obtiene el correlativo de la vacante segun departamento
        public int getCorrVac(int idDpto)
        {
            return ws.getCorrVac(idDpto);
        }

        public int getIdVac (string codVac)
        {
            return ws.getIdVac(codVac);
        }

        // UPDATES
        public void updateVacante (string codVac, string newCodVac, string vacante, string descripcion, int idDpto, int idEstado, int cupo)
        {
            ws.updateVacante(codVac, newCodVac, vacante, descripcion, idDpto, idEstado, cupo);
        }

        public void updateRequisito (int idReq, string requisito, string detalles, int idPrioridad)
        {
            ws.updateRequisito(idReq, requisito, detalles, idPrioridad);
        }

        public void updateAplicante(int idApl, string nombres, string apellidos, string dui, string correo, string direccion, string telefono, int idTipo, int idResultado)
        {
            ws.updateAplicante(idApl, nombres, apellidos, dui, correo, direccion, telefono, idTipo, idResultado);
        }

        // DELETES
        public void deleteVacante (string codVac)
        {
            ws.deleteVacante(codVac);
        }

        public void deleteRequisito (int idReq)
        {
            ws.deleteRequisito(idReq);
        }

        public void deleteAplicante(int idApl)
        {
            ws.deleteAplicante(idApl);
        }
    }
}