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
    public partial class AddEmpleado : Form
    {
        DepartamentosBLL departamentos = new DepartamentosBLL();
        EmpleadosBLL empleados = new EmpleadosBLL();

        Boolean emptyFields = false;

        public AddEmpleado()
        {
            InitializeComponent();

            cmbDepartamento.DataSource = departamentos.getDepartamentos().Tables[0];
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "id_departamento";

            cmbPuesto.DataSource = departamentos.getPuestos().Tables[0];
            cmbPuesto.DisplayMember = "cargo_empleado";
            cmbPuesto.ValueMember = "id_cargo_empleado";

            txtFechaContrato.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            string nombres, apellidos, dui, email, direccion, tel1, tel2, fechaContrato;
            int idPuesto, idDpto;
            double salario;

            if (string.IsNullOrEmpty(txtNombres.Text)) {
                emptyFields = true;
            } else if (string.IsNullOrEmpty(txtApellidos.Text)) {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(txtDUI.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(txtTelefono1.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(txtTelefono2.Text))
            {
                emptyFields = true;
            }
            else if (txtSalario.Value == 0)
            {
                emptyFields = true;
            }
            else
            {
                emptyFields = false;
            }

            if (emptyFields)
            {
                MessageBox.Show("Debe llenar todos los campos");
            } else
            {
                nombres = txtNombres.Text;
                apellidos = txtApellidos.Text;
                dui = txtDUI.Text;
                email = txtEmail.Text;
                direccion = txtDireccion.Text;
                tel1 = txtTelefono1.Text;
                tel2 = txtTelefono2.Text;
                idPuesto = int.Parse(cmbPuesto.SelectedValue.ToString());
                idDpto = int.Parse(cmbDepartamento.SelectedValue.ToString());
                fechaContrato = txtFechaContrato.Text;
                salario = double.Parse(txtSalario.Text);

                empleados.insertEmpleado(nombres, apellidos, dui, email, tel1, tel2, direccion, idDpto, idPuesto, salario);

                Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                ControlUtils.abrirFormEnPanel(pnlContent, new Empleados());
                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Empleados());
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Empleados());
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
