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
    public partial class CRUDRol : Form
    {
        RolBL _rolBL = new RolBL();
        RolEN _rolEN = new RolEN();
        public CRUDRol()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgListarRol.DataSource = _rolBL.MostrarRol();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del rol.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar datos
            _rolEN.TipoRol = txtNombreRol.Text;
            _rolBL.GuardarRol(_rolEN);

            // Recargar y limpiar
            CargarGrid();
            txtNombreRol.Clear();

            // Confirmación
            MessageBox.Show("Rol guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            _rolEN.Id = Convert.ToByte(nudNumeroRol.Value);
            _rolEN.TipoRol = txtNombreRol.Text;
            _rolBL.ModificarRol(_rolEN);
            txtNombreRol.Clear();
            CargarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _rolEN.Id = Convert.ToByte(nudNumeroRol.Value);
            _rolBL.EliminarRol(_rolEN);
            txtNombreRol.Clear();
            CargarGrid();
        }

        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de control (como Backspace) y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void dgListarRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombreRol.Text = dgListarRol.CurrentRow.Cells["Id"].Value.ToString();
        }
    }
}
