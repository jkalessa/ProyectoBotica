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
    public partial class FrmLogin : Form
    {
        private FrmPrincipal m_Principal;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            m_Principal = new FrmPrincipal();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "123") 
            {
                MessageBox.Show("Contraseña incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (txtUsername.Text)
            {
                case "admin":
                    m_Principal.TipoUsuarioActual = TipoUsuario.Administrador; break;
                case "farma":
                    m_Principal.TipoUsuarioActual = TipoUsuario.Farmaceutico; break;
                case "caja":
                    m_Principal.TipoUsuarioActual = TipoUsuario.Cajero; break;
                case "despa":
                    m_Principal.TipoUsuarioActual = TipoUsuario.Despachador; break;
                default:
                    m_Principal.Dispose();
                    MessageBox.Show("Usuario no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            Hide();
            m_Principal.ShowDialog();

            txtUsername.Clear();

            txtPassword.Clear();

            txtUsername.Focus();

            Show();
        }

    }
}
