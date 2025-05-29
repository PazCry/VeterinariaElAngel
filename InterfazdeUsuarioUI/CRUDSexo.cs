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
    public partial class CRUDSexo : Form
    {
        GeneroBL _sexoBL = new GeneroBL();
        GeneroEN _sexoEN = new GeneroEN();
        public CRUDSexo()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgListarSexo.DataSource = _sexoBL.MostrarGenero();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtTipoSexo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar datos
            _sexoEN.TipoGen = txtId.Text;
            _sexoBL.GuardarGenero(_sexoEN);

            // Recargar y limpiar
            CargarGrid();
            txtId.Clear();
            txtTipoSexo.Clear();

            // Confirmación
            MessageBox.Show("Sexo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            _sexoEN.Id = Convert.ToByte(txtId.Text);
            _sexoEN.TipoGen = txtTipoSexo.Text;
            _sexoBL.ModificarGenero(_sexoEN);
            CargarGrid();
            txtId.Clear();
            txtTipoSexo.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _sexoEN.Id = Convert.ToByte(txtId.Text);
            _sexoBL.EliminarGenero(_sexoEN);
            txtId.Clear();
            txtTipoSexo.Clear();
            CargarGrid();
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir tecla de control como Backspace
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Si no es número, mostrar mensaje y bloquear
                    MessageBox.Show("Solo se permiten números!! .", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }
            }
        }
        private void txtTipoSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de control (como Backspace) y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void dgListarSexo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgListarSexo.CurrentRow.Cells["Id"].Value.ToString();
            txtTipoSexo.Text = dgListarSexo.CurrentRow.Cells["TipoSexo"].Value.ToString();
        }
    } 
}
