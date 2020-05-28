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
    public partial class AddVacante : Form
    {
        DepartamentosBLL oDepartamentosBLL = new DepartamentosBLL();
        VacantesBLL oVacantesBLL = new VacantesBLL();

        public AddVacante()
        {
            InitializeComponent();
            cmbDepartamento.DataSource = oDepartamentosBLL.getNombresDepartamentos().Tables[0];
            cmbDepartamento.DisplayMember = "departamento";
            txtFecha.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnCancelarVacante_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Vacantes());
            Close();
        }

        private void btnGuardarVacante_Click(object sender, EventArgs e)
        {
            string vacante, departamento, descripcion, codVac, abvDpto;
            int cupo, idDepartamento, corrVac;

            vacante = txtVacante.Text;
            departamento = cmbDepartamento.Text;
            descripcion = txtDescripcion.Text;
            cupo = int.Parse(txtCupo.Text);
            
            idDepartamento = oDepartamentosBLL.getDptoID(departamento);
            abvDpto = oDepartamentosBLL.getDptoAbv(idDepartamento);
            corrVac = oVacantesBLL.getCorrVac(idDepartamento);
            codVac = oVacantesBLL.setVacCode(abvDpto, corrVac);

            oVacantesBLL.insertVacante(codVac, vacante, idDepartamento, cupo, descripcion);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new AddRequisitos(codVac));
            Close();
        }
    }
}
