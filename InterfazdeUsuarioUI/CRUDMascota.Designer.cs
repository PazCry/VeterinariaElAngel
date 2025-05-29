namespace InterfazdeUsuarioUI
{
    partial class CRUDMascota
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblFechaNaci = new System.Windows.Forms.Label();
            this.lblIdSexo = new System.Windows.Forms.Label();
            this.lblIdRaza = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgListarMascota = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtFechaNaci = new System.Windows.Forms.TextBox();
            this.cbxIdSexo = new System.Windows.Forms.ComboBox();
            this.cbxIdRaza = new System.Windows.Forms.ComboBox();
            this.cbxEspecie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(68, 104);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color";
            // 
            // lblFechaNaci
            // 
            this.lblFechaNaci.AutoSize = true;
            this.lblFechaNaci.Location = new System.Drawing.Point(55, 168);
            this.lblFechaNaci.Name = "lblFechaNaci";
            this.lblFechaNaci.Size = new System.Drawing.Size(62, 13);
            this.lblFechaNaci.TabIndex = 2;
            this.lblFechaNaci.Text = "Fecha Naci";
            // 
            // lblIdSexo
            // 
            this.lblIdSexo.AutoSize = true;
            this.lblIdSexo.Location = new System.Drawing.Point(275, 49);
            this.lblIdSexo.Name = "lblIdSexo";
            this.lblIdSexo.Size = new System.Drawing.Size(42, 13);
            this.lblIdSexo.TabIndex = 3;
            this.lblIdSexo.Text = "Genero";
            // 
            // lblIdRaza
            // 
            this.lblIdRaza.AutoSize = true;
            this.lblIdRaza.Location = new System.Drawing.Point(275, 102);
            this.lblIdRaza.Name = "lblIdRaza";
            this.lblIdRaza.Size = new System.Drawing.Size(32, 13);
            this.lblIdRaza.TabIndex = 4;
            this.lblIdRaza.Text = "Raza";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(501, 92);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(45, 13);
            this.lblEspecie.TabIndex = 5;
            this.lblEspecie.Text = "Especie";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(740, 92);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(740, 149);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(740, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgListarMascota
            // 
            this.dgListarMascota.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgListarMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarMascota.Location = new System.Drawing.Point(96, 356);
            this.dgListarMascota.Name = "dgListarMascota";
            this.dgListarMascota.RowHeadersWidth = 123;
            this.dgListarMascota.Size = new System.Drawing.Size(664, 150);
            this.dgListarMascota.TabIndex = 9;
            this.dgListarMascota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarMascota_CellContentClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(122, 101);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 11;
            this.txtColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColor_KeyPress);
            // 
            // txtFechaNaci
            // 
            this.txtFechaNaci.Location = new System.Drawing.Point(135, 161);
            this.txtFechaNaci.Name = "txtFechaNaci";
            this.txtFechaNaci.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNaci.TabIndex = 12;
            this.txtFechaNaci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFechaNaci_KeyPress);
            // 
            // cbxIdSexo
            // 
            this.cbxIdSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdSexo.FormattingEnabled = true;
            this.cbxIdSexo.Location = new System.Drawing.Point(337, 49);
            this.cbxIdSexo.Name = "cbxIdSexo";
            this.cbxIdSexo.Size = new System.Drawing.Size(121, 21);
            this.cbxIdSexo.TabIndex = 13;
            // 
            // cbxIdRaza
            // 
            this.cbxIdRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdRaza.FormattingEnabled = true;
            this.cbxIdRaza.Location = new System.Drawing.Point(337, 97);
            this.cbxIdRaza.Name = "cbxIdRaza";
            this.cbxIdRaza.Size = new System.Drawing.Size(121, 21);
            this.cbxIdRaza.TabIndex = 14;
            // 
            // cbxEspecie
            // 
            this.cbxEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecie.FormattingEnabled = true;
            this.cbxEspecie.Location = new System.Drawing.Point(566, 89);
            this.cbxEspecie.Name = "cbxEspecie";
            this.cbxEspecie.Size = new System.Drawing.Size(121, 21);
            this.cbxEspecie.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar(Por nombre):";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(155, 253);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(96, 304);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(201, 304);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 19;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // CRUDMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfazdeUsuarioUI.Properties.Resources.Mascota;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 538);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEspecie);
            this.Controls.Add(this.cbxIdRaza);
            this.Controls.Add(this.cbxIdSexo);
            this.Controls.Add(this.txtFechaNaci);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgListarMascota);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblIdRaza);
            this.Controls.Add(this.lblIdSexo);
            this.Controls.Add(this.lblFechaNaci);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblNombre);
            this.Name = "CRUDMascota";
            this.Text = "CRUDMascota";
            ((System.ComponentModel.ISupportInitialize)(this.dgListarMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblFechaNaci;
        private System.Windows.Forms.Label lblIdSexo;
        private System.Windows.Forms.Label lblIdRaza;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgListarMascota;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtFechaNaci;
        private System.Windows.Forms.ComboBox cbxIdSexo;
        private System.Windows.Forms.ComboBox cbxIdRaza;
        private System.Windows.Forms.ComboBox cbxEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReiniciar;
    }
}