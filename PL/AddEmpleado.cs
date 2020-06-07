using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRHH.BLL;

namespace RRHH.PL
{
    public partial class AddEmpleado : Form
    {
        DepartamentosBLL departamentos = new DepartamentosBLL();

        public AddEmpleado()
        {
            InitializeComponent();

            cmbDepartamento.DataSource = departamentos.getDepartamentos().Tables[0];
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "id_departamento";

            cmbPuesto.DataSource = departamentos.getPuestos().Tables[0];
            cmbPuesto.DisplayMember = "cargo_empleado";
            cmbPuesto.ValueMember = "id_cargo_empleado";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
