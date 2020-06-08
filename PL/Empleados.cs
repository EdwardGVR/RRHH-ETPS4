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
    public partial class Empleados : Form
    {
        EmpleadosBLL oEmpleadosBll;

        public Empleados()
        {
            oEmpleadosBll = new EmpleadosBLL();
            InitializeComponent();
            dgvEmpleados.DataSource = oEmpleadosBll.getEmpleados().Tables[0];
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new AddEmpleado());
            Close();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idEmp = int.Parse(dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString());

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetEmpleado(idEmp));
            Close();
        }
    }
}
