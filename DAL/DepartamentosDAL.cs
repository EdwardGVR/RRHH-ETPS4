using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RRHH.DAL
{
    public class DepartamentosDAL
    {
        ConexionDAL conexion;
        wsRRHH.webServRRHH ws;

        public DepartamentosDAL ()
        {
            conexion = new ConexionDAL();
            ws = conexion.conectarWS();
        }

        public DataSet getDepartamentos ()
        {
            return ws.getDepartamentos();
        }

        public DataSet getNombresDepartamentos ()
        {
            return ws.getNombresDepartamentos();
        }

        public int getDptoID (string departamento)
        {
            return ws.getDptoID(departamento);
        }

        //Obtiene la abreviatura del departamento
        public string getDptoAbv (int idDpto)
        {
            return ws.getDptoAbv(idDpto);
        }

        public DataSet getPuestos ()
        {
            return ws.getPuestos();
        }
    }
}
