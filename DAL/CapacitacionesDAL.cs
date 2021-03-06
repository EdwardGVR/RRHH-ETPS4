﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RRHH.DAL
{
    public class CapacitacionesDAL
    {
        ConexionDAL conexion;
        wsRRHH.webServRRHH ws;

        public CapacitacionesDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        // SELECTS
        public DataSet getCapacitaciones (int top = 0)
        {
            return ws.getCapacitaciones(top);
        }
        
        public DataSet getDetallesCapacitacion (int idCap)
        {
            return ws.getDetallesCapacitacion(idCap);
        }

        public DataSet getAsignCapacitaciones (int idCap)
        {
            return ws.getAsignCapacitaciones(idCap);
        }

        public Boolean validateCapEmp (int idCap, int idEmp)
        {
            return ws.validateCapEmp(idCap, idEmp);
        }

        public DataSet getDetallesAsignCap (int idAsign)
        {
            return ws.getDetallesAsignCap(idAsign);
        }

        public DataSet getEstadosCapacitaciones()
        {
            return ws.getEstadosCapacitaciones();
        }

        // INSERTS
        public void insertCapacitacion (string titulo, string descripcion, int cupo, int idDpto)
        {
            ws.insertCapacitacion(titulo, descripcion, cupo, idDpto);
        }

        public void asignarEmpCap (int idCap, int idEmp, string codigo)
        {
            ws.asignarEmpCap(idCap, idEmp, codigo);
        }

        // UPDATES
        public void updateCapacitacion(int idCap, string tiutlo, string decripcion, int cupo, int idDpto, int idEstado)
        {
            ws.updateCapacitacion(idCap, tiutlo, decripcion, cupo, idDpto, idEstado);
        }

        // DELETES
        public void deleteAsignCap (int idAsign)
        {
            ws.deleteAsignCap(idAsign);
        }

        public void deleteCapacitacion(int idCap)
        {
            ws.deleteCapacitacion(idCap);
        }
    }
}
