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
    public partial class CRUDCita : Form
    {
        CitaBL _citaBL = new CitaBL();
        CitaEN _citaEN = new CitaEN();
        public CRUDCita()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgListarCita.DataSource = _citaBL.MostrarCita();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtIdCita.Text) || string.IsNullOrWhiteSpace(txtIdRegistro.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que ambos campos sean numéricos válidos
            if (!byte.TryParse(txtIdCita.Text, out byte idCita))
            {
                MessageBox.Show("El ID de la cita debe ser un número válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!byte.TryParse(txtIdRegistro.Text, out byte idRegistro))
            {
                MessageBox.Show("El ID del registro debe ser un número válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar datos
            _citaEN.Id = idCita;
            _citaEN.IdExpe = idRegistro;
            _citaEN.Hora = dtpHora.Value.TimeOfDay;
            _citaEN.FechaCita = dtpFechaCita.Value;
             

            _citaBL.GuardarCita(_citaEN);

            // Recargar y limpiar
            CargarGrid();
            txtIdCita.Clear();
            txtIdRegistro.Clear();

            // Confirmación
            MessageBox.Show("Cita guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            _citaEN.Id = Convert.ToByte(txtIdCita.Text);
            _citaEN.IdExpe = Convert.ToByte(txtIdRegistro.Text);
            _citaEN.Hora = dtpHora.Value.TimeOfDay;
            _citaEN.FechaCita = dtpFechaCita.Value;
            
            _citaBL.ModificarCita(_citaEN);
            CargarGrid();
            txtIdCita.Clear();
            txtIdRegistro.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            _citaEN.Id = Convert.ToByte(txtIdCita.Text);
            _citaBL.EliminarCita(_citaEN);
            txtIdCita.Clear();
            CargarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;
            List<CitaEN> cita = CitaBL.BuscarCita(nombre);
            dgListarCita.DataSource = cita;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            CRUDCliente cRUDCliente = new CRUDCliente();
            cRUDCliente.ShowDialog();
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            CRUDMascota cRUDMascota = new CRUDMascota();
            cRUDMascota.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            CRUDRegistro cRUDRegistro = new CRUDRegistro();
            cRUDRegistro.ShowDialog();
        }

        private void CRUDCita_Load(object sender, EventArgs e)
        {

        }

        private void dgListarCita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtIdCita.Text = dgListarCita.CurrentRow.Cells["IdCita"].Value.ToString();
            txtIdRegistro.Text = dgListarCita.CurrentRow.Cells["IdRegistro"].Value.ToString();
            dtpFechaCita.Text = dgListarCita.CurrentRow.Cells["FechaCita"].Value.ToString();
            dtpFechaAtencion.Text = dgListarCita.CurrentRow.Cells["FechaAtencion"].Value.ToString();
            dtpHora.Text = dgListarCita.CurrentRow.Cells["Hora"].Value.ToString();




        }

        private void txtIdCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Permitir tecla de control como Backspace
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Si no es número, mostrar mensaje y bloquear
                    MessageBox.Show("Solo se permiten números!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }
            }
        }

        private void txtIdRegistro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, tecla de control (como Backspace) y espacios
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten !!letras!!.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
    }
}
