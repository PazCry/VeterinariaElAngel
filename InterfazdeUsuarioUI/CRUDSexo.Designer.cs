namespace InterfazdeUsuarioUI
{
    partial class CRUDSexo
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
            this.lblTipoSexo = new System.Windows.Forms.Label();
            this.dgListarSexo = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTipoSexo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarSexo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(655, 50);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblTipoSexo
            // 
            this.lblTipoSexo.AutoSize = true;
            this.lblTipoSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoSexo.Location = new System.Drawing.Point(636, 199);
            this.lblTipoSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoSexo.Name = "lblTipoSexo";
            this.lblTipoSexo.Size = new System.Drawing.Size(52, 16);
            this.lblTipoSexo.TabIndex = 1;
            this.lblTipoSexo.Text = "Genero";
            // 
            // dgListarSexo
            // 
            this.dgListarSexo.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgListarSexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarSexo.Location = new System.Drawing.Point(51, 31);
            this.dgListarSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgListarSexo.Name = "dgListarSexo";
            this.dgListarSexo.RowHeadersWidth = 51;
            this.dgListarSexo.Size = new System.Drawing.Size(333, 185);
            this.dgListarSexo.TabIndex = 2;
            this.dgListarSexo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarSexo_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Thistle;
            this.btnGuardar.Location = new System.Drawing.Point(51, 223);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Thistle;
            this.btnModificar.Location = new System.Drawing.Point(185, 223);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Thistle;
            this.btnEliminar.Location = new System.Drawing.Point(309, 223);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Thistle;
            this.txtId.Location = new System.Drawing.Point(703, 47);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 6;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtTipoSexo
            // 
            this.txtTipoSexo.BackColor = System.Drawing.Color.Thistle;
            this.txtTipoSexo.Location = new System.Drawing.Point(731, 196);
            this.txtTipoSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipoSexo.Name = "txtTipoSexo";
            this.txtTipoSexo.Size = new System.Drawing.Size(132, 22);
            this.txtTipoSexo.TabIndex = 7;
            this.txtTipoSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipoSexo_KeyPress);
            // 
            // CRUDSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::InterfazdeUsuarioUI.Properties.Resources.Especie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 281);
            this.Controls.Add(this.txtTipoSexo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgListarSexo);
            this.Controls.Add(this.lblTipoSexo);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CRUDSexo";
            this.Text = "Genero";
            ((System.ComponentModel.ISupportInitialize)(this.dgListarSexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTipoSexo;
        private System.Windows.Forms.DataGridView dgListarSexo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTipoSexo;
    }
}