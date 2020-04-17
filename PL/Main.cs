using System;
using System.Windows.Forms;

namespace RRHH.PL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ControlUtils.abrirFormEnPanel(pnlMain, new Login());
            Console.WriteLine("Constructor del Form Main");
        }

        private void Main_Load(object sender, EventArgs e)
        {
        } 
    }
}
