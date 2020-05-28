using System;
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

        public DataSet getVacantes (int top = 0)
        {
            return ws.getVacantes(top);
        }

        public void insertVacante (string codVac, string vacante, int idDpto, int cupo, string descripcion)
        {
            ws.insertVacante(codVac, vacante, idDpto, cupo, descripcion);
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
    }
}