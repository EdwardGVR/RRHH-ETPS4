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
    public partial class DetAsignCap : Form
    {
        CapacitacionesBLL capacitaciones = new CapacitacionesBLL();
        int idAsign, idCap;

        public DetAsignCap(int idAsign)
        {
            InitializeComponent();

            DataSet datosAsign = capacitaciones.getDetallesAsignCap(idAsign);

            string nombres, apellidos, correo, dui, tel1, tel2, dpto, fecha;

            idCap = int.Parse(datosAsign.Tables[0].Rows[0][1].ToString());

            this.idAsign = idAsign;
            lblIdAsign.Text = "IDCAP" + idCap + "-IDASIGN" + idAsign;

            nombres = datosAsign.Tables[0].Rows[0][2].ToString();
            apellidos = datosAsign.Tables[0].Rows[0][3].ToString();
            correo = datosAsign.Tables[0].Rows[0][4].ToString();
            dui = datosAsign.Tables[0].Rows[0][5].ToString();
            tel1 = datosAsign.Tables[0].Rows[0][6].ToString();
            tel2 = datosAsign.Tables[0].Rows[1][6].ToString();
            dpto = datosAsign.Tables[0].Rows[0][7].ToString();
            fecha = datosAsign.Tables[0].Rows[0][8].ToString();

            lblNombres.Text = nombres;
            lblApellidos.Text = apellidos;
            lblCorreo.Text = correo;
            lblDUI.Text = dui;
            lblTel1.Text = tel1;
            lblTel2.Text = tel2;
            lblDepartamento.Text = dpto;
            lblFecha.Text = fecha;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            capacitaciones.deleteAsignCap(idAsign);

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
