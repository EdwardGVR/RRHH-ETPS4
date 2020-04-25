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
    }
}
