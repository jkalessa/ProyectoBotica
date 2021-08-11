using System;
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
    public partial class FrmMenu_Administrador : Form
    {
        public FrmMenu_Administrador()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.OpenForm(new FrmUsuarios());
        }

        private void btnIngresosEgresos_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.OpenForm(new FrmIngresosEgresos());
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.OpenForm(new FrmReclamos());
        }
    }
}
