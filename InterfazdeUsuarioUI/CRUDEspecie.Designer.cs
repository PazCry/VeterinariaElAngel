namespace InterfazdeUsuarioUI
{
    partial class CRUDEspecie
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
            this.lblIdEspecie = new System.Windows.Forms.Label();
            this.lblTipoEspecie = new System.Windows.Forms.Label();
            this.dgListarEspecie = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtIdEspecie = new System.Windows.Forms.TextBox();
            this.txtTipoEspecie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarEspecie)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdEspecie
            // 
            this.lblIdEspecie.AutoSize = true;
            this.lblIdEspecie.Location = new System.Drawing.Point(183, 138);
            this.lblIdEspecie.Name = "lblIdEspecie";
            this.lblIdEspecie.Size = new System.Drawing.Size(70, 13);
            this.lblIdEspecie.TabIndex = 0;
            this.lblIdEspecie.Text = "Num Especie";
            // 
            // lblTipoEspecie
            // 
            this.lblTipoEspecie.AutoSize = true;
            this.lblTipoEspecie.Location = new System.Drawing.Point(465, 135);
            this.lblTipoEspecie.Name = "lblTipoEspecie";
            this.lblTipoEspecie.Size = new System.Drawing.Size(69, 13);
            this.lblTipoEspecie.TabIndex = 1;
            this.lblTipoEspecie.Text = "Tipo Especie";
            // 
            // dgListarEspecie
            // 
            this.dgListarEspecie.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgListarEspecie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarEspecie.Location = new System.Drawing.Point(252, 621);
            this.dgListarEspecie.Name = "dgListarEspecie";
            this.dgListarEspecie.RowHeadersWidth = 123;
            this.dgListarEspecie.Size = new System.Drawing.Size(763, 150);
            this.dgListarEspecie.TabIndex = 2;
            this.dgListarEspecie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarEspecie_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(294, 258);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 31);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(594, 258);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 31);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(909, 255);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtIdEspecie
            // 
            this.txtIdEspecie.Location = new System.Drawing.Point(283, 135);
            this.txtIdEspecie.Name = "txtIdEspecie";
            this.txtIdEspecie.Size = new System.Drawing.Size(125, 20);
            this.txtIdEspecie.TabIndex = 6;
            this.txtIdEspecie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdEspecie_KeyPress);
            // 
            // txtTipoEspecie
            // 
            this.txtTipoEspecie.Location = new System.Drawing.Point(563, 131);
            this.txtTipoEspecie.Name = "txtTipoEspecie";
            this.txtTipoEspecie.Size = new System.Drawing.Size(132, 20);
            this.txtTipoEspecie.TabIndex = 7;
            this.txtTipoEspecie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoEspecie_KeyPress);
            // 
            // CRUDEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::InterfazdeUsuarioUI.Properties.Resources.Especie;
            this.ClientSize = new System.Drawing.Size(1281, 830);
            this.Controls.Add(this.txtTipoEspecie);
            this.Controls.Add(this.txtIdEspecie);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgListarEspecie);
            this.Controls.Add(this.lblTipoEspecie);
            this.Controls.Add(this.lblIdEspecie);
            this.Name = "CRUDEspecie";
            this.Text = "CRUDEspecie";
            ((System.ComponentModel.ISupportInitialize)(this.dgListarEspecie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdEspecie;
        private System.Windows.Forms.Label lblTipoEspecie;
        private System.Windows.Forms.DataGridView dgListarEspecie;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdEspecie;
        private System.Windows.Forms.TextBox txtTipoEspecie;
    }
}