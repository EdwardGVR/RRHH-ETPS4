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
    public partial class AddAplicante : Form
    {
        VacantesBLL vacantes = new VacantesBLL();
        int idVac;
        string codVac;
        Boolean emptyFields;

        public AddAplicante(int idVac, string codVac)
        {
            InitializeComponent();

            this.idVac = idVac;
            this.codVac = codVac;

            lblCodVac.Text = codVac;

            cmbTipo.DataSource = vacantes.getTiposAplicantes().Tables[0];
            cmbTipo.DisplayMember = "tipo_aplicante";
            cmbTipo.ValueMember = "id_tipo_aplicante";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres, apellidos, correo, direccion, telefono, dui;
            int idTipo;

            nombres = txtNombres.Text;
            apellidos = txtApellidos.Text;
            correo = txtEmail.Text;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            dui = txtDui.Text;
            idTipo = int.Parse(cmbTipo.SelectedValue.ToString());

            if (string.IsNullOrEmpty(nombres))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(apellidos)) {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(correo))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(direccion))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(telefono))
            {
                emptyFields = true;
            } else
            {
                emptyFields = false;
            }

            if (emptyFields)
            {
                MessageBox.Show("Debe llenar todos los campos");
            } else
            {
                if (vacantes.uniqueAplDui(dui))
                {
                    vacantes.insertAplicante(idVac, nombres, apellidos, correo, telefono, direccion, idTipo, dui);

                    Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                    ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
                    Close();
                } else
                {
                    MessageBox.Show("Ese DUI ya esta registrado");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
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
