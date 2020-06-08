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
    public partial class AddUsuario : Form
    {
        UsuariosBLL usuarios = new UsuariosBLL();

        public AddUsuario()
        {
            InitializeComponent();

            cmbNivel.DataSource = usuarios.getNiveles().Tables[0];
            cmbNivel.DisplayMember = "nivel_usuario";
            cmbNivel.ValueMember = "id_nivel_usuario";

            txtFecha.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombres, apellidos, usuario, correo, password;
            int idNivel;

            nombres = txtNombres.Text;
            apellidos = txtApellidos.Text;
            usuario = txtUsuario.Text;
            correo = txtEmail.Text;
            password = txtPassword.Text;
            idNivel = int.Parse(cmbNivel.SelectedValue.ToString());

            usuarios.insertUsuario(nombres, apellidos, correo, usuario, password, idNivel);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Usuarios());
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Usuarios());
            Close();
        }
    }
}
