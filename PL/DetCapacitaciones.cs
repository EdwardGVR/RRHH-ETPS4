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
    public partial class DetCapacitaciones : Form
    {
        CapacitacionesBLL capacitaciones = new CapacitacionesBLL();
        EmpleadosBLL empleados = new EmpleadosBLL();
        int idCap;

        public DetCapacitaciones(int idCap)
        {
            InitializeComponent();

            string titulo, cupo, departamento, descripcion, estado, fechaCreacion;

            lblIdCap.Text = "IDCAP" + idCap;
            this.idCap = idCap;
            DataSet datosCapacitacion = capacitaciones.getDetallesCapacitaciones(idCap);

            dgvAsign.DataSource = capacitaciones.getAsignCapacitacion(idCap).Tables[0];

            titulo = datosCapacitacion.Tables[0].Rows[0][0].ToString();
            cupo = datosCapacitacion.Tables[0].Rows[0][1].ToString();
            descripcion = datosCapacitacion.Tables[0].Rows[0][2].ToString();
            fechaCreacion = datosCapacitacion.Tables[0].Rows[0][3].ToString();
            departamento = datosCapacitacion.Tables[0].Rows[0][4].ToString();
            estado = datosCapacitacion.Tables[0].Rows[0][5].ToString();

            lblTitulo.Text = titulo;
            lblCupo.Text = cupo;
            txtDescripcion.Text = descripcion;
            lblFechaCreacion.Text = fechaCreacion;
            lblDpto.Text = departamento;
            lblEstado.Text = estado;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Capacitaciones());
            Close();
        }

        private void dgvAsign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idAsign = int.Parse(dgvAsign.Rows[e.RowIndex].Cells[0].Value.ToString());

            //Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            //ControlUtils.abrirFormEnPanel(pnlContent, new DetCapacitaciones(idCap));
            //Close();
        }

        private void btnAgregarRequisito_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new AddAsignCapacitacion(idCap));
            Close();
        }
    }
}
