namespace frmMenuPrincipal
{
    partial class frmCRUDConsultorios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.grdConsultoriosCRUD = new MetroFramework.Controls.MetroGrid();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.grpDatosConsultoriosCRUD = new System.Windows.Forms.GroupBox();
            this.grpListaConsultoriosCRUD = new System.Windows.Forms.GroupBox();
            this.grpAccionesConsultoriosCRUD = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultoriosCRUD)).BeginInit();
            this.grpDatosConsultoriosCRUD.SuspendLayout();
            this.grpListaConsultoriosCRUD.SuspendLayout();
            this.grpAccionesConsultoriosCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(68, 19);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(123, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.UseSelectable = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(282, 19);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(123, 23);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(200, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Descripcion";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Lines = new string[0];
            this.txtFiltrar.Location = new System.Drawing.Point(55, 19);
            this.txtFiltrar.MaxLength = 32767;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.Size = new System.Drawing.Size(123, 23);
            this.txtFiltrar.TabIndex = 5;
            this.txtFiltrar.UseSelectable = true;
            this.txtFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrar_KeyUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 23);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Filtrar";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // grdConsultoriosCRUD
            // 
            this.grdConsultoriosCRUD.AllowUserToResizeRows = false;
            this.grdConsultoriosCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConsultoriosCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdConsultoriosCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdConsultoriosCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConsultoriosCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grdConsultoriosCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConsultoriosCRUD.DefaultCellStyle = dataGridViewCellStyle17;
            this.grdConsultoriosCRUD.EnableHeadersVisualStyles = false;
            this.grdConsultoriosCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdConsultoriosCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConsultoriosCRUD.Location = new System.Drawing.Point(6, 48);
            this.grdConsultoriosCRUD.Name = "grdConsultoriosCRUD";
            this.grdConsultoriosCRUD.ReadOnly = true;
            this.grdConsultoriosCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConsultoriosCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grdConsultoriosCRUD.RowHeadersVisible = false;
            this.grdConsultoriosCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdConsultoriosCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConsultoriosCRUD.Size = new System.Drawing.Size(393, 114);
            this.grdConsultoriosCRUD.TabIndex = 23;
            this.grdConsultoriosCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdConsultoriosCRUD_CellDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(307, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(160, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 23);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(6, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnNuevo.TabIndex = 26;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseSelectable = true;
            // 
            // grpDatosConsultoriosCRUD
            // 
            this.grpDatosConsultoriosCRUD.Controls.Add(this.txtCodigo);
            this.grpDatosConsultoriosCRUD.Controls.Add(this.metroLabel1);
            this.grpDatosConsultoriosCRUD.Controls.Add(this.txtDescripcion);
            this.grpDatosConsultoriosCRUD.Controls.Add(this.metroLabel2);
            this.grpDatosConsultoriosCRUD.Location = new System.Drawing.Point(23, 63);
            this.grpDatosConsultoriosCRUD.Name = "grpDatosConsultoriosCRUD";
            this.grpDatosConsultoriosCRUD.Size = new System.Drawing.Size(419, 58);
            this.grpDatosConsultoriosCRUD.TabIndex = 29;
            this.grpDatosConsultoriosCRUD.TabStop = false;
            this.grpDatosConsultoriosCRUD.Text = "Datos";
            // 
            // grpListaConsultoriosCRUD
            // 
            this.grpListaConsultoriosCRUD.Controls.Add(this.grdConsultoriosCRUD);
            this.grpListaConsultoriosCRUD.Controls.Add(this.metroLabel3);
            this.grpListaConsultoriosCRUD.Controls.Add(this.txtFiltrar);
            this.grpListaConsultoriosCRUD.Location = new System.Drawing.Point(23, 127);
            this.grpListaConsultoriosCRUD.Name = "grpListaConsultoriosCRUD";
            this.grpListaConsultoriosCRUD.Size = new System.Drawing.Size(419, 168);
            this.grpListaConsultoriosCRUD.TabIndex = 30;
            this.grpListaConsultoriosCRUD.TabStop = false;
            this.grpListaConsultoriosCRUD.Text = "Lista de consultorios";
            this.grpListaConsultoriosCRUD.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // grpAccionesConsultoriosCRUD
            // 
            this.grpAccionesConsultoriosCRUD.Controls.Add(this.btnNuevo);
            this.grpAccionesConsultoriosCRUD.Controls.Add(this.btnGuardar);
            this.grpAccionesConsultoriosCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesConsultoriosCRUD.Location = new System.Drawing.Point(23, 301);
            this.grpAccionesConsultoriosCRUD.Name = "grpAccionesConsultoriosCRUD";
            this.grpAccionesConsultoriosCRUD.Size = new System.Drawing.Size(419, 54);
            this.grpAccionesConsultoriosCRUD.TabIndex = 31;
            this.grpAccionesConsultoriosCRUD.TabStop = false;
            this.grpAccionesConsultoriosCRUD.Text = "Acciones";
            // 
            // frmCRUDConsultorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 373);
            this.Controls.Add(this.grpAccionesConsultoriosCRUD);
            this.Controls.Add(this.grpListaConsultoriosCRUD);
            this.Controls.Add(this.grpDatosConsultoriosCRUD);
            this.Name = "frmCRUDConsultorios";
            this.Text = "Consultorios";
            this.Load += new System.EventHandler(this.frmCRUDConsultorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultoriosCRUD)).EndInit();
            this.grpDatosConsultoriosCRUD.ResumeLayout(false);
            this.grpDatosConsultoriosCRUD.PerformLayout();
            this.grpListaConsultoriosCRUD.ResumeLayout(false);
            this.grpListaConsultoriosCRUD.PerformLayout();
            this.grpAccionesConsultoriosCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid grdConsultoriosCRUD;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private System.Windows.Forms.GroupBox grpDatosConsultoriosCRUD;
        private System.Windows.Forms.GroupBox grpListaConsultoriosCRUD;
        private System.Windows.Forms.GroupBox grpAccionesConsultoriosCRUD;
    }
}