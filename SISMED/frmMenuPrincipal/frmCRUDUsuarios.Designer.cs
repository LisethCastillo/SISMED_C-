namespace frmMenuPrincipal
{
    partial class frmCRUDUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpAccionesUsuariosCRUD = new System.Windows.Forms.GroupBox();
            this.dtFechaNaci = new MetroFramework.Controls.MetroDateTime();
            this.lblFechaNaci = new MetroFramework.Controls.MetroLabel();
            this.optMasculino = new MetroFramework.Controls.MetroRadioButton();
            this.optFemenino = new MetroFramework.Controls.MetroRadioButton();
            this.txtClave = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtDireccion = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefono = new MetroFramework.Controls.MetroTextBox();
            this.txtCedula = new MetroFramework.Controls.MetroTextBox();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.cboRoles = new MetroFramework.Controls.MetroComboBox();
            this.lblRol = new MetroFramework.Controls.MetroLabel();
            this.lblClave = new MetroFramework.Controls.MetroLabel();
            this.lblemail = new MetroFramework.Controls.MetroLabel();
            this.lblDireccion = new MetroFramework.Controls.MetroLabel();
            this.lblTelefono = new MetroFramework.Controls.MetroLabel();
            this.lblSexo = new MetroFramework.Controls.MetroLabel();
            this.lblCedula = new MetroFramework.Controls.MetroLabel();
            this.lblApellidos = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.grpDotosUsuariosCRUD = new System.Windows.Forms.GroupBox();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.lblFiltrar = new MetroFramework.Controls.MetroLabel();
            this.grdUsuariosCRUD = new MetroFramework.Controls.MetroGrid();
            this.grpListaUsuariosCRUD = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.grpAccionesUsuariosCRUD.SuspendLayout();
            this.grpDotosUsuariosCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuariosCRUD)).BeginInit();
            this.grpListaUsuariosCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccionesUsuariosCRUD
            // 
            this.grpAccionesUsuariosCRUD.Controls.Add(this.dtFechaNaci);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.lblFechaNaci);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.optMasculino);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.optFemenino);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.txtClave);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.txtEmail);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.txtDireccion);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.txtTelefono);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.txtCedula);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.txtApellido);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.txtNombre);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.cboRoles);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.lblRol);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.lblClave);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.lblemail);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.lblDireccion);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.lblTelefono);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.lblSexo);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.lblCedula);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.lblApellidos);
            this.grpAccionesUsuariosCRUD.Controls.Add(this.lblNombre);
            this.grpAccionesUsuariosCRUD.Location = new System.Drawing.Point(17, 63);
            this.grpAccionesUsuariosCRUD.Name = "grpAccionesUsuariosCRUD";
            this.grpAccionesUsuariosCRUD.Size = new System.Drawing.Size(622, 193);
            this.grpAccionesUsuariosCRUD.TabIndex = 12;
            this.grpAccionesUsuariosCRUD.TabStop = false;
            this.grpAccionesUsuariosCRUD.Text = "Datos";
            // 
            // dtFechaNaci
            // 
            this.dtFechaNaci.Location = new System.Drawing.Point(115, 135);
            this.dtFechaNaci.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFechaNaci.Name = "dtFechaNaci";
            this.dtFechaNaci.Size = new System.Drawing.Size(204, 29);
            this.dtFechaNaci.TabIndex = 21;
            // 
            // lblFechaNaci
            // 
            this.lblFechaNaci.AutoSize = true;
            this.lblFechaNaci.Location = new System.Drawing.Point(10, 139);
            this.lblFechaNaci.Name = "lblFechaNaci";
            this.lblFechaNaci.Size = new System.Drawing.Size(106, 19);
            this.lblFechaNaci.TabIndex = 20;
            this.lblFechaNaci.Text = "Fec. Nacimiento:";
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Location = new System.Drawing.Point(241, 114);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(78, 15);
            this.optMasculino.TabIndex = 19;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseSelectable = true;
            // 
            // optFemenino
            // 
            this.optFemenino.AutoSize = true;
            this.optFemenino.Location = new System.Drawing.Point(90, 114);
            this.optFemenino.Name = "optFemenino";
            this.optFemenino.Size = new System.Drawing.Size(76, 15);
            this.optFemenino.TabIndex = 18;
            this.optFemenino.Text = "Femenino";
            this.optFemenino.UseSelectable = true;
            // 
            // txtClave
            // 
            this.txtClave.Lines = new string[0];
            this.txtClave.Location = new System.Drawing.Point(405, 109);
            this.txtClave.MaxLength = 32767;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '\0';
            this.txtClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClave.SelectedText = "";
            this.txtClave.Size = new System.Drawing.Size(211, 23);
            this.txtClave.TabIndex = 17;
            this.txtClave.UseSelectable = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(405, 79);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(211, 23);
            this.txtEmail.TabIndex = 16;
            this.txtEmail.UseSelectable = true;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Lines = new string[0];
            this.txtDireccion.Location = new System.Drawing.Point(405, 49);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.Size = new System.Drawing.Size(211, 23);
            this.txtDireccion.TabIndex = 15;
            this.txtDireccion.UseSelectable = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Lines = new string[0];
            this.txtTelefono.Location = new System.Drawing.Point(405, 19);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(211, 23);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.UseSelectable = true;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.Lines = new string[0];
            this.txtCedula.Location = new System.Drawing.Point(90, 78);
            this.txtCedula.MaxLength = 32767;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PasswordChar = '\0';
            this.txtCedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCedula.SelectedText = "";
            this.txtCedula.Size = new System.Drawing.Size(229, 23);
            this.txtCedula.TabIndex = 13;
            this.txtCedula.UseSelectable = true;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Lines = new string[0];
            this.txtApellido.Location = new System.Drawing.Point(90, 49);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(229, 23);
            this.txtApellido.TabIndex = 12;
            this.txtApellido.UseSelectable = true;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(90, 20);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(229, 23);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.ItemHeight = 23;
            this.cboRoles.Location = new System.Drawing.Point(403, 138);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(213, 29);
            this.cboRoles.TabIndex = 10;
            this.cboRoles.UseSelectable = true;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(342, 138);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(31, 19);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "Rol:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(338, 110);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(44, 19);
            this.lblClave.TabIndex = 7;
            this.lblClave.Text = "Clave:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(338, 79);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(50, 19);
            this.lblemail.TabIndex = 6;
            this.lblemail.Text = "E-mail:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(338, 49);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 19);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(338, 20);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 19);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(10, 110);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 19);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(10, 78);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(78, 19);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "No. Cedula:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(10, 48);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(66, 19);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombres:";
            // 
            // grpDotosUsuariosCRUD
            // 
            this.grpDotosUsuariosCRUD.Controls.Add(this.txtFiltrar);
            this.grpDotosUsuariosCRUD.Controls.Add(this.lblFiltrar);
            this.grpDotosUsuariosCRUD.Controls.Add(this.grdUsuariosCRUD);
            this.grpDotosUsuariosCRUD.Location = new System.Drawing.Point(17, 272);
            this.grpDotosUsuariosCRUD.Name = "grpDotosUsuariosCRUD";
            this.grpDotosUsuariosCRUD.Size = new System.Drawing.Size(622, 179);
            this.grpDotosUsuariosCRUD.TabIndex = 14;
            this.grpDotosUsuariosCRUD.TabStop = false;
            this.grpDotosUsuariosCRUD.Text = "Lista de roles";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Lines = new string[0];
            this.txtFiltrar.Location = new System.Drawing.Point(395, 12);
            this.txtFiltrar.MaxLength = 32767;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.Size = new System.Drawing.Size(221, 23);
            this.txtFiltrar.TabIndex = 9;
            this.txtFiltrar.UseSelectable = true;
            this.txtFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrar_KeyUp);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(342, 16);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(47, 19);
            this.lblFiltrar.TabIndex = 8;
            this.lblFiltrar.Text = "Filtrar:";
            // 
            // grdUsuariosCRUD
            // 
            this.grdUsuariosCRUD.AllowUserToResizeRows = false;
            this.grdUsuariosCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdUsuariosCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdUsuariosCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdUsuariosCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUsuariosCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdUsuariosCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUsuariosCRUD.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdUsuariosCRUD.EnableHeadersVisualStyles = false;
            this.grdUsuariosCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdUsuariosCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdUsuariosCRUD.Location = new System.Drawing.Point(10, 41);
            this.grdUsuariosCRUD.Name = "grdUsuariosCRUD";
            this.grdUsuariosCRUD.ReadOnly = true;
            this.grdUsuariosCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUsuariosCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdUsuariosCRUD.RowHeadersVisible = false;
            this.grdUsuariosCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdUsuariosCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsuariosCRUD.Size = new System.Drawing.Size(606, 132);
            this.grdUsuariosCRUD.TabIndex = 7;
            this.grdUsuariosCRUD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuariosCRUD_CellContentClick);
            this.grdUsuariosCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuariosCRUD_CellDoubleClick);
            // 
            // grpListaUsuariosCRUD
            // 
            this.grpListaUsuariosCRUD.Controls.Add(this.btnCancelar);
            this.grpListaUsuariosCRUD.Controls.Add(this.btnGuardar);
            this.grpListaUsuariosCRUD.Controls.Add(this.btnNuevo);
            this.grpListaUsuariosCRUD.Location = new System.Drawing.Point(17, 457);
            this.grpListaUsuariosCRUD.Name = "grpListaUsuariosCRUD";
            this.grpListaUsuariosCRUD.Size = new System.Drawing.Size(622, 65);
            this.grpListaUsuariosCRUD.TabIndex = 13;
            this.grpListaUsuariosCRUD.TabStop = false;
            this.grpListaUsuariosCRUD.Text = "Acciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(443, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(220, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(184, 38);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(10, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(175, 38);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmCRUDUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 545);
            this.Controls.Add(this.grpAccionesUsuariosCRUD);
            this.Controls.Add(this.grpDotosUsuariosCRUD);
            this.Controls.Add(this.grpListaUsuariosCRUD);
            this.Name = "frmCRUDUsuarios";
            this.Text = "Usuarios";
            this.grpAccionesUsuariosCRUD.ResumeLayout(false);
            this.grpAccionesUsuariosCRUD.PerformLayout();
            this.grpDotosUsuariosCRUD.ResumeLayout(false);
            this.grpDotosUsuariosCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuariosCRUD)).EndInit();
            this.grpListaUsuariosCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccionesUsuariosCRUD;
        private System.Windows.Forms.GroupBox grpDotosUsuariosCRUD;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private MetroFramework.Controls.MetroLabel lblFiltrar;
        private MetroFramework.Controls.MetroGrid grdUsuariosCRUD;
        private System.Windows.Forms.GroupBox grpListaUsuariosCRUD;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroTextBox txtClave;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtDireccion;
        private MetroFramework.Controls.MetroTextBox txtTelefono;
        private MetroFramework.Controls.MetroTextBox txtCedula;
        private MetroFramework.Controls.MetroTextBox txtApellido;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroComboBox cboRoles;
        private MetroFramework.Controls.MetroLabel lblRol;
        private MetroFramework.Controls.MetroLabel lblClave;
        private MetroFramework.Controls.MetroLabel lblemail;
        private MetroFramework.Controls.MetroLabel lblDireccion;
        private MetroFramework.Controls.MetroLabel lblTelefono;
        private MetroFramework.Controls.MetroLabel lblSexo;
        private MetroFramework.Controls.MetroLabel lblCedula;
        private MetroFramework.Controls.MetroLabel lblApellidos;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroRadioButton optMasculino;
        private MetroFramework.Controls.MetroRadioButton optFemenino;
        private MetroFramework.Controls.MetroLabel lblFechaNaci;
        private MetroFramework.Controls.MetroDateTime dtFechaNaci;
    }
}