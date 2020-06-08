using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RRHH.DAL
{
    public class EmpleadosDAL
    {
        ConexionDAL conexion;
        wsRRHH.webServRRHH ws;

        public EmpleadosDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        // SELECTS
        public DataSet getEmpleados ()
        {
            return ws.getEmpleados();
        }

        public DataSet getDetallesEmpleado (int id)
        {
            return ws.getDetallesEmpleado(id);
        }

        // INSERTS
        public void insertEmpleado (string nombres, string apellidos, string dui, string email, string telefono1, string telefono2, string direccion, int idDpto, int idCargo, double salario)
        {
            ws.insertEmpleado(nombres, apellidos, dui, email, telefono1, telefono2, direccion, idDpto, idCargo, salario);
        }
    }
}
