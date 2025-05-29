using System;
using System.Drawing;
using System.Windows.Forms;

namespace InterfazdeUsuarioUI
{
    public partial class InicioAdministrador : Form
    {
        public InicioAdministrador()
        {
            InitializeComponent();
        }
        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDCita cRUDCita = new CRUDCita();
            cRUDCita.ShowDialog();
        }
        private void ingresarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CRUDCliente cRUDCliente = new CRUDCliente();
            cRUDCliente.ShowDialog();
        }

        private void ingresarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CRUDEspecie cRUDEspecie = new CRUDEspecie();
            cRUDEspecie.ShowDialog();
        }

        private void ingresarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CRUDMascota cRUDMascota = new CRUDMascota();
            cRUDMascota.ShowDialog();
        }

        private void ingresarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CRUDRaza cRUDRaza = new CRUDRaza();
            cRUDRaza.ShowDialog();
        }

        private void ingresarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            CRUDRegistro cRUDRegistro = new CRUDRegistro();
            cRUDRegistro.ShowDialog();
        }

        private void ingresarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CRUDRol cRUDRol = new CRUDRol();
            cRUDRol.ShowDialog();
        }

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUDSexo cRUDSexo = new CRUDSexo();
            cRUDSexo.ShowDialog();
        }

        private void ingresarToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            CRUDUsuario cRUDUsuario = new CRUDUsuario();
            cRUDUsuario.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuToolStripMenuItem.ForeColor = Color.Black;
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {

            // Cerrar el formulario actual (por ejemplo, el formulario principal o dashboard)
            this.Hide();

            // Crear y mostrar el formulario de login
            Login loginForm = new Login();
            loginForm.Show();
        }

        
        

        
    }
}



