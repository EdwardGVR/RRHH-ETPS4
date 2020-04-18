using System;
using System.Windows.Forms;

namespace RRHH.PL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Console.WriteLine("Constructor del Form Main");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Dock = DockStyle.Fill;
            login.Show();
        }
    }
}
