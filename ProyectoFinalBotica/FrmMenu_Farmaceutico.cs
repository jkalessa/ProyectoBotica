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
    public partial class FrmMenu_Farmaceutico : Form
    {
        public FrmMenu_Farmaceutico()
        {
            InitializeComponent();
        }

        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.OpenForm(new FrmGenerarTicket());
        }
    }
}
