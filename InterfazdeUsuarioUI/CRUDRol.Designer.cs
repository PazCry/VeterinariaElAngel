namespace InterfazdeUsuarioUI
{
    partial class CRUDRol
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
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNumeroRol = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.dgListarRol = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.nudNumeroRol = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroRol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.Black;
            this.lblRol.Location = new System.Drawing.Point(29, 47);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(143, 21);
            this.lblRol.TabIndex = 0;
            this.lblRol.Text = "Nombre del Rol";
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumeroRol
            // 
            this.lblNumeroRol.AutoSize = true;
            this.lblNumeroRol.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroRol.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRol.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroRol.Location = new System.Drawing.Point(29, 132);
            this.lblNumeroRol.Name = "lblNumeroRol";
            this.lblNumeroRol.Size = new System.Drawing.Size(138, 21);
            this.lblNumeroRol.TabIndex = 1;
            this.lblNumeroRol.Text = "Numero de Rol";
            this.lblNumeroRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.BackColor = System.Drawing.Color.Thistle;
            this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.ForeColor = System.Drawing.Color.Black;
            this.txtNombreRol.Location = new System.Drawing.Point(33, 86);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(134, 22);
            this.txtNombreRol.TabIndex = 2;
            this.txtNombreRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreRol_KeyPress);
            // 
            // dgListarRol
            // 
            this.dgListarRol.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgListarRol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListarRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarRol.Location = new System.Drawing.Point(198, 62);
            this.dgListarRol.Name = "dgListarRol";
            this.dgListarRol.Size = new System.Drawing.Size(341, 150);
            this.dgListarRol.TabIndex = 3;
            this.dgListarRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarRol_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Thistle;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(50, 218);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 33);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Thistle;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(198, 218);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 33);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Thistle;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(354, 218);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 33);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // nudNumeroRol
            // 
            this.nudNumeroRol.BackColor = System.Drawing.Color.Thistle;
            this.nudNumeroRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumeroRol.ForeColor = System.Drawing.Color.Black;
            this.nudNumeroRol.Location = new System.Drawing.Point(33, 166);
            this.nudNumeroRol.Name = "nudNumeroRol";
            this.nudNumeroRol.Size = new System.Drawing.Size(134, 22);
            this.nudNumeroRol.TabIndex = 7;
            // 
            // CRUDRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::InterfazdeUsuarioUI.Properties.Resources.Todos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 278);
            this.Controls.Add(this.nudNumeroRol);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgListarRol);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.lblNumeroRol);
            this.Controls.Add(this.lblRol);
            this.Name = "CRUDRol";
            this.Text = "CRUDRol";
            ((System.ComponentModel.ISupportInitialize)(this.dgListarRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNumeroRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.DataGridView dgListarRol;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.NumericUpDown nudNumeroRol;
    }
}