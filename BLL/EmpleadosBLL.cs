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
        EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();
        
        // SELECTS
        public DataSet getEmpleados()
        {
            return oEmpleadosDAL.getEmpleados();
        }

        // INSERTS
        public void insertEmpleado(string nombres, string apellidos, string dui, string email, string telefono1, string telefono2, string direccion, int idDpto, int idCargo, double salario)
        {
            oEmpleadosDAL.insertEmpleado(nombres, apellidos, dui, email, telefono1, telefono2, direccion, idDpto, idCargo, salario);
        }
    }
}
