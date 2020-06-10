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
    public partial class DetEmpleado : Form
    {
        EmpleadosBLL empleados = new EmpleadosBLL();
        int idEmp;

        public DetEmpleado(int idEmpleado)
        {
            InitializeComponent();

            lblIdEmp.Text = "EMP" + idEmpleado;
            this.idEmp = idEmpleado;
            DataSet datosEmpleado = empleados.getDetallesEmpleado(idEmpleado);

            string nombres, apellidos, correo, direccion, telefono, telefono2, dui, puesto, departamento, fechaContrato, estadoContrato, salario;

            nombres = datosEmpleado.Tables[0].Rows[0][0].ToString();
            apellidos = datosEmpleado.Tables[0].Rows[0][1].ToString();
            dui = datosEmpleado.Tables[0].Rows[0][2].ToString();
            correo = datosEmpleado.Tables[0].Rows[0][3].ToString();
            direccion = datosEmpleado.Tables[0].Rows[0][4].ToString();
            telefono = datosEmpleado.Tables[0].Rows[0][5].ToString();
            telefono2 = datosEmpleado.Tables[0].Rows[1][5].ToString();
            salario = datosEmpleado.Tables[0].Rows[0][6].ToString();
            fechaContrato = datosEmpleado.Tables[0].Rows[0][7].ToString();
            estadoContrato = datosEmpleado.Tables[0].Rows[0][8].ToString();
            puesto = datosEmpleado.Tables[0].Rows[0][9].ToString();
            departamento = datosEmpleado.Tables[0].Rows[0][10].ToString();

            lblNombres.Text = nombres;
            lblApellidos.Text = apellidos;
            lblDUI.Text = dui;
            lblCorreo.Text = correo;
            lblTel1.Text = telefono;
            lblTel2.Text = telefono2;
            txtDireccion.Text = direccion;
            lblPuesto.Text = puesto;
            lblDepartamento.Text = departamento;
            lblSalario.Text = "$" + salario;
            lblFechaContrato.Text = fechaContrato;
            lblEstadoContrato.Text = estadoContrato;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Empleados());
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new EditEmpleado(idEmp));
            Close();
        }
    }
}
