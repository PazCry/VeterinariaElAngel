using EntidaddeNegocioEN;
using LogicadeNegocioBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazdeUsuarioUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcorreo.Clear(); txtcontrasena.Focus();
            txtcontrasena.Clear();
            txtcorreo.Focus();

        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "")
            {
                txtcorreo.Text = "Ingrese Correo";
                txtcorreo.ForeColor = Color.Gray;
            }
        }

        private void txtcontrasena_Leave(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "")
            {
                txtcontrasena.Text = "Contraseña";
                txtcontrasena.ForeColor = Color.Gray;
            }
        }

        private void txtcorreo_Enter(object sender, EventArgs e)
        {
            if (txtcorreo.Text == "Ingrese Correo")
            {
                txtcorreo.Text = "";
                txtcorreo.ForeColor = Color.Black;
            }
        }

        private void txtcontrasena_Enter(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "Contraseña")
            {
                txtcontrasena.Text = "";
                txtcontrasena.ForeColor = Color.Black;
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            UsuarioEN usuarioEN = new UsuarioEN();
            UsuarioActual.Nombre = txtcorreo.Text.Trim();

            usuarioEN.Correo = txtcorreo.Text.Trim();
            usuarioEN.Contra = txtcontrasena.Text.Trim();

            // Validar campos vacíos
            if (string.IsNullOrEmpty(usuarioEN.Correo) || string.IsNullOrEmpty(usuarioEN.Contra))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar usuario desde la base de datos
            UsuarioBL usuariolBL = new UsuarioBL();
            int idRolObtenido = usuariolBL.VerificarUsuarioLogin(usuarioEN); // esto viene del procedimiento almacenado

            // Acceder según el rol recuperado
            if (idRolObtenido == 1)
            {
                InicioAdministrador inicioA = new InicioAdministrador();
                inicioA.Show();
                this.Hide();
            }
            else if (idRolObtenido == 2)
            {
                InicioVeterinaria inicioV = new InicioVeterinaria();
                inicioV.Show();
                this.Hide();
            }
            else if (idRolObtenido == 3)
            {
                InicioSecretaria inicioS = new InicioSecretaria();
                inicioS.Show();
                this.Hide();
            }
            else if (idRolObtenido == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcorreo_Validating(object sender, CancelEventArgs e)
        {
            if (!txtcorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo debe contener una ''@'' ", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Cancela el cambio de foco hasta que se corrija
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

