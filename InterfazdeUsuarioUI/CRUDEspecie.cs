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
    public partial class CRUDEspecie : Form
    {
        EspecieBL _especieBL = new EspecieBL();
        EspecieEN _especieEN = new EspecieEN();
        public CRUDEspecie()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            dgListarEspecie.DataSource = _especieBL.MostrarEspecie();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtIdEspecie.Text) || string.IsNullOrWhiteSpace(txtTipoEspecie.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el ID sea numérico (opcional, pero recomendable)
            if (!byte.TryParse(txtIdEspecie.Text, out byte idEspecie))
            {
                MessageBox.Show("El ID de la especie debe ser un número válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar datos
            _especieEN.Id = idEspecie;
            _especieEN.TipoEspecie = txtTipoEspecie.Text;
            _especieBL.GuardarEspecie(_especieEN);

            // Recargar y limpiar
            CargarGrid();
            txtIdEspecie.Clear();
            txtTipoEspecie.Clear();

            // Confirmación
            MessageBox.Show("Especie guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            _especieEN.Id = Convert.ToByte(txtIdEspecie.Text);
            _especieEN.TipoEspecie = txtTipoEspecie.Text;
            _especieBL.ModificarEspecie(_especieEN);
            CargarGrid();
            txtIdEspecie.Clear();
            txtTipoEspecie.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _especieEN.Id = Convert.ToByte(txtIdEspecie.Text);
            _especieEN.TipoEspecie = txtTipoEspecie.Text;
            _especieBL.EliminarEspecie(_especieEN);
            txtTipoEspecie.Clear();
            CargarGrid();
        }

        private void txtIdEspecie_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir tecla de control como Backspace
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Si no es número, mostrar mensaje y bloquear
                    MessageBox.Show("Solo se permiten números!!!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }
            }
        }

        private void txtTipoEspecie_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de control (como Backspace) y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras!!!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void dgListarEspecie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEspecie.Text = dgListarEspecie.CurrentRow.Cells["Id"].Value.ToString();
            txtTipoEspecie.Text = dgListarEspecie.CurrentRow.Cells["TipoEspecie"].Value.ToString();
        }
    }
}


