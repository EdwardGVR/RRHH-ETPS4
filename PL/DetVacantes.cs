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
    public partial class DetVacantes : Form
    {
        VacantesBLL oVacantesBLL = new VacantesBLL();
        string codVac, vacante, departamento, descripcion, fechaCreacion, estado, cupo;

        int idVac;
        
        public DetVacantes(string codVac)
        {
            oVacantesBLL = new VacantesBLL();
            InitializeComponent();

            dgvReq.DataSource = oVacantesBLL.getReqVac(codVac).Tables[0];
            DataSet datosVacante = oVacantesBLL.getDetVac(codVac);

            this.codVac = codVac;
            lblCodVac.Text = codVac;
            vacante = datosVacante.Tables[0].Rows[0][2].ToString();
            departamento = datosVacante.Tables[0].Rows[0][3].ToString();
            descripcion = datosVacante.Tables[0].Rows[0][5].ToString();
            fechaCreacion = datosVacante.Tables[0].Rows[0][6].ToString();
            estado = datosVacante.Tables[0].Rows[0][7].ToString();
            cupo = datosVacante.Tables[0].Rows[0][4].ToString();

            lblVacante.Text = vacante;
            lblDepartamento.Text = departamento;
            lblCupos.Text = cupo;
            txtDescripcion.Text = descripcion;
            lblFechaCreacion.Text = fechaCreacion;
            lblEstado.Text = estado;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Vacantes());
            Close();
        }

        private void dgvReq_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idReq = int.Parse(dgvReq.Rows[e.RowIndex].Cells[0].Value.ToString());

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetRequisito(idReq));
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new EditVacante(codVac));
            Close();
        }

        private void btnAgregarRequisito_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new AddRequisitoFromDetails(codVac));
            Close();
        }
    }
}
