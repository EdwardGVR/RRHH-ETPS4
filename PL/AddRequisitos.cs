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
    public partial class AddRequisitos : Form
    {
        VacantesBLL oVacantesBLL = new VacantesBLL();

        string codeVac;
        Boolean emptyFields;

        public AddRequisitos(string codVac)
        {
            InitializeComponent();

            codeVac = codVac;
            cmbReq.DataSource = oVacantesBLL.getPrioridades().Tables[0];
            cmbReq.DisplayMember = "prioridad_requisito";
            lblInfoVac.Text = "Agregando requisitos a la vacante: " + codVac;
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
            } else
            {
                emptyFields = false;
            }

            if (emptyFields)
            {
                MessageBox.Show("Debe llenar los campos");
            } else
            {
                // Guardar requisito y abrir otro formulario


                Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                ControlUtils.abrirFormEnPanel(pnlContent, new AddRequisitos(codeVac));
                Close();
            }
        }

        private void btnGuardarVacante_Click(object sender, EventArgs e)
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
                // Guardar requisito y regresar al listado de vacantes


                Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                ControlUtils.abrirFormEnPanel(pnlContent, new Vacantes());
                Close();
            }
        }

        private void btnCancelarVacante_Click(object sender, EventArgs e)
        {
            // Borrar vacante y sus requisitos y volver al listado de vacantes


            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Vacantes());
            Close();
        }
    }
}
