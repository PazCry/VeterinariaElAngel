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
    public partial class CRUDRaza : Form
    {
        RazaBL _razaBL = new RazaBL();
        RazaEN _razaEN = new RazaEN();
        public CRUDRaza()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgListarRaza.DataSource = _razaBL.MostrarRaza();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que el campo TipoRaza no esté vacío
            if (string.IsNullOrWhiteSpace(txtTipoRaza.Text))
            {
                MessageBox.Show("Por favor, ingrese el tipo de raza.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar datos
            _razaEN.TipoRaza = txtTipoRaza.Text;
            _razaBL.GuardarRaza(_razaEN);

            // Recargar y limpiar
            CargarGrid();
            txtId.Clear();
            txtTipoRaza.Clear();

            // Confirmación
            MessageBox.Show("Raza guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            _razaEN.Id = Convert.ToByte(txtId.Text);
            _razaEN.TipoRaza = txtTipoRaza.Text;
            _razaBL.ModificarRaza(_razaEN);
            CargarGrid();
            txtId.Clear();
            txtTipoRaza.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _razaEN.Id = Convert.ToByte(txtId.Text);
            _razaBL.EliminarRaza(_razaEN);
            txtId.Clear();
            txtTipoRaza.Clear();
            CargarGrid();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir tecla de control como Backspace
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Si no es número, mostrar mensaje y bloquear
                    MessageBox.Show("Solo se permiten números!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }
            }
        }

        private void txtTipoRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de control (como Backspace) y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten !!letras!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void dgListarRaza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgListarRaza.CurrentRow.Cells["Id"].Value.ToString();
            txtTipoRaza.Text = dgListarRaza.CurrentRow.Cells["TipoRaza"].Value.ToString();
        }
    }
}
