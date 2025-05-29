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
    public partial class CRUDRegistro : Form
    {
        ExpedienteBL _registroBL = new ExpedienteBL();
        ExpedienteEN _registroEN = new ExpedienteEN();
        public CRUDRegistro()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgListarRegistro.DataSource = _registroBL.MostrarExpe();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que no haya campos vacíos o sin seleccionar
            if (string.IsNullOrWhiteSpace(cbxIdCliente.Text) ||
                string.IsNullOrWhiteSpace(cbxIdMascota.Text) ||
                string.IsNullOrWhiteSpace(cbxEstado.Text) ||
                string.IsNullOrWhiteSpace(txtDescripciConsulta.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione todas las opciones.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar datos
            _registroEN.IdCliente = Convert.ToByte(cbxIdCliente.Text);
            _registroEN.IdMascota = Convert.ToByte(cbxIdMascota.Text);
            _registroEN.Estado = cbxEstado.Text;
            _registroEN.DescripcionConsulta = txtDescripciConsulta.Text;

            _registroBL.GuardarExpe(_registroEN);

            CargarGrid();

            // Limpiar campos
            txtId.Clear();
            txtDescripciConsulta.Clear();

            // Confirmación
            MessageBox.Show("Registro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(cbxEstado.Text) ||
                string.IsNullOrWhiteSpace(txtDescripciConsulta.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de modificar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir sin hacer nada
            }

            DialogResult confirmacion = MessageBox.Show(
        "¿Está seguro de que desea modificar este registro?",
        "Confirmar modificación",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question
    );

            if (confirmacion == DialogResult.OK)
            {
                // Proceder con la modificación
                _registroEN.Id = Convert.ToByte(txtId.Text);
                _registroEN.IdCliente = Convert.ToByte(cbxIdCliente.Text);
                _registroEN.IdMascota = Convert.ToByte(cbxIdMascota.Text);
                _registroEN.Estado = cbxEstado.Text;
                _registroEN.DescripcionConsulta = txtDescripciConsulta.Text;

                _registroBL.ModificarExpe(_registroEN);

                // Limpiar campos y recargar
                txtDescripciConsulta.Clear();
                txtId.Clear();
                CargarGrid();

                // Confirmación de éxito
                MessageBox.Show("Registro modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar que el campo Id esté lleno
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar un registro antes de eliminar.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación de eliminación
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este registro?",
                "Confirmar eliminación",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.OK)
            {
                // Proceder con la eliminación
                _registroEN.Id = Convert.ToByte(txtId.Text);
                _registroBL.EliminarExpe(_registroEN);

                // Limpiar campos y recargar
                txtDescripciConsulta.Clear();
                txtId.Clear();
                CargarGrid();

                // Confirmación de éxito
                MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Id = txtBuscar.Text;
            List<ExpedienteEN> registros = ExpedienteBL.BuscarExpe(Id);
            dgListarRegistro.DataSource = registros;
        }

        private void btnReinicar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CRUDRegistro_Load(object sender, EventArgs e)
        {       // este debe coincidir con Cliente.Id

            CargarGrid(); // Asegura que se cargue el DataGrid al abrir
        }

        private void dgListarRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgListarRegistro.CurrentRow.Cells["Id"].Value.ToString();
            cbxIdCliente.Text = dgListarRegistro.CurrentRow.Cells["IdCliente"].Value.ToString();
            cbxIdMascota.Text = dgListarRegistro.CurrentRow.Cells["IdMascota"].Value.ToString();
            cbxEstado.Text = dgListarRegistro.CurrentRow.Cells["Estado"].Value.ToString();
            txtDescripciConsulta.Text = dgListarRegistro.CurrentRow.Cells["DescripcionConsulta"].Value.ToString();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
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
}
