﻿using System;
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
    public partial class Capacitaciones : Form
    {
        CapacitacionesBLL oCapsBLL;
        public Capacitaciones()
        {
            oCapsBLL = new CapacitacionesBLL();
            InitializeComponent();
            dgvCapacitaciones.DataSource = oCapsBLL.getCapacitaciones().Tables[0];
        }

        private void btnAgregarCapacitacion_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new AddCapacitaciones());
            Close();
        }

        private void dgvCapacitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCap = int.Parse(dgvCapacitaciones.Rows[e.RowIndex].Cells[0].Value.ToString());

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new DetCapacitaciones(idCap));
            Close();
        }
    }
}
