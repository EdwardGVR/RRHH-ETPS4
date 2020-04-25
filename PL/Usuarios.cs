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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            UsuariosBLL oUsersBLL = new UsuariosBLL();
            InitializeComponent();
            dgvUsuarios.DataSource = oUsersBLL.getUsuarios().Tables[0];
        }
    }
}
