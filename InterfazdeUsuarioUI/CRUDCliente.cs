using EntidaddeNegocioEN;
using LogicadeNegocioBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazdeUsuarioUI
{
    public partial class CRUDCliente : Form
    {
        ClienteBL _clienteBL = new ClienteBL();
        ClienteEN _clienteEN = new ClienteEN();
        public CRUDCliente()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgListarCliente.DataSource = _clienteBL.ListarCliente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el teléfono sea un número válido
            if (!long.TryParse(txtTelefono.Text, out long telefono))
            {
                MessageBox.Show("El número de teléfono ingresado no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construir la entidad ClienteEN con los datos del formulario
            ClienteEN cliente = new ClienteEN
            {
                Id = Convert.ToByte(txtId.Text), // solo si Id es necesario
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = telefono,
                FechaCreacion = DateTime.Now
            };

            // Llamar a la lógica de negocio
            int resultado = _clienteBL.GuardarCliente(cliente);

            if (resultado == -1)
            {
                MessageBox.Show("El número de teléfono ya existe, use otro por favor!!.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (resultado == 1)
            {
                MessageBox.Show("Cliente guardado correctamente!!.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡¡Error al guardar el cliente!!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Recargar el grid y limpiar los campos solo si se guardó correctamente
            CargarGrid();
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            _clienteEN.Id = Convert.ToByte(txtId.Text);
            _clienteEN.Nombre = txtNombre.Text;
            _clienteEN.Apellido = txtApellido.Text;
            _clienteEN.Telefono = int.Parse(txtTelefono.Text);
            _clienteBL.ModificarCliente(_clienteEN);
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            CargarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _clienteEN.Id = Convert.ToByte(txtId.Text);
            _clienteBL.EliminarCliente(_clienteEN);
       
            CargarGrid();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
   
            string nombre = txtBuscar.Text; 
            List<ClienteEN> clientes = ClienteBL.BuscarCliente(nombre); 
            dgListarCliente.DataSource = clientes;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgListarCliente.DataSource = _clienteBL.ListarCliente();
            txtBuscar.Clear();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir tecla de control como Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es número, mostrar mensaje y bloquear
                MessageBox.Show("Solo se permiten números!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
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

   
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control como Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números en el teléfono.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }

            // Validar longitud máxima (8 dígitos)
            if (char.IsDigit(e.KeyChar) && txtTelefono.Text.Length >= 8)
            {
                MessageBox.Show("El teléfono debe tener solo 8 dígitos.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }

        }

        

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de control (como Backspace) y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de control (como Backspace) y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void dgListarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgListarCliente.CurrentRow.Cells["Id"].Value.ToString();
            txtNombre.Text = dgListarCliente.CurrentRow.Cells["Nombre"].Value.ToString();
            txtTelefono.Text = dgListarCliente.CurrentRow.Cells["Telefono"].Value.ToString();
            txtApellido.Text = dgListarCliente.CurrentRow.Cells["Apellido"].Value.ToString();
        }
    }
}


      



    

