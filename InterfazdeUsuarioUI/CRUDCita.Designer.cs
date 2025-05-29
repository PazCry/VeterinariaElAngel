namespace InterfazdeUsuarioUI
{
    partial class CRUDCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdRegistro = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFechaCita = new System.Windows.Forms.Label();
            this.lblFechaAtencio = new System.Windows.Forms.Label();
            this.dgListarCita = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.txtIdCita = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtIdRegistro = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnMascota = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarCita)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(50, 101);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(87, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Num Cita:";
            // 
            // lblIdRegistro
            // 
            this.lblIdRegistro.AutoSize = true;
            this.lblIdRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblIdRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRegistro.ForeColor = System.Drawing.Color.Black;
            this.lblIdRegistro.Location = new System.Drawing.Point(275, 97);
            this.lblIdRegistro.Name = "lblIdRegistro";
            this.lblIdRegistro.Size = new System.Drawing.Size(123, 20);
            this.lblIdRegistro.TabIndex = 1;
            this.lblIdRegistro.Text = "Num Registro:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(546, 101);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(48, 20);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            // 
            // lblFechaCita
            // 
            this.lblFechaCita.AutoSize = true;
            this.lblFechaCita.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCita.ForeColor = System.Drawing.Color.Black;
            this.lblFechaCita.Location = new System.Drawing.Point(50, 145);
            this.lblFechaCita.Name = "lblFechaCita";
            this.lblFechaCita.Size = new System.Drawing.Size(96, 20);
            this.lblFechaCita.TabIndex = 3;
            this.lblFechaCita.Text = "Fecha Cita";
            // 
            // lblFechaAtencio
            // 
            this.lblFechaAtencio.AutoSize = true;
            this.lblFechaAtencio.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaAtencio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAtencio.ForeColor = System.Drawing.Color.Black;
            this.lblFechaAtencio.Location = new System.Drawing.Point(50, 223);
            this.lblFechaAtencio.Name = "lblFechaAtencio";
            this.lblFechaAtencio.Size = new System.Drawing.Size(140, 20);
            this.lblFechaAtencio.TabIndex = 4;
            this.lblFechaAtencio.Text = "Fecha Atencion ";
            // 
            // dgListarCita
            // 
            this.dgListarCita.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgListarCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarCita.Location = new System.Drawing.Point(120, 488);
            this.dgListarCita.Name = "dgListarCita";
            this.dgListarCita.RowHeadersWidth = 123;
            this.dgListarCita.Size = new System.Drawing.Size(762, 150);
            this.dgListarCita.TabIndex = 5;
            this.dgListarCita.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarCita_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Bisque;
            this.btnGuardar.Location = new System.Drawing.Point(327, 256);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 32);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Bisque;
            this.btnModificar.Location = new System.Drawing.Point(439, 257);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 31);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Bisque;
            this.btnEliminar.Location = new System.Drawing.Point(550, 257);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 32);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpHora
            // 
            this.dtpHora.CalendarForeColor = System.Drawing.Color.Bisque;
            this.dtpHora.CalendarMonthBackground = System.Drawing.Color.DarkSlateGray;
            this.dtpHora.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpHora.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtpHora.CalendarTrailingForeColor = System.Drawing.Color.Bisque;
            this.dtpHora.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(616, 101);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(65, 22);
            this.dtpHora.TabIndex = 9;
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.CalendarForeColor = System.Drawing.Color.Bisque;
            this.dtpFechaCita.CalendarMonthBackground = System.Drawing.Color.DarkSlateGray;
            this.dtpFechaCita.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpFechaCita.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtpFechaCita.CalendarTrailingForeColor = System.Drawing.Color.Bisque;
            this.dtpFechaCita.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dtpFechaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCita.Location = new System.Drawing.Point(54, 179);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaCita.TabIndex = 10;
            // 
            // dtpFechaAtencion
            // 
            this.dtpFechaAtencion.CalendarForeColor = System.Drawing.Color.Bisque;
            this.dtpFechaAtencion.CalendarMonthBackground = System.Drawing.Color.DarkSlateGray;
            this.dtpFechaAtencion.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpFechaAtencion.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtpFechaAtencion.CalendarTrailingForeColor = System.Drawing.Color.Bisque;
            this.dtpFechaAtencion.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dtpFechaAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAtencion.Location = new System.Drawing.Point(54, 256);
            this.dtpFechaAtencion.Name = "dtpFechaAtencion";
            this.dtpFechaAtencion.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaAtencion.TabIndex = 11;
            // 
            // txtIdCita
            // 
            this.txtIdCita.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtIdCita.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtIdCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCita.ForeColor = System.Drawing.Color.Bisque;
            this.txtIdCita.Location = new System.Drawing.Point(143, 97);
            this.txtIdCita.Name = "txtIdCita";
            this.txtIdCita.Size = new System.Drawing.Size(87, 22);
            this.txtIdCita.TabIndex = 12;
            this.txtIdCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCita_KeyPress);
            // 
            // txtIdRegistro
            // 
            this.txtIdRegistro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtIdRegistro.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtIdRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRegistro.ForeColor = System.Drawing.Color.Bisque;
            this.txtIdRegistro.Location = new System.Drawing.Point(404, 99);
            this.txtIdRegistro.Name = "txtIdRegistro";
            this.txtIdRegistro.Size = new System.Drawing.Size(87, 22);
            this.txtIdRegistro.TabIndex = 13;
            this.txtIdRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdRegistro_KeyPress);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Bisque;
            this.btnCliente.Location = new System.Drawing.Point(549, 146);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(86, 29);
            this.btnCliente.TabIndex = 14;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnMascota
            // 
            this.btnMascota.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascota.ForeColor = System.Drawing.Color.Bisque;
            this.btnMascota.Location = new System.Drawing.Point(437, 145);
            this.btnMascota.Name = "btnMascota";
            this.btnMascota.Size = new System.Drawing.Size(91, 30);
            this.btnMascota.TabIndex = 15;
            this.btnMascota.Text = "Mascota";
            this.btnMascota.UseVisualStyleBackColor = false;
            this.btnMascota.Click += new System.EventHandler(this.btnMascota_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.Color.Bisque;
            this.btnRegistro.Location = new System.Drawing.Point(320, 145);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(102, 30);
            this.btnRegistro.TabIndex = 16;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Bisque;
            this.txtBuscar.Location = new System.Drawing.Point(86, 409);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 22);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Bisque;
            this.btnBuscar.Location = new System.Drawing.Point(69, 451);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 31);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.Bisque;
            this.btnReiniciar.Location = new System.Drawing.Point(165, 451);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(74, 31);
            this.btnReiniciar.TabIndex = 19;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBuscar.Location = new System.Drawing.Point(65, 371);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(174, 20);
            this.lblBuscar.TabIndex = 20;
            this.lblBuscar.Text = "Buscar(Por nombre):";
            // 
            // CRUDCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::InterfazdeUsuarioUI.Properties.Resources.Cita;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 681);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnMascota);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.txtIdRegistro);
            this.Controls.Add(this.txtIdCita);
            this.Controls.Add(this.dtpFechaAtencion);
            this.Controls.Add(this.dtpFechaCita);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgListarCita);
            this.Controls.Add(this.lblFechaAtencio);
            this.Controls.Add(this.lblFechaCita);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblIdRegistro);
            this.Controls.Add(this.lblId);
            this.Name = "CRUDCita";
            this.Text = "CRUDCita";
            this.Load += new System.EventHandler(this.CRUDCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListarCita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdRegistro;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFechaCita;
        private System.Windows.Forms.Label lblFechaAtencio;
        private System.Windows.Forms.DataGridView dgListarCita;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.DateTimePicker dtpFechaAtencion;
        private System.Windows.Forms.TextBox txtIdCita;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtIdRegistro;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnMascota;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblBuscar;
    }
}