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
    public partial class EditCapacitacion : Form
    {
        CapacitacionesBLL capacitaciones = new CapacitacionesBLL();
        DepartamentosBLL departamentos = new DepartamentosBLL();

        int idCap;

        string titulo, descripcion, cupo, departamento, estado;

        int idEstado, idDpto, cupoNumber;

        public EditCapacitacion(int idCap)
        {
            InitializeComponent();

            this.idCap = idCap;

            cmbDepartamento.DataSource = departamentos.getDepartamentos().Tables[0];
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "id_departamento";

            cmbEstado.DataSource = capacitaciones.getEstadosCapacitaciones().Tables[0];
            cmbEstado.DisplayMember = "estado";
            cmbEstado.ValueMember = "id_estado_capacitacion";

            DataSet datosCapacitacion = capacitaciones.getDetallesCapacitaciones(idCap);

            titulo = datosCapacitacion.Tables[0].Rows[0][0].ToString();
            cupo = datosCapacitacion.Tables[0].Rows[0][1].ToString();
            descripcion = datosCapacitacion.Tables[0].Rows[0][2].ToString();
            departamento = datosCapacitacion.Tables[0].Rows[0][4].ToString();
            estado = datosCapacitacion.Tables[0].Rows[0][5].ToString();

            txtTitulo.Text = titulo;
            txtCupo.Value = int.Parse(cupo);
            txtDescripcion.Text = descripcion;
            cmbDepartamento.Text = departamento;
            cmbEstado.Text = estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            titulo = txtTitulo.Text;
            descripcion = txtDescripcion.Text;
            idEstado = int.Parse(cmbEstado.SelectedValue.ToString());
            idDpto = int.Parse(cmbDepartamento.SelectedValue.ToString());
            cupoNumber = int.Parse(txtCupo.Value.ToString());

            capacitaciones.updateCapacitacion(idCap, titulo, descripcion, cupoNumber, idDpto, idEstado);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetCapacitaciones(idCap));
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            capacitaciones.deleteCapacitacion(idCap);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Capacitaciones());
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetCapacitaciones(idCap));
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetCapacitaciones(idCap));
            Close();
        }
    }
}
