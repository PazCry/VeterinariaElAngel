namespace InterfazdeUsuarioUI
{
    partial class Login
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
            this.btningresar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.listarUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLANGELBDDataSet7 = new InterfazdeUsuarioUI.ELANGELBDDataSet7();
            this.eLANGELBDDataSet4 = new InterfazdeUsuarioUI.ELANGELBDDataSet4();
            this.listarRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarRolesTableAdapter = new InterfazdeUsuarioUI.ELANGELBDDataSet4TableAdapters.ListarRolesTableAdapter();
            this.listarUsuarioTableAdapter = new InterfazdeUsuarioUI.ELANGELBDDataSet7TableAdapters.ListarUsuarioTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listarUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLANGELBDDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLANGELBDDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarRolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.LightGreen;
            this.btningresar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btningresar.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Location = new System.Drawing.Point(200, 159);
            this.btningresar.Margin = new System.Windows.Forms.Padding(4);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(112, 34);
            this.btningresar.TabIndex = 0;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(34, 159);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(112, 34);
            this.btnlimpiar.TabIndex = 1;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtcorreo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.Color.Gray;
            this.txtcorreo.Location = new System.Drawing.Point(34, 51);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(278, 26);
            this.txtcorreo.TabIndex = 4;
            this.txtcorreo.Text = "Ingrese Correo";
            this.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcorreo.UseWaitCursor = true;
            this.txtcorreo.Enter += new System.EventHandler(this.txtcorreo_Enter);
            this.txtcorreo.Leave += new System.EventHandler(this.txtcorreo_Leave);
            this.txtcorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcorreo_Validating);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtcontrasena.ForeColor = System.Drawing.Color.Gray;
            this.txtcontrasena.Location = new System.Drawing.Point(34, 120);
            this.txtcontrasena.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontrasena.MaxLength = 35;
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.Size = new System.Drawing.Size(278, 26);
            this.txtcontrasena.TabIndex = 5;
            this.txtcontrasena.Text = "Contraseña";
            this.txtcontrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcontrasena.UseWaitCursor = true;
            this.txtcontrasena.Enter += new System.EventHandler(this.txtcontrasena_Enter);
            this.txtcontrasena.Leave += new System.EventHandler(this.txtcontrasena_Leave);
            // 
            // listarUsuarioBindingSource
            // 
            this.listarUsuarioBindingSource.DataMember = "ListarUsuario";
            this.listarUsuarioBindingSource.DataSource = this.eLANGELBDDataSet7;
            // 
            // eLANGELBDDataSet7
            // 
            this.eLANGELBDDataSet7.DataSetName = "ELANGELBDDataSet7";
            this.eLANGELBDDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eLANGELBDDataSet4
            // 
            this.eLANGELBDDataSet4.DataSetName = "ELANGELBDDataSet4";
            this.eLANGELBDDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listarRolesBindingSource
            // 
            this.listarRolesBindingSource.DataMember = "ListarRoles";
            this.listarRolesBindingSource.DataSource = this.eLANGELBDDataSet4;
            // 
            // listarRolesTableAdapter
            // 
            this.listarRolesTableAdapter.ClearBeforeFill = true;
            // 
            // listarUsuarioTableAdapter
            // 
            this.listarUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Salmon;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("News701 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(127, 219);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 33);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfazdeUsuarioUI.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(357, 291);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btningresar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.listarUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLANGELBDDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLANGELBDDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarRolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtcontrasena;
        private ELANGELBDDataSet4 eLANGELBDDataSet4;
        private System.Windows.Forms.BindingSource listarRolesBindingSource;
        private ELANGELBDDataSet4TableAdapters.ListarRolesTableAdapter listarRolesTableAdapter;
        private ELANGELBDDataSet7 eLANGELBDDataSet7;
        private System.Windows.Forms.BindingSource listarUsuarioBindingSource;
        private ELANGELBDDataSet7TableAdapters.ListarUsuarioTableAdapter listarUsuarioTableAdapter;
        private System.Windows.Forms.Button btnSalir;
    }
}