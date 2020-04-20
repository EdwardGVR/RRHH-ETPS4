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
using RRHH.DAL;

namespace RRHH.PL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            ControlUtils.centrar(pnlLogin, gbLogin);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string clave = txtClave.Text;

            LoginBLL oLoginBLL = new LoginBLL();
            if (oLoginBLL.validar(user, clave))
            {
                ControlUtils.openMdi(ParentForm, new Home());
                Close();
            }
            else {
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtUsuario.Focus();
            }
        }
    }
}
