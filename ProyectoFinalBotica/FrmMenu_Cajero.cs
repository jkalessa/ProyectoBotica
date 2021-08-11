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
    public partial class FrmMenu_Cajero : Form
    {
        public FrmMenu_Cajero()
        {
            InitializeComponent();
        }

        private void btnGenerarComprobante_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.OpenForm(new FrmGenerarComprobante());
        }
    }
}
