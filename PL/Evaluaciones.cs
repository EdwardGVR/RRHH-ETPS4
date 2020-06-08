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
    public partial class Evaluaciones : Form
    {
        public Evaluaciones()
        {
            EvaluacionesBLL oEvalBLL = new EvaluacionesBLL();
            InitializeComponent();
            dgvEvaluaciones.DataSource = oEvalBLL.getEvaluaciones().Tables[0];
        }

        private void btnAgregarEvaluacion_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new AddEvaluacion());
            Close();
        }
    }
}
