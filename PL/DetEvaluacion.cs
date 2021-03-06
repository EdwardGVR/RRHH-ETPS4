﻿using System;
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
    public partial class DetEvaluacion : Form
    {
        EvaluacionesBLL evaluaciones = new EvaluacionesBLL();
        int idEval;

        public DetEvaluacion(int idEval)
        {
            InitializeComponent();

            this.idEval = idEval;
            lblIdEval.Text = "IDEVAL" + idEval;

            dgvAsign.DataSource = evaluaciones.getAsignEvalApl(idEval).Tables[0];

            string evaluacion, objetivo, tipoEval, maxScore, fechaCreacion;

            DataSet datosEvaluacion = evaluaciones.getDetallesEvaluacion(idEval);

            evaluacion = datosEvaluacion.Tables[0].Rows[0][0].ToString();
            objetivo = datosEvaluacion.Tables[0].Rows[0][1].ToString();
            maxScore = datosEvaluacion.Tables[0].Rows[0][2].ToString();
            fechaCreacion = datosEvaluacion.Tables[0].Rows[0][3].ToString();
            tipoEval = datosEvaluacion.Tables[0].Rows[0][4].ToString();

            lblEvaluacion.Text = evaluacion;
            txtObjetivo.Text = objetivo;
            lblMaxScore.Text = maxScore;
            lblFechaCreacion.Text = fechaCreacion;
            lblTipoEval.Text = tipoEval;
        }

        private void btnAsignarAplicantes_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new AddAsignEvaluacion(idEval));
            Close();
        }

        private void dgvAsign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idAsign = int.Parse(dgvAsign.Rows[e.RowIndex].Cells[0].Value.ToString());

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetAsignEval(idAsign));
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new EditEvaluacion(idEval));
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Evaluaciones());
            Close();
        }
    }
}
