﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRHH.BLL;

namespace RRHH.PL
{
    public partial class AddCapacitaciones : Form
    {
        CapacitacionesBLL capacitaciones = new CapacitacionesBLL();
        DepartamentosBLL departamentos = new DepartamentosBLL();

        bool emptyFields = false;

        public AddCapacitaciones()
        {
            InitializeComponent();
            cmbDepartamento.DataSource = departamentos.getDepartamentos().Tables[0];
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "id_departamento";

            txtFechaCreacion.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo, descripcion;
            int cupo, idDpto;

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                emptyFields = true;
            } else if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                emptyFields = true;
            } else if (txtCupo.Value == 0)
            {
                emptyFields = true;
            } else
            {
                emptyFields = false;
            }

            if (emptyFields)
            {
                MessageBox.Show("Debe llenar todos los campo, el cupo no puede ser cero");
            } else { 
                titulo = txtTitulo.Text;
                descripcion = txtDescripcion.Text;
                cupo = int.Parse(txtCupo.Value.ToString());
                idDpto = int.Parse(cmbDepartamento.SelectedValue.ToString());

                capacitaciones.insertCapacitacion(titulo, descripcion, cupo, idDpto);

                Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                ControlUtils.abrirFormEnPanel(pnlContent, new Capacitaciones());
                Close();
            }
        }

        private void btnGuardaryAsignar_Click(object sender, EventArgs e)
        {
            string titulo, descripcion;
            int cupo, idDpto;

            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                emptyFields = true;
            }
            else if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                emptyFields = true;
            }
            else if (txtCupo.Value == 0)
            {
                emptyFields = true;
            }
            else
            {
                emptyFields = false;
            }

            if (emptyFields)
            {
                MessageBox.Show("Debe llenar todos los campo, el cupo no puede ser cero");
            } else
            {
                titulo = txtTitulo.Text;
                descripcion = txtDescripcion.Text;
                cupo = int.Parse(txtCupo.Value.ToString());
                idDpto = int.Parse(cmbDepartamento.SelectedValue.ToString());

                capacitaciones.insertCapacitacion(titulo, descripcion, cupo, idDpto);

                Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
                ControlUtils.abrirFormEnPanel(pnlContent, new Capacitaciones());
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Capacitaciones());
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control pnlContent = ParentForm.Controls.Find("pnlContent", true)[0];
            ControlUtils.abrirFormEnPanel(pnlContent, new Capacitaciones());
            Close();
        }

    }
}
