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
    public partial class Capacitaciones : Form
    {
        CapacitacionesBLL oCapsBLL;
        public Capacitaciones()
        {
            oCapsBLL = new CapacitacionesBLL();
            InitializeComponent();
            dgvCapacitaciones.DataSource = oCapsBLL.getCapacitaciones().Tables[0];
        }
    }
}
