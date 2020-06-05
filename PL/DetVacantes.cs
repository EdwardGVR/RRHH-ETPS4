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
    public partial class DetVacantes : Form
    {
        public DetVacantes(string codVac)
        {
            InitializeComponent();
            lblCodVac.Text = codVac;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Vacantes());
            Close();
        }
    }
}
