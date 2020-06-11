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
    public partial class EditEvaluacion : Form
    {
        EvaluacionesBLL evaluaciones = new EvaluacionesBLL();

        int idEval;

        string evaluacion, tipoEvaluacion, objetivo, maxScore;
        int idTipo, maxScoreNumber;

        public EditEvaluacion(int idEval)
        {
            InitializeComponent();

            this.idEval = idEval;

            DataSet datosEvaluacion = evaluaciones.getDetallesEvaluacion(idEval);

            cmbTipoEval.DataSource = evaluaciones.getTiposEvaluaciones().Tables[0];
            cmbTipoEval.DisplayMember = "tipo_evaluacion";
            cmbTipoEval.ValueMember = "id_tipo_evaluacion";

            evaluacion = datosEvaluacion.Tables[0].Rows[0][0].ToString();
            objetivo = datosEvaluacion.Tables[0].Rows[0][1].ToString();
            maxScore = datosEvaluacion.Tables[0].Rows[0][2].ToString();
            tipoEvaluacion = datosEvaluacion.Tables[0].Rows[0][4].ToString();

            txtEvaluacion.Text = evaluacion;
            txtMaxScore.Value = int.Parse(maxScore);
            txtObjetivo.Text = objetivo;
            cmbTipoEval.Text = tipoEvaluacion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            evaluacion = txtEvaluacion.Text;
            idTipo = int.Parse(cmbTipoEval.SelectedValue.ToString());
            maxScoreNumber = int.Parse(txtMaxScore.Value.ToString());
            objetivo = txtObjetivo.Text;

            evaluaciones.updateEvaluacion(idEval, evaluacion, objetivo, idTipo, maxScoreNumber);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetEvaluacion(idEval));
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            evaluaciones.deleteEvaluacion(idEval);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Evaluaciones());
            Close();
        }

        private void btnCancelarVacante_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetEvaluacion(idEval));
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetEvaluacion(idEval));
            Close();
        }
    }
}
