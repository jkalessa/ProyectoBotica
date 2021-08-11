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
    public partial class FrmMenu_Despachador : Form
    {
        public FrmMenu_Despachador()
        {
            InitializeComponent();
        }

        private void btnBuscarComprobante_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.OpenForm(new FrmComprobantes());
        }
    }
}
