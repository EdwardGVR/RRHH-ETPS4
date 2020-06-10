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
    public partial class DetAsignEval : Form
    {
        EvaluacionesBLL evaluaciones = new EvaluacionesBLL();
        int idAsign, idEval;

        public DetAsignEval(int idAsign)
        {
            InitializeComponent();

            this.idAsign = idAsign;
            DataSet datosAsignacion = evaluaciones.getDetallesAsignEval(idAsign);

            string nombres, apellidos, correo, telefono, fechaEval, horaEval;

            idEval = int.Parse(datosAsignacion.Tables[0].Rows[0][0].ToString());

            lblIdAsign.Text = "IDEVAL" + idEval + "-IDASIGN" + idAsign;

            nombres = datosAsignacion.Tables[0].Rows[0][3].ToString();
            apellidos = datosAsignacion.Tables[0].Rows[0][4].ToString();
            correo = datosAsignacion.Tables[0].Rows[0][5].ToString();
            telefono = datosAsignacion.Tables[0].Rows[0][6].ToString();
            fechaEval = datosAsignacion.Tables[0].Rows[0][1].ToString();
            horaEval = datosAsignacion.Tables[0].Rows[0][2].ToString();

            lblNombres.Text = nombres;
            lblApellidos.Text = apellidos;
            lblCorreo.Text = correo;
            lblTel.Text = telefono;
            lblFechaEval.Text = fechaEval;
            lblHoraEval.Text = horaEval;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            evaluaciones.deleteAsignEval(idAsign);

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
