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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            abrirFormEnPanel(new Login());
            Console.WriteLine("lodsfs");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abrirFormEnPanel(object formChild)
        {
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);
            Form fc = formChild as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(fc);
            this.pnlMain.Tag = fc;
            fc.Show();
        }
    }
}
