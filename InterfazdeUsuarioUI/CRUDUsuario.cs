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
    public partial class CRUDUsuario : Form
    {
        UsuarioBL _usuarioBL = new UsuarioBL();
        UsuarioEN _usuarioEN = new UsuarioEN();
        public CRUDUsuario()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgListarUsuario.DataSource = _usuarioBL.MostrarUsuario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContra.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                cmbIdRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_usuarioBL.CorreoExiste(txtCorreo.Text))
            {
                MessageBox.Show("El correo ya está registrado. Por favor, use otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _usuarioEN.Nombre = txtNombre.Text;
            _usuarioEN.Apellido = txtApellido.Text;
            _usuarioEN.Correo = txtCorreo.Text;
            _usuarioEN.Contra = txtContra.Text;
            _usuarioEN.Telefono = int.Parse(txtTelefono.Text);
            _usuarioEN.IdRol = Convert.ToByte(cmbIdRol.SelectedValue);
            _usuarioBL.GuardarUsuario(_usuarioEN);
            CargarGrid();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtContra.Clear();
            txtTelefono.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContra.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                cmbIdRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de modificar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validar correo ya existente
            if (_usuarioBL.CorreoExiste(txtCorreo.Text, _usuarioEN.Id))
            {
                MessageBox.Show("El correo ya está registrado por otro usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar antes de modificar
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea modificar este usuario?",
                "Confirmar modificación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.OK)
            {
                // Proceder con la modificación
                _usuarioEN.Id = Convert.ToByte(txtId.Text);
                _usuarioEN.Nombre = txtNombre.Text;
                _usuarioEN.Apellido = txtApellido.Text;
                _usuarioEN.Correo = txtCorreo.Text;
                _usuarioEN.Contra = txtContra.Text;
                _usuarioEN.Telefono = int.Parse(txtTelefono.Text);
                _usuarioEN.IdRol = Convert.ToByte(cmbIdRol.SelectedValue);

                _usuarioBL.ModificarUsuario(_usuarioEN);

                // Limpiar campos
                txtId.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtCorreo.Clear();
                txtContra.Clear();
                txtTelefono.Clear();

                CargarGrid();

                // Confirmación de éxito
                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un usuario antes de eliminar.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCorreo.Text == UsuarioActual.Nombre.ToString())
            {
                MessageBox.Show("No se puede eliminar el usuario que está actualmente logueado.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.OK)
            {
                _usuarioEN.Id = Convert.ToByte(txtId.Text);
                _usuarioBL.EliminarUsuario(_usuarioEN);

                txtId.Clear();
                CargarGrid();

                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                // Si no hay texto, cargar todos los usuarios
                CargarGrid(); // Este método debe cargar todos los usuarios desde la BD
            }
            else
            {
                // Si hay texto, realizar búsqueda por nombre
                List<UsuarioEN> usuarios = UsuarioBL.BuscarUsuario(nombre);
                dgListarUsuario.DataSource = usuarios;
            }
        }


        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtBuscarNombre.Clear();
            CargarGrid();
        }

        private void CRUDUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eLANGELBDDataSet1.ListarRoles' Puede moverla o quitarla según sea necesario.
            this.listarRolesTableAdapter.Fill(this.eLANGELBDDataSet1.ListarRoles);

        }

        private void dgListarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgListarUsuario.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dgListarUsuario.CurrentRow.Cells["Nombre"].Value.ToString();
            txtApellido.Text = dgListarUsuario.CurrentRow.Cells["Apellido"].Value.ToString();
            txtCorreo.Text = dgListarUsuario.CurrentRow.Cells["Correo"].Value.ToString();
            txtContra.Text = dgListarUsuario.CurrentRow.Cells["Contra"].Value.ToString();
            txtTelefono.Text = dgListarUsuario.CurrentRow.Cells["Telefono"].Value.ToString();
            cmbIdRol.Text = dgListarUsuario.CurrentRow.Cells["IdRol"].Value.ToString();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir tecla de control como Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es número, mostrar mensaje y bloquear
                MessageBox.Show("Solo se permiten !!números!! en el teléfono.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }

            // Limitar a 8 caracteres
            if (char.IsDigit(e.KeyChar) && txtTelefono.Text.Length >= 8)
            {
                MessageBox.Show("El teléfono debe tener solo 8 dígitos.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de control (como Backspace) y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten !!letras!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (!txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo debe contener una ''@'' ", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true; // Cancela el cambio de foco hasta que se corrija
            }
        }


    }
}
