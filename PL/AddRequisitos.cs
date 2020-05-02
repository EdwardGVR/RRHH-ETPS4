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
        public AddRequisitos(int idVacante = 0)
        {
            InitializeComponent();
            cmbReq.DataSource = oVacantesBLL.getPrioridades().Tables[0];
            cmbReq.DisplayMember = "prioridad_requisito";
            cmbReq.SelectedItem = "-- Elegir prioridad --";
        }


    }
}
