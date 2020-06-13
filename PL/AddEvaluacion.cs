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
    public partial class AddEvaluacion : Form
    {
        EvaluacionesBLL evaluaciones = new EvaluacionesBLL();

        Boolean emptyFields = false;

        public AddEvaluacion()
        {
            InitializeComponent();

            cmbTipoEval.DataSource = evaluaciones.getTiposEvaluaciones().Tables[0];
            cmbTipoEval.DisplayMember = "tipo_evaluacion";
            cmbTipoEval.ValueMember = "id_tipo_evaluacion";

            txtFecha.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string evaluacion, objetivo;
            int maxScore, idTipo;

            if (string.IsNullOrEmpty(txtEvaluacion.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(txtObjetivo.Text))
            {
                emptyFields = true;
            }
            else if (txtMaxScore.Value == 0)
            {
                emptyFields = true;
            }
            else
            {
                emptyFields = false;
            }

            if (emptyFields)
            {
                MessageBox.Show("Debe llenar todos los campos, el puntaje maximo no puede ser cero");
            } else
            {
                evaluacion = txtEvaluacion.Text;
                objetivo = txtObjetivo.Text;
                maxScore = int.Parse(txtMaxScore.Value.ToString());
                idTipo = int.Parse(cmbTipoEval.SelectedValue.ToString());

                evaluaciones.insertEvaluacion(evaluacion, idTipo, objetivo, maxScore);

                Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                ControlUtils.abrirFormEnPanel(pnlContent, new Evaluaciones());
                Close();
            }
        }

        private void btnCancelarVacante_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Evaluaciones());
            Close();
        }
    }
}
