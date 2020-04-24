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
    public partial class Recientes : Form
    {
        public Recientes()
        {
            InitializeComponent();
        }

        private void btnVerTodasVacantes_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Vacantes());
            Close();
        }

        private void btnVerTodasCapacitaciones_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Capacitaciones());
            Close();
        }

        private void btnVerTodasEvaluaciones_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Evaluaciones());
            Close();
        }
    }
}
