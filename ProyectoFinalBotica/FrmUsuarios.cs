﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBotica
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.OpenMenu();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.OpenForm(new FrmNuevo_Usuario());
        }
    }
}
