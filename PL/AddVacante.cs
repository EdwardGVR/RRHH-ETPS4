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
    public partial class AddVacante : Form
    {
        DepartamentosBLL oDepartamentosBLL = new DepartamentosBLL();
        VacantesBLL oVacantesBLL = new VacantesBLL();

        public AddVacante()
        {
            InitializeComponent();
            cmbDepartamento.DataSource = oDepartamentosBLL.getNombresDepartamentos().Tables[0];
            cmbDepartamento.DisplayMember = "departamento";
            txtFecha.Text = DateTime.Now.ToString();
        }

        private void btnCancelarVacante_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Vacantes());
            Close();
        }

        private void btnGuardarVacante_Click(object sender, EventArgs e)
        {

            string vacante, departamento, descripcion;
            int cupo, idDepartamento;

            vacante = txtVacante.Text;
            departamento = cmbDepartamento.SelectedItem.ToString();
            descripcion = txtDescripcion.Text;
            cupo = Int32.Parse(txtCupo.Text);

            switch (departamento)
            {
                case "Desarrollo":
                    idDepartamento = 2;
                    break;
                case "Redes":
                    idDepartamento = 3;
                    break;
                case "Bases de datos":
                    idDepartamento = 4;
                    break;
                default:
                    idDepartamento = 0;
                    Console.WriteLine("Error");
                    break;
            }

            oVacantesBLL.insertVacante(vacante, idDepartamento, cupo, descripcion);

            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Vacantes());
            Close();
        }
    }
}