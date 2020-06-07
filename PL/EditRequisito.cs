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
    public partial class EditRequisito : Form
    {
        string requisito, detalles, prioridad, codVac;
        int idReq;

        VacantesBLL oVacantesBLL = new VacantesBLL();

        public EditRequisito(int idReq)
        {
            InitializeComponent();

            DataSet datosRequisito = oVacantesBLL.getDetallesRequisito(idReq);
            cmbPrioridad.DataSource = oVacantesBLL.getPrioridades().Tables[0];
            cmbPrioridad.DisplayMember = "prioridad_requisito";

            this.idReq = idReq;
            codVac = datosRequisito.Tables[0].Rows[0][1].ToString();
            requisito = datosRequisito.Tables[0].Rows[0][3].ToString();
            detalles = datosRequisito.Tables[0].Rows[0][4].ToString();
            prioridad = datosRequisito.Tables[0].Rows[0][5].ToString();

            lblIdReq.Text = codVac + "-REQ" + idReq.ToString();
            txtRequisito.Text = requisito;
            txtDetalles.Text = detalles;
            cmbPrioridad.Text = prioridad;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idPrior;

            requisito = txtRequisito.Text;
            detalles = txtDetalles.Text;

            switch (cmbPrioridad.Text)
            {
                case "Alta":
                    idPrior = 1;
                    break;
                case "Media":
                    idPrior = 2;
                    break;
                case "Baja":
                    idPrior = 3;
                    break;
                default:
                    idPrior = 0;
                    break;
            }

            oVacantesBLL.updateRequisito(idReq, requisito, detalles, idPrior);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetRequisito(idReq));
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oVacantesBLL.deleteRequisito(idReq);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetRequisito(idReq));
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetRequisito(idReq));
            Close();
        }
    }
}
