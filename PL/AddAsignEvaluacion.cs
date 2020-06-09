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
    public partial class AddAsignEvaluacion : Form
    {
        VacantesBLL vacantes = new VacantesBLL();
        EvaluacionesBLL evaluaciones = new EvaluacionesBLL();
        int idEval;

        public AddAsignEvaluacion(int idEval)
        {
            InitializeComponent();

            this.idEval = idEval;
            lblIdEval.Text = "IDEVAL" + idEval;

            cmbVacantes.DataSource = vacantes.getVacantes().Tables[0];
            cmbVacantes.DisplayMember = "Vacante";
            cmbVacantes.ValueMember = "ID";

            cmbAplicantes.DataSource = evaluaciones.getAplicantesByVac(int.Parse(cmbVacantes.SelectedValue.ToString())).Tables[0];
            cmbAplicantes.DisplayMember = "Aplicante";
            cmbAplicantes.ValueMember = "ID";
        }

        private void cmbVacantes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idVac = int.Parse(cmbVacantes.SelectedValue.ToString());

            cmbAplicantes.DataSource = evaluaciones.getAplicantesByVac(idVac).Tables[0];
            cmbAplicantes.DisplayMember = "Aplicante";
            cmbAplicantes.ValueMember = "ID";
        }

        private void btnGuardarOtro_Click(object sender, EventArgs e)
        {
            int idAplicante;
            string fechaEvaluacion, horaEvaluacion;

            fechaEvaluacion = dtpFechaEval.Value.ToShortDateString();
            horaEvaluacion = dtpHoraEval.Value.ToShortTimeString();

            if (string.IsNullOrEmpty(cmbAplicantes.Text)) 
            {
                MessageBox.Show("Asegurese de llenar los campos");
            } 
            else
            {
                idAplicante = int.Parse(cmbAplicantes.SelectedValue.ToString());

                if (evaluaciones.validateEvApl(idEval, idAplicante))
                {
                    evaluaciones.asignAplEval(idEval, idAplicante, fechaEvaluacion, horaEvaluacion);

                    Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                    ControlUtils.abrirFormEnPanel(pnlContent, new AddAsignEvaluacion(idEval));
                    Close();
                }
                else
                {
                    MessageBox.Show("Ese aplicante ya se encuentra asignado a esta evaluacion");
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idAplicante;
            string fechaEvaluacion, horaEvaluacion;

            fechaEvaluacion = dtpFechaEval.Value.ToShortDateString();
            horaEvaluacion = dtpHoraEval.Value.ToShortTimeString();

            if (string.IsNullOrEmpty(cmbAplicantes.Text))
            {
                MessageBox.Show("Asegurese de llenar los campos");
            }
            else 
            { 
                idAplicante = int.Parse(cmbAplicantes.SelectedValue.ToString());

                if (evaluaciones.validateEvApl(idEval, idAplicante))
                {
                    evaluaciones.asignAplEval(idEval, idAplicante, fechaEvaluacion, horaEvaluacion);

                    Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                    ControlUtils.abrirFormEnPanel(pnlContent, new DetEvaluacion(idEval));
                    Close();
                }
                else
                {
                    MessageBox.Show("Ese aplicante ya se encuentra asignado a esta evaluacion");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetEvaluacion(idEval));
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetEvaluacion(idEval));
            Close();
        }
    }
}
