namespace InterfazdeUsuarioUI
{
    partial class CRUDRegistro
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
            this.components = new System.ComponentModel.Container();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblIdMascota = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDescripciConsulta = new System.Windows.Forms.Label();
            this.listarRegistroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLANGELBDDataSet2 = new InterfazdeUsuarioUI.ELANGELBDDataSet2();
            this.cbxIdCliente = new System.Windows.Forms.ComboBox();
            this.listarClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLANGELBDDataSet = new InterfazdeUsuarioUI.ELANGELBDDataSet();
            this.cbxIdMascota = new System.Windows.Forms.ComboBox();
            this.listarMascotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLANGELBDDataSet3 = new InterfazdeUsuarioUI.ELANGELBDDataSet3();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtDescripciConsulta = new System.Windows.Forms.TextBox();
            this.dgListarRegistro = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReinicar = new System.Windows.Forms.Button();
            this.listarClienteTableAdapter = new InterfazdeUsuarioUI.ELANGELBDDataSetTableAdapters.ListarClienteTableAdapter();
            this.listarRegistroTableAdapter = new InterfazdeUsuarioUI.ELANGELBDDataSet2TableAdapters.ListarRegistroTableAdapter();
            this.listarMascotaTableAdapter = new InterfazdeUsuarioUI.ELANGELBDDataSet3TableAdapters.ListarMascotaTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listarRegistroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLANGELBDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLANGELBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarMascotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLANGELBDDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(291, 84);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(42, 29);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.ForeColor = System.Drawing.Color.Black;
            this.lblIdCliente.Location = new System.Drawing.Point(41, 84);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(152, 29);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "Num Cliente:";
            // 
            // lblIdMascota
            // 
            this.lblIdMascota.AutoSize = true;
            this.lblIdMascota.BackColor = System.Drawing.Color.Transparent;
            this.lblIdMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMascota.ForeColor = System.Drawing.Color.Black;
            this.lblIdMascota.Location = new System.Drawing.Point(41, 194);
            this.lblIdMascota.Name = "lblIdMascota";
            this.lblIdMascota.Size = new System.Drawing.Size(166, 29);
            this.lblIdMascota.TabIndex = 2;
            this.lblIdMascota.Text = "Num Mascota:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(41, 313);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(94, 29);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado:";
            // 
            // lblDescripciConsulta
            // 
            this.lblDescripciConsulta.AutoSize = true;
            this.lblDescripciConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripciConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripciConsulta.ForeColor = System.Drawing.Color.Black;
            this.lblDescripciConsulta.Location = new System.Drawing.Point(41, 419);
            this.lblDescripciConsulta.Name = "lblDescripciConsulta";
            this.lblDescripciConsulta.Size = new System.Drawing.Size(247, 29);
            this.lblDescripciConsulta.TabIndex = 4;
            this.lblDescripciConsulta.Text = "Descripcion Consulta:";
            // 
            // listarRegistroBindingSource
            // 
            this.listarRegistroBindingSource.DataMember = "ListarRegistro";
            this.listarRegistroBindingSource.DataSource = this.eLANGELBDDataSet2;
            // 
            // eLANGELBDDataSet2
            // 
            this.eLANGELBDDataSet2.DataSetName = "ELANGELBDDataSet2";
            this.eLANGELBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxIdCliente
            // 
            this.cbxIdCliente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbxIdCliente.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cbxIdCliente.DataSource = this.listarClienteBindingSource;
            this.cbxIdCliente.DisplayMember = "Nombre";
            this.cbxIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdCliente.ForeColor = System.Drawing.Color.Gold;
            this.cbxIdCliente.FormattingEnabled = true;
            this.cbxIdCliente.Location = new System.Drawing.Point(46, 131);
            this.cbxIdCliente.Name = "cbxIdCliente";
            this.cbxIdCliente.Size = new System.Drawing.Size(195, 32);
            this.cbxIdCliente.TabIndex = 6;
            this.cbxIdCliente.ValueMember = "Id";
            // 
            // listarClienteBindingSource
            // 
            this.listarClienteBindingSource.DataMember = "ListarCliente";
            this.listarClienteBindingSource.DataSource = this.eLANGELBDDataSet;
            // 
            // eLANGELBDDataSet
            // 
            this.eLANGELBDDataSet.DataSetName = "ELANGELBDDataSet";
            this.eLANGELBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxIdMascota
            // 
            this.cbxIdMascota.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbxIdMascota.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cbxIdMascota.DataSource = this.listarMascotaBindingSource;
            this.cbxIdMascota.DisplayMember = "ID";
            this.cbxIdMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdMascota.ForeColor = System.Drawing.Color.Gold;
            this.cbxIdMascota.FormattingEnabled = true;
            this.cbxIdMascota.Location = new System.Drawing.Point(46, 248);
            this.cbxIdMascota.Name = "cbxIdMascota";
            this.cbxIdMascota.Size = new System.Drawing.Size(195, 32);
            this.cbxIdMascota.TabIndex = 7;
            this.cbxIdMascota.ValueMember = "Nombre";
            // 
            // listarMascotaBindingSource
            // 
            this.listarMascotaBindingSource.DataMember = "ListarMascota";
            this.listarMascotaBindingSource.DataSource = this.eLANGELBDDataSet3;
            // 
            // eLANGELBDDataSet3
            // 
            this.eLANGELBDDataSet3.DataSetName = "ELANGELBDDataSet3";
            this.eLANGELBDDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbxEstado.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.ForeColor = System.Drawing.Color.Gold;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Seguimiento",
            "Tratamiento",
            "Realizado"});
            this.cbxEstado.Location = new System.Drawing.Point(46, 345);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(195, 32);
            this.cbxEstado.TabIndex = 8;
            // 
            // txtDescripciConsulta
            // 
            this.txtDescripciConsulta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtDescripciConsulta.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtDescripciConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripciConsulta.ForeColor = System.Drawing.Color.Gold;
            this.txtDescripciConsulta.Location = new System.Drawing.Point(63, 463);
            this.txtDescripciConsulta.Name = "txtDescripciConsulta";
            this.txtDescripciConsulta.Size = new System.Drawing.Size(877, 29);
            this.txtDescripciConsulta.TabIndex = 9;
            // 
            // dgListarRegistro
            // 
            this.dgListarRegistro.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgListarRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarRegistro.Location = new System.Drawing.Point(281, 178);
            this.dgListarRegistro.Name = "dgListarRegistro";
            this.dgListarRegistro.RowHeadersWidth = 123;
            this.dgListarRegistro.Size = new System.Drawing.Size(668, 233);
            this.dgListarRegistro.TabIndex = 10;
            this.dgListarRegistro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarRegistro_CellContentClick);
            this.dgListarRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarRegistro_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Gold;
            this.btnGuardar.Location = new System.Drawing.Point(482, 112);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 51);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Gold;
            this.btnModificar.Location = new System.Drawing.Point(654, 112);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 51);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Gold;
            this.btnEliminar.Location = new System.Drawing.Point(811, 112);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 51);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(425, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar Id:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Gold;
            this.txtBuscar.Location = new System.Drawing.Point(550, 417);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(195, 31);
            this.txtBuscar.TabIndex = 15;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Gold;
            this.btnBuscar.Location = new System.Drawing.Point(773, 417);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 34);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReinicar
            // 
            this.btnReinicar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReinicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinicar.ForeColor = System.Drawing.Color.Gold;
            this.btnReinicar.Location = new System.Drawing.Point(869, 420);
            this.btnReinicar.Name = "btnReinicar";
            this.btnReinicar.Size = new System.Drawing.Size(80, 32);
            this.btnReinicar.TabIndex = 17;
            this.btnReinicar.Text = "Reinicar";
            this.btnReinicar.UseVisualStyleBackColor = false;
            this.btnReinicar.Click += new System.EventHandler(this.btnReinicar_Click);
            // 
            // listarClienteTableAdapter
            // 
            this.listarClienteTableAdapter.ClearBeforeFill = true;
            // 
            // listarRegistroTableAdapter
            // 
            this.listarRegistroTableAdapter.ClearBeforeFill = true;
            // 
            // listarMascotaTableAdapter
            // 
            this.listarMascotaTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtId.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.Gold;
            this.txtId.Location = new System.Drawing.Point(339, 84);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(39, 29);
            this.txtId.TabIndex = 18;
            // 
            // CRUDRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::InterfazdeUsuarioUI.Properties.Resources.Todos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 534);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnReinicar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgListarRegistro);
            this.Controls.Add(this.txtDescripciConsulta);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxIdMascota);
            this.Controls.Add(this.cbxIdCliente);
            this.Controls.Add(this.lblDescripciConsulta);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblIdMascota);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.lblId);
            this.Name = "CRUDRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.CRUDRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listarRegistroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLANGELBDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLANGELBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarMascotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLANGELBDDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblIdMascota;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDescripciConsulta;
        private System.Windows.Forms.ComboBox cbxIdCliente;
        private System.Windows.Forms.ComboBox cbxIdMascota;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtDescripciConsulta;
        private System.Windows.Forms.DataGridView dgListarRegistro;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReinicar;
        private ELANGELBDDataSet eLANGELBDDataSet;
        private System.Windows.Forms.BindingSource listarClienteBindingSource;
        private ELANGELBDDataSetTableAdapters.ListarClienteTableAdapter listarClienteTableAdapter;
        private ELANGELBDDataSet2 eLANGELBDDataSet2;
        private System.Windows.Forms.BindingSource listarRegistroBindingSource;
        private ELANGELBDDataSet2TableAdapters.ListarRegistroTableAdapter listarRegistroTableAdapter;
        private ELANGELBDDataSet3 eLANGELBDDataSet3;
        private System.Windows.Forms.BindingSource listarMascotaBindingSource;
        private ELANGELBDDataSet3TableAdapters.ListarMascotaTableAdapter listarMascotaTableAdapter;
        private System.Windows.Forms.TextBox txtId;
    }
}