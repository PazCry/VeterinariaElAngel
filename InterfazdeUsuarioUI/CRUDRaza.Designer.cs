namespace InterfazdeUsuarioUI
{
    partial class CRUDRaza
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
            this.lblTipoRaza = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTipoRaza = new System.Windows.Forms.TextBox();
            this.dgListarRaza = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarRaza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(57, 46);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID ";
            // 
            // lblTipoRaza
            // 
            this.lblTipoRaza.AutoSize = true;
            this.lblTipoRaza.Location = new System.Drawing.Point(42, 100);
            this.lblTipoRaza.Name = "lblTipoRaza";
            this.lblTipoRaza.Size = new System.Drawing.Size(56, 13);
            this.lblTipoRaza.TabIndex = 1;
            this.lblTipoRaza.Text = "Tipo Raza";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(102, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtTipoRaza
            // 
            this.txtTipoRaza.Location = new System.Drawing.Point(113, 93);
            this.txtTipoRaza.Name = "txtTipoRaza";
            this.txtTipoRaza.Size = new System.Drawing.Size(100, 20);
            this.txtTipoRaza.TabIndex = 3;
            this.txtTipoRaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoRaza_KeyPress);
            // 
            // dgListarRaza
            // 
            this.dgListarRaza.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgListarRaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarRaza.Location = new System.Drawing.Point(286, 34);
            this.dgListarRaza.Name = "dgListarRaza";
            this.dgListarRaza.Size = new System.Drawing.Size(432, 150);
            this.dgListarRaza.TabIndex = 4;
            this.dgListarRaza.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarRaza_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(45, 201);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(236, 201);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(138, 201);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // CRUDRaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::InterfazdeUsuarioUI.Properties.Resources.Especie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 256);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgListarRaza);
            this.Controls.Add(this.txtTipoRaza);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTipoRaza);
            this.Controls.Add(this.lblId);
            this.Name = "CRUDRaza";
            this.Text = "CRUDRaza";
            ((System.ComponentModel.ISupportInitialize)(this.dgListarRaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTipoRaza;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTipoRaza;
        private System.Windows.Forms.DataGridView dgListarRaza;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}