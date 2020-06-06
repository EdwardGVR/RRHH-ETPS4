using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRHH.BLL;

namespace RRHH.PL
{
    public partial class EditVacante : Form
    {
        DepartamentosBLL oDepartamentosBLL;
        VacantesBLL oVacantesBLL;
        string codVac, vacante, departamento, descripcion, fechaCreacion, estado, cupo;

        public EditVacante(string codVac)
        {
            InitializeComponent();
            oVacantesBLL = new VacantesBLL();
            oDepartamentosBLL = new DepartamentosBLL();

            DataSet datosVacante = oVacantesBLL.getDetVac(codVac);

            cmbDepartamento.DataSource = oDepartamentosBLL.getNombresDepartamentos().Tables[0];
            cmbDepartamento.DisplayMember = "departamento";
            //cmbDepartamento.SelectedIndex = 0;

            cmbEstado.DataSource = oVacantesBLL.getEstadosVacantes().Tables[0];
            cmbEstado.DisplayMember = "estado";
            cmbEstado.ValueMember = "id_estado_vacante";
            //cmbEstado.SelectedIndex = 0;

            lblCodVac.Text = codVac;
            this.codVac = codVac;
            vacante = datosVacante.Tables[0].Rows[0][2].ToString();
            departamento = datosVacante.Tables[0].Rows[0][3].ToString();
            descripcion = datosVacante.Tables[0].Rows[0][5].ToString();
            estado = datosVacante.Tables[0].Rows[0][7].ToString();
            cupo = datosVacante.Tables[0].Rows[0][4].ToString();

            txtVacante.Text = vacante;
            txtDescripcion.Text = descripcion;
            txtCupo.Value = int.Parse(cupo);
            cmbDepartamento.Text = departamento;
            cmbEstado.Text = estado;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string newCodVac, newDpto, abvDpto;
            int idEstado, idDpto, cupoNumber, corrVac;

            vacante = txtVacante.Text;
            newDpto = cmbDepartamento.Text;
            idDpto = oDepartamentosBLL.getDptoID(newDpto);
            descripcion = txtDescripcion.Text;
            idEstado = int.Parse(cmbEstado.SelectedValue.ToString());
            cupoNumber = decimal.ToInt32(txtCupo.Value);

            if (departamento.Equals(newDpto))
            {
                newCodVac = codVac;
            } else
            {
                corrVac = oVacantesBLL.getCorrVac(idDpto);
                abvDpto = oDepartamentosBLL.getDptoAbv(idDpto);
                newCodVac = oVacantesBLL.setVacCode(abvDpto, corrVac);
            }

            oVacantesBLL.updateVacante(codVac, newCodVac, vacante, descripcion, idDpto, idEstado, cupoNumber);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(newCodVac));
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            oVacantesBLL.deleteVacante(codVac);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Vacantes());
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
            Close();
        }
    }
}
