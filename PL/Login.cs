using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Home home = new Home();
            home.MdiParent = ParentForm;
            home.Location = new System.Drawing.Point(0, 0);
            home.Dock = DockStyle.Fill;
            home.Show();
            Close();
        }
    }
}
