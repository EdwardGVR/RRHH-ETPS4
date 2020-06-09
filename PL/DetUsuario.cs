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
    public partial class DetUsuario : Form
    {
        UsuariosBLL usuarios = new UsuariosBLL();
        int idUser;

        public DetUsuario(int idUser)
        {
            InitializeComponent();

            this.idUser = idUser;
            lblIdUser.Text = "IDUSER" + idUser;

            DataSet datosUsuario = usuarios.getDetallesUsuario(idUser);

            lblNombres.Text = datosUsuario.Tables[0].Rows[0][0].ToString();
            lblApellidos.Text = datosUsuario.Tables[0].Rows[0][1].ToString();
            lblCorreo.Text = datosUsuario.Tables[0].Rows[0][2].ToString();
            lblUsuario.Text = datosUsuario.Tables[0].Rows[0][3].ToString();
            lblFecha.Text = datosUsuario.Tables[0].Rows[0][4].ToString();
            lblEstado.Text = datosUsuario.Tables[0].Rows[0][5].ToString();
            lblNivel.Text = datosUsuario.Tables[0].Rows[0][6].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Usuarios());
            Close();
        }


    }
}
