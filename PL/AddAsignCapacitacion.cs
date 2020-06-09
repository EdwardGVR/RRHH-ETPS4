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
    public partial class AddAsignCapacitacion : Form
    {
        DepartamentosBLL departamentos = new DepartamentosBLL();
        EmpleadosBLL empleados = new EmpleadosBLL();
        CapacitacionesBLL capacitaciones = new CapacitacionesBLL();
        int idCap;

        public AddAsignCapacitacion(int idCap)
        {
            InitializeComponent();

            this.idCap = idCap;
            lblIdCap.Text = "IDCAP" + idCap;

            cmbDepartamentos.DataSource = departamentos.getDepartamentos().Tables[0];
            cmbDepartamentos.DisplayMember = "departamento";
            cmbDepartamentos.ValueMember = "id_departamento";

            cmbEmpleados.DataSource = empleados.getEmpleadosByDpto(int.Parse(cmbDepartamentos.SelectedValue.ToString())).Tables[0];
            cmbEmpleados.DisplayMember = "Empleado";
            cmbEmpleados.ValueMember = "ID";
        }

        private void cmbDepartamentos_SelectedValueChanged(object sender, EventArgs e)
        {
            //int idDpto = int.Parse(cmbDepartamentos.SelectedValue.ToString());

            //cmbEmpleados.DataSource = empleados.getEmpleadosByDpto(idDpto);
            //cmbEmpleados.DisplayMember = "Empleado";
            //cmbEmpleados.ValueMember = "id_empleado";
        }

        private void cmbDepartamentos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idDpto = int.Parse(cmbDepartamentos.SelectedValue.ToString());

            cmbEmpleados.DataSource = empleados.getEmpleadosByDpto(idDpto).Tables[0];
            cmbEmpleados.DisplayMember = "Empleado";
            cmbEmpleados.ValueMember = "ID";
        }

        private void btnGuardarOtro_Click(object sender, EventArgs e)
        {
            int idEmp;

            if (string.IsNullOrEmpty(cmbEmpleados.Text))
            {
                MessageBox.Show("Asegurese de llenar los campos");
            } else
            {
                idEmp = int.Parse(cmbEmpleados.SelectedValue.ToString());

                if (capacitaciones.validateCapEmp(idCap, idEmp))
                {
                    capacitaciones.asignarEmpCap(idCap, idEmp);

                    Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                    ControlUtils.abrirFormEnPanel(pnlContent, new AddAsignCapacitacion(idCap));
                    Close();
                } else
                {
                    MessageBox.Show("El empleado ya se encuentra asignado a esta capacitacion");
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idEmp;

            if (string.IsNullOrEmpty(cmbEmpleados.Text))
            {
                MessageBox.Show("Asegurese de llenar los campos");
            } else
            {
                idEmp = int.Parse(cmbEmpleados.SelectedValue.ToString());

                if (capacitaciones.validateCapEmp(idCap, idEmp))
                {
                    capacitaciones.asignarEmpCap(idCap, idEmp);

                    Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                    ControlUtils.abrirFormEnPanel(pnlContent, new DetCapacitaciones(idCap));
                    Close();
                }
                else
                {
                    MessageBox.Show("Ese empleado ya se encuentra asignado a esta capacitacion");
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetCapacitaciones(idCap));
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetCapacitaciones(idCap));
            Close();
        }
    }
}
