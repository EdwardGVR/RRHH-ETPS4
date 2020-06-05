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
    public partial class Vacantes : Form
    {
        VacantesBLL oVacantesBLL;

        public Vacantes()
        {
            oVacantesBLL = new VacantesBLL();
            InitializeComponent();
            dgvVacantes.DataSource = oVacantesBLL.getVacantes().Tables[0];
        }

        private void btnAgregarVacante_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new AddVacante());
            Close();
        }

        private void dgvVacantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codVac = dgvVacantes.Rows[e.RowIndex].Cells[1].Value.ToString();

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
            Close();
        }
    }
}
