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
    public partial class DetAplicantes : Form
    {
        VacantesBLL vacantes = new VacantesBLL();
        int idApl;
        string codVac;

        public DetAplicantes(int idApl, string codVac)
        {
            InitializeComponent();

            this.idApl = idApl;
            this.codVac = codVac;
            lblIdApl.Text = "IDAPL" + idApl;

            DataSet datosAplicante = vacantes.getDetallesAplicante(idApl);
            string nombres, apellidos, correo, telefono, direccion, dui, tipoAplicante, resultApl, fechaApl;

            nombres = datosAplicante.Tables[0].Rows[0][0].ToString();
            apellidos = datosAplicante.Tables[0].Rows[0][1].ToString();
            correo = datosAplicante.Tables[0].Rows[0][2].ToString();
            telefono = datosAplicante.Tables[0].Rows[0][3].ToString();
            direccion = datosAplicante.Tables[0].Rows[0][4].ToString();
            dui = datosAplicante.Tables[0].Rows[0][5].ToString();
            tipoAplicante = datosAplicante.Tables[0].Rows[0][6].ToString();
            resultApl = datosAplicante.Tables[0].Rows[0][8].ToString();
            fechaApl = datosAplicante.Tables[0].Rows[0][7].ToString();

            lblNombres.Text = nombres;
            lblApellidos.Text = apellidos;
            lblCorreo.Text = correo;
            lblTel1.Text = telefono;
            txtDireccion.Text = direccion;
            lblDUI.Text = dui;
            lblTipo.Text = tipoAplicante;
            lblResult.Text = resultApl;
            lblFecha.Text = fechaApl;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new EditAplicante(idApl, codVac));
            Close();
        }
    }
}
