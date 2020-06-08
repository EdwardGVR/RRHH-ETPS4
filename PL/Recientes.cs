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
    public partial class Recientes : Form
    {
        public Recientes()
        {
            VacantesBLL oVacBLL = new VacantesBLL();
            CapacitacionesBLL oCapBLL = new CapacitacionesBLL();
            EvaluacionesBLL oEvalBll = new EvaluacionesBLL();
            InitializeComponent();
            dgvVacantesRecientes.DataSource = oVacBLL.getVacantes(5).Tables[0];
            dgvCapaRecientes.DataSource = oCapBLL.getCapacitaciones(5).Tables[0];
            dgvEvalRecientes.DataSource = oEvalBll.getEvaluaciones(5).Tables[0];
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

        private void Recientes_Resize(object sender, EventArgs e)
        {
            
        }

        private void dgvVacantesRecientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codVac = dgvVacantesRecientes.Rows[e.RowIndex].Cells[1].Value.ToString();

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
            Close();
        }

        private void dgvCapaRecientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCap = int.Parse(dgvCapaRecientes.Rows[e.RowIndex].Cells[0].Value.ToString());

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetCapacitaciones(idCap));
            Close();
        }

        private void dgvEvalRecientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idEval = int.Parse(dgvEvalRecientes.Rows[e.RowIndex].Cells[0].Value.ToString());

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetEvaluacion(idEval));
            Close();
        }
    }
}
