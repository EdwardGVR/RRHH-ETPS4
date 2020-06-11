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
    public partial class Home : Form
    {
        UsuariosBLL usuarios = new UsuariosBLL();

        public Home(string usuario)
        {
            InitializeComponent();
            ControlUtils.centrar(pnlTitulo, lblTitulo);

            DataSet datosUsuario = usuarios.getDetallesUsuario(usuarios.getUserIdByUser(usuario));

            string nombres = datosUsuario.Tables[0].Rows[0][0].ToString();
            string apellidos = datosUsuario.Tables[0].Rows[0][1].ToString();
            string nivel = datosUsuario.Tables[0].Rows[0][6].ToString();

            lblNombres.Text = nombres;
            lblApellidos.Text = apellidos;
            lblNivelUser.Text = nivel;
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            ControlUtils.centrar(pnlTitulo, lblTitulo);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Recientes());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Recientes());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Empleados());
        }

        private void btnVacantes_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Vacantes());
        }

        private void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Capacitaciones());
        }

        private void btnEvaluaciones_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Evaluaciones());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ControlUtils.abrirFormEnPanel(pnlContent, new Usuarios());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ControlUtils.openMdi(ParentForm, new Login());
            Close();
        }
    }
}
