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
    public partial class DetAplicantes : Form
    {
        VacantesBLL vacantes = new VacantesBLL();
        int idApl;

        public DetAplicantes(int idApl)
        {
            InitializeComponent();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
