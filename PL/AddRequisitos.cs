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
    public partial class AddRequisitos : Form
    {
        VacantesBLL oVacantesBLL = new VacantesBLL();
        public AddRequisitos()
        {
            InitializeComponent();
            cmbReq1.DataSource = oVacantesBLL.getPrioridades().Tables[0];
            cmbReq1.DisplayMember = "prioridad_requisito";
            cmbReq1.SelectedItem = "-- Elegir prioridad --";
        }


    }
}
