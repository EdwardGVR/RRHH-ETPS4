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
    public partial class DetRequisito : Form
    {
        string requisito, detalles, prioridad, codVac;

        public DetRequisito(int idReq)
        {
            VacantesBLL oVacantesBLL = new VacantesBLL();
            InitializeComponent();
            DataSet datosRequisito = oVacantesBLL.getDetallesRequisito(idReq);

            codVac = datosRequisito.Tables[0].Rows[0][1].ToString();
            requisito = datosRequisito.Tables[0].Rows[0][3].ToString();
            detalles = datosRequisito.Tables[0].Rows[0][4].ToString();
            prioridad = datosRequisito.Tables[0].Rows[0][5].ToString();

            lblIdReq.Text = codVac + "-REQ" + idReq.ToString();
            lblRequisito.Text = requisito;
            txtDetalles.Text = detalles;
            lblPrioridad.Text = prioridad;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
            Close();
        }
    }
}
