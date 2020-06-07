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
    public partial class AddRequisitoFromDetails : Form
    {
        VacantesBLL oVacantesBLL = new VacantesBLL();

        Boolean emptyFields;
        string codVac;

        public AddRequisitoFromDetails(string codVac)
        {
            InitializeComponent();
            this.codVac = codVac;
            lblCodVac.Text = codVac;

            cmbReq.DataSource = oVacantesBLL.getPrioridades().Tables[0];
            cmbReq.DisplayMember = "prioridad_requisito";
        }

        private void btnGuardarOtro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReq.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(txtDetReq.Text))
            {
                emptyFields = true;
            }
            else
            {
                emptyFields = false;
            }

            if (emptyFields)
            {
                MessageBox.Show("Debe llenar los campos");
            }
            else
            {
                // Guardar requisito y abrir otro formulario
                int idVac = oVacantesBLL.getIdVac(codVac);
                string req = txtReq.Text;
                string det = txtDetReq.Text;
                int idPrior;

                switch (cmbReq.Text)
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

                oVacantesBLL.insertRequisito(idVac, codVac, req, det, idPrior);

                Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                ControlUtils.abrirFormEnPanel(pnlContent, new AddRequisitoFromDetails(codVac));
                Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReq.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(txtDetReq.Text))
            {
                emptyFields = true;
            }
            else
            {
                emptyFields = false;
            }

            if (emptyFields)
            {
                MessageBox.Show("Debe llenar los campos");
            }
            else
            {
                // Guardar requisito y regresar a detalles de la vacante
                int idVac = oVacantesBLL.getIdVac(codVac);
                string req = txtReq.Text;
                string det = txtDetReq.Text;
                int idPrior;

                switch (cmbReq.Text)
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

                oVacantesBLL.insertRequisito(idVac, codVac, req, det, idPrior);

                Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
            Close();
        }
    }
}
