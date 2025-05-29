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
    public partial class InicioSecretaria : Form
    {
        public InicioSecretaria()
        {
            InitializeComponent();
        }

        private void ingresarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CRUDRegistro cRUDRegistro = new CRUDRegistro();
            cRUDRegistro.ShowDialog();
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
            CRUDMascota cRUDMascota = new CRUDMascota();
            cRUDMascota.ShowDialog();
        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archivosToolStripMenuItem.ForeColor = Color.Black;
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
    

