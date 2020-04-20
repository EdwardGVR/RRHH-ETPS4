﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            ControlUtils.centrar(pnlTitulo, lblTitulo);
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            ControlUtils.centrar(pnlTitulo, lblTitulo);
        }
    }
}
