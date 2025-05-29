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
    public partial class CRUDMascota : Form
    {

        MascotaBL _mascotaBL = new MascotaBL();
        MascotaEN _mascotaEN = new MascotaEN();
        public CRUDMascota()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgListarMascota.DataSource = _mascotaBL.MostrarMascota();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtColor.Text) ||
                string.IsNullOrWhiteSpace(txtFechaNaci.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _mascotaBL.GuardarMascota(_mascotaEN);
            CargarGrid();
            txtNombre.Clear();
            txtColor.Clear();
            txtFechaNaci.Clear();
        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _mascotaEN.Nombre = txtNombre.Text;
            _mascotaEN.Color = txtColor.Text;
            _mascotaEN.FechaNaci = Convert.ToDateTime(txtFechaNaci.Text);
            _mascotaEN.IdSexo = Convert.ToByte(cbxIdSexo.SelectedValue);
            _mascotaEN.IdRaza = Convert.ToByte(cbxIdRaza.SelectedValue);
            _mascotaEN.IdEspecie = Convert.ToByte(cbxEspecie.SelectedValue);
            _mascotaBL.ModificarMascota(_mascotaEN);
            CargarGrid();
            txtNombre.Clear();
            txtColor.Clear();
            txtFechaNaci.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _mascotaEN.Nombre = txtNombre.Text;
            _mascotaBL.EliminarMascota(_mascotaEN);
            txtNombre.Clear();
            txtColor.Clear();
            txtFechaNaci.Clear();
            CargarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;
            List<MascotaEN> mascotas = MascotaBL.BuscarMascota(nombre);
            dgListarMascota.DataSource = mascotas;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarGrid();

        }

        private void dgListarMascota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgListarMascota.SelectedRows.Count > 0)
            {
                txtNombre.Text = dgListarMascota.CurrentRow.Cells["Nombre"].Value.ToString();
                txtColor.Text = dgListarMascota.CurrentRow.Cells["Color"].Value.ToString();
                txtFechaNaci.Text = dgListarMascota.CurrentRow.Cells["FechaNaci"].Value.ToString();
                cbxIdSexo.Text = dgListarMascota.CurrentRow.Cells["Sexo"].Value.ToString();
                cbxIdRaza.Text = dgListarMascota.CurrentRow.Cells["Raza"].Value.ToString();
                cbxEspecie.Text = dgListarMascota.CurrentRow.Cells["Especie"].Value.ToString();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de control (como Backspace) y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de control (como Backspace) y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtFechaNaci_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                // Si no es número ni guion, mostrar mensaje y bloquear
                MessageBox.Show("Solo se permiten números y guiones (ej: 17-05-2025).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de control (como Backspace) y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras!!!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
    }
}


