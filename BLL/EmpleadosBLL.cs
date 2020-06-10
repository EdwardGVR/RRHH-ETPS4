using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public DataSet getEmpleadosByDpto(int idDpto)
        {
            return oEmpleadosDAL.getEmpleadosByDpto(idDpto);
        }

        public DataSet getDetallesEmpleado (int id)
        {
            return oEmpleadosDAL.getDetallesEmpleado(id);
        }

        public DataSet getEstadosContratos()
        {
            return oEmpleadosDAL.getEstadosContratos();
        }

        // INSERTS
        public void insertEmpleado(string nombres, string apellidos, string dui, string email, string telefono1, string telefono2, string direccion, int idDpto, int idCargo, double salario)
        {
            oEmpleadosDAL.insertEmpleado(nombres, apellidos, dui, email, telefono1, telefono2, direccion, idDpto, idCargo, salario);
        }

        // DELETES
        public void updateEmpleado(string nombres, string apellidos, string dui, string email, string telefono1, string telefono2,
            string direccion, int idDpto, int idCargo, double salario, int idEstadoContrato, int idEmp)
        {
            oEmpleadosDAL.updateEmpleado(nombres, apellidos, dui, email, telefono1, telefono2, direccion, idDpto, idCargo, salario, idEstadoContrato, idEmp);
        }
    }
}
