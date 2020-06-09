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

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new AddUsuario());
            Close();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idUser = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetUsuario(idUser));
            Close();
        }
    }
}
