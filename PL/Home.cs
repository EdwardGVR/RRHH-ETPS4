using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHH.PL
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            ControlUtils.centrar(pnlTitulo, lblTitulo);
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            ControlUtils.centrar(pnlTitulo, lblTitulo);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Recientes());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Recientes());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Empleados());
        }

        private void btnVacantes_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Vacantes());
        }

        private void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Capacitaciones());
        }

        private void btnEvaluaciones_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Evaluaciones());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Usuarios());
        }
    }
}
