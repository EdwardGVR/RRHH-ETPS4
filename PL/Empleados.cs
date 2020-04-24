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
    }
}
