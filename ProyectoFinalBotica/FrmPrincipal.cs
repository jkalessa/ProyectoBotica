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
    public enum TipoUsuario 
    {
        Administrador,
        Farmaceutico,
        Cajero,
        Despachador
    };
    public partial class FrmPrincipal : Form
    {
        public static FrmPrincipal Instance;
        Form currentForm;
        public TipoUsuario TipoUsuarioActual;
        public FrmPrincipal()
        {
            InitializeComponent();
            if (Instance == null) Instance = this;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            OpenMenu();
            switch (TipoUsuarioActual)
            {
                case TipoUsuario.Administrador:
                    lblBienvenida.Text = "Bienvenido Administrador:";
                    break;
                case TipoUsuario.Farmaceutico:
                    lblBienvenida.Text = "Bienvenido Farmaceutico:";
                    break;
                case TipoUsuario.Cajero:
                    lblBienvenida.Text = "Bienvenido Cajero:";
                    break;
                case TipoUsuario.Despachador:
                    lblBienvenida.Text = "Bienvenido Despachador:";
                    break;
                default:
                    break;
            }
        }

        public void OpenForm(Form child) 
        {
            if (currentForm != null) currentForm.Close();
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(child);
            child.Show();
            currentForm = child;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OpenMenu();
        }

        public void OpenMenu()
        {
            highlightButton(btnMenu);
            switch (TipoUsuarioActual)
            {
                case TipoUsuario.Administrador:
                    OpenForm(new FrmMenu_Administrador());
                    break;
                case TipoUsuario.Farmaceutico:
                    OpenForm(new FrmMenu_Farmaceutico());
                    break;
                case TipoUsuario.Cajero:
                    OpenForm(new FrmMenu_Cajero());
                    break;
                case TipoUsuario.Despachador:
                    OpenForm(new FrmMenu_Despachador());
                    break;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            highlightButton(btnClientes);
            OpenForm(new FrmClientes());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            highlightButton(btnProductos);
            OpenForm(new FrmProductos());
        }

        private void btnReporteDeVentas_Click(object sender, EventArgs e)
        {
            highlightButton(btnReporteDeVentas);
            OpenForm(new FrmReporteVentas());
        }

        private void btnReporteDePedidos_Click(object sender, EventArgs e)
        {
            highlightButton(btnReporteDePedidos);
            OpenForm(new FrmReportePedidos());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void highlightButton(Button button)
        {
            btnMenu.UseVisualStyleBackColor = true;
            btnClientes.UseVisualStyleBackColor = true;
            btnProductos.UseVisualStyleBackColor = true;
            btnReporteDePedidos.UseVisualStyleBackColor = true;
            btnReporteDeVentas.UseVisualStyleBackColor = true;
            button.UseVisualStyleBackColor = false;
        }
    }
}
