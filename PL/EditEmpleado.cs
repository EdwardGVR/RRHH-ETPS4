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
    public partial class EditEmpleado : Form
    {
        EmpleadosBLL empleados = new EmpleadosBLL();
        DepartamentosBLL departamentos = new DepartamentosBLL();
        VacantesBLL vacantes = new VacantesBLL();

        string nombres, apellidos, dui, correo, telefono1, telefono2, direcion, puesto, departamento, salario, estadoContrato;
        int idEstadoContrato, idPuesto, idDepartamento;
        double salarioNumber;

        int idEmp;

        public EditEmpleado(int idEmp)
        {
            InitializeComponent();

            this.idEmp = idEmp;
            DataSet datosEmpleado = empleados.getDetallesEmpleado(idEmp);

            cmbDepartamento.DataSource = departamentos.getDepartamentos().Tables[0];
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "id_departamento";

            cmbEstadoContrato.DataSource = empleados.getEstadosContratos().Tables[0];
            cmbEstadoContrato.DisplayMember = "estado";
            cmbEstadoContrato.ValueMember = "id_estado_contrato";

            cmbPuesto.DataSource = departamentos.getPuestos().Tables[0];
            cmbPuesto.DisplayMember = "cargo_empleado";
            cmbPuesto.ValueMember = "id_cargo_empleado";

            nombres = datosEmpleado.Tables[0].Rows[0][0].ToString();
            apellidos = datosEmpleado.Tables[0].Rows[0][1].ToString();
            dui = datosEmpleado.Tables[0].Rows[0][2].ToString();
            correo = datosEmpleado.Tables[0].Rows[0][3].ToString();
            direcion = datosEmpleado.Tables[0].Rows[0][4].ToString();
            telefono1 = datosEmpleado.Tables[0].Rows[0][5].ToString();
            telefono2 = datosEmpleado.Tables[0].Rows[1][5].ToString();
            salario = datosEmpleado.Tables[0].Rows[0][6].ToString();
            estadoContrato = datosEmpleado.Tables[0].Rows[0][8].ToString();
            puesto = datosEmpleado.Tables[0].Rows[0][9].ToString();
            departamento = datosEmpleado.Tables[0].Rows[0][10].ToString();

            txtNombres.Text = nombres;
            txtApellidos.Text = apellidos;
            txtDUI.Text = dui;
            txtEmail.Text = correo;
            txtDireccion.Text = direcion;
            txtTelefono1.Text = telefono1;
            txtTelefono2.Text = telefono2;
            txtSalario.Text = salario;
            cmbEstadoContrato.Text = estadoContrato;
            cmbPuesto.Text = puesto;
            cmbDepartamento.Text = departamento;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetEmpleado(idEmp));
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetEmpleado(idEmp));
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string newDui = txtDUI.Text;
            Boolean sameDUI, duiGo;

            if (newDui.Equals(dui))
            {
                sameDUI = true;
                duiGo = true;
            }
            else
            {
                sameDUI = false;
                duiGo = false;
            }

            if (!sameDUI)
            {
                if (vacantes.uniqueAplDui(newDui))
                {
                    duiGo = true;
                }
                else
                {
                    duiGo = false;
                }
            }

            if (duiGo)
            {
                nombres = txtNombres.Text;
                apellidos = txtApellidos.Text;
                correo = txtEmail.Text;
                direcion = txtDireccion.Text;
                telefono1 = txtTelefono1.Text;
                telefono2 = txtTelefono2.Text;
                idEstadoContrato = int.Parse(cmbEstadoContrato.SelectedValue.ToString());
                idPuesto = int.Parse(cmbPuesto.SelectedValue.ToString());
                idDepartamento = int.Parse(cmbDepartamento.SelectedValue.ToString());
                salarioNumber = double.Parse(txtSalario.Value.ToString());

                empleados.updateEmpleado(nombres, apellidos, newDui, correo, telefono1, 
                    telefono2, direcion, idDepartamento, idPuesto, salarioNumber, idEstadoContrato, idEmp);

                Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                ControlUtils.abrirFormEnPanel(pnlContent, new DetEmpleado(idEmp));
                Close();
            }
            else
            {
                MessageBox.Show("El DUI que ha ingresado ya se encuentra registrado");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            empleados.deleteEmpleado(idEmp);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Empleados());
            Close();
        }
    }
}
