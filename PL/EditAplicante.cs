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
    public partial class EditAplicante : Form
    {
        VacantesBLL vacantes = new VacantesBLL();
        int idApl;
        string codVac;
        
        string nombres, apellidos, correo, dui, telefono, direccion, resultado, tipo;

        public EditAplicante(int idApl, string codVac)
        {
            InitializeComponent();

            this.idApl = idApl;
            this.codVac = codVac;
            lblIdApl.Text = "IDAPL" + idApl;

            cmbTipo.DataSource = vacantes.getTiposAplicantes().Tables[0];
            cmbTipo.DisplayMember = "tipo_aplicante";
            cmbTipo.ValueMember = "id_tipo_aplicante";

            cmbResultado.DataSource = vacantes.getResultadosAplicaciones().Tables[0];
            cmbResultado.DisplayMember = "resultado_aplicacion";
            cmbResultado.ValueMember = "id_resultado_aplicacion";


            DataSet datosAplicante = vacantes.getDetallesAplicante(idApl);

            nombres = datosAplicante.Tables[0].Rows[0][0].ToString();
            apellidos = datosAplicante.Tables[0].Rows[0][1].ToString();
            correo = datosAplicante.Tables[0].Rows[0][2].ToString();
            telefono = datosAplicante.Tables[0].Rows[0][3].ToString();
            direccion = datosAplicante.Tables[0].Rows[0][4].ToString();
            dui = datosAplicante.Tables[0].Rows[0][5].ToString();
            tipo = datosAplicante.Tables[0].Rows[0][6].ToString();
            resultado = datosAplicante.Tables[0].Rows[0][8].ToString();

            txtNombres.Text = nombres;
            txtApellidos.Text = apellidos;
            txtCorreo.Text = correo;
            txtDUI.Text = dui;
            txtTelefono.Text = telefono;
            txtDireccion.Text = direccion;
            cmbResultado.Text = resultado;
            cmbTipo.Text = tipo;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetAplicantes(idApl, codVac));
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetAplicantes(idApl, codVac));
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string newDui = txtDUI.Text;
            int idResultado, idTipo;
            Boolean sameDUI, duiGo;

            if (newDui.Equals(dui))
            {
                sameDUI = true;
                duiGo = true;
            } else
            {
                sameDUI = false;
                duiGo = false;
            }

            if (!sameDUI)
            {
                if (vacantes.uniqueAplDui(newDui))
                {
                    duiGo = true;
                } else
                {
                    duiGo = false;
                }
            }

            if (duiGo)
            {
                nombres = txtNombres.Text;
                apellidos = txtApellidos.Text;
                correo = txtCorreo.Text;
                telefono = txtTelefono.Text;
                direccion = txtDireccion.Text;
                idResultado = int.Parse(cmbResultado.SelectedValue.ToString());
                idTipo = int.Parse(cmbTipo.SelectedValue.ToString());

                vacantes.updateAplicante(idApl, nombres, apellidos, newDui, correo, direccion, telefono, idTipo, idResultado);

                Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                ControlUtils.abrirFormEnPanel(pnlContent, new DetAplicantes(idApl, codVac));
                Close();

            } else
            {
                MessageBox.Show("El DUI que ha ingresado ya se encuentra registrado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            vacantes.deleteAplicante(idApl);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetVacantes(codVac));
            Close();
        }
    }
}
