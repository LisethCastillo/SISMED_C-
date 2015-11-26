namespace frmMenuPrincipal
{
    partial class frmCRUDClases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpAccionesClasesCRUD = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.grpListaClasesCRUD = new System.Windows.Forms.GroupBox();
            this.grdClasesCRUD = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.grpDatosClasesCRUD = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grpAccionesClasesCRUD.SuspendLayout();
            this.grpListaClasesCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasesCRUD)).BeginInit();
            this.grpDatosClasesCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccionesClasesCRUD
            // 
            this.grpAccionesClasesCRUD.Controls.Add(this.btnNuevo);
            this.grpAccionesClasesCRUD.Controls.Add(this.btnGuardar);
            this.grpAccionesClasesCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesClasesCRUD.Location = new System.Drawing.Point(23, 301);
            this.grpAccionesClasesCRUD.Name = "grpAccionesClasesCRUD";
            this.grpAccionesClasesCRUD.Size = new System.Drawing.Size(419, 54);
            this.grpAccionesClasesCRUD.TabIndex = 38;
            this.grpAccionesClasesCRUD.TabStop = false;
            this.grpAccionesClasesCRUD.Text = "Acciones";
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
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(307, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            // 
            // grpListaClasesCRUD
            // 
            this.grpListaClasesCRUD.Controls.Add(this.grdClasesCRUD);
            this.grpListaClasesCRUD.Controls.Add(this.metroLabel3);
            this.grpListaClasesCRUD.Controls.Add(this.txtFiltrar);
            this.grpListaClasesCRUD.Location = new System.Drawing.Point(23, 127);
            this.grpListaClasesCRUD.Name = "grpListaClasesCRUD";
            this.grpListaClasesCRUD.Size = new System.Drawing.Size(419, 168);
            this.grpListaClasesCRUD.TabIndex = 37;
            this.grpListaClasesCRUD.TabStop = false;
            this.grpListaClasesCRUD.Text = "Lista de clases";
            // 
            // grdClasesCRUD
            // 
            this.grdClasesCRUD.AllowUserToResizeRows = false;
            this.grdClasesCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdClasesCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdClasesCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdClasesCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClasesCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdClasesCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdClasesCRUD.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdClasesCRUD.EnableHeadersVisualStyles = false;
            this.grdClasesCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdClasesCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdClasesCRUD.Location = new System.Drawing.Point(6, 48);
            this.grdClasesCRUD.Name = "grdClasesCRUD";
            this.grdClasesCRUD.ReadOnly = true;
            this.grdClasesCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClasesCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdClasesCRUD.RowHeadersVisible = false;
            this.grdClasesCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdClasesCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClasesCRUD.Size = new System.Drawing.Size(393, 114);
            this.grdClasesCRUD.TabIndex = 23;
            this.grdClasesCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClasesCRUD_CellDoubleClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(223, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Filtrar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Lines = new string[0];
            this.txtFiltrar.Location = new System.Drawing.Point(276, 19);
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
            // grpDatosClasesCRUD
            // 
            this.grpDatosClasesCRUD.Controls.Add(this.txtDescripcion);
            this.grpDatosClasesCRUD.Controls.Add(this.metroLabel1);
            this.grpDatosClasesCRUD.Location = new System.Drawing.Point(23, 63);
            this.grpDatosClasesCRUD.Name = "grpDatosClasesCRUD";
            this.grpDatosClasesCRUD.Size = new System.Drawing.Size(419, 58);
            this.grpDatosClasesCRUD.TabIndex = 36;
            this.grpDatosClasesCRUD.TabStop = false;
            this.grpDatosClasesCRUD.Text = "Datos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(91, 23);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(308, 23);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Descripcion:";
            // 
            // frmCRUDClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 372);
            this.Controls.Add(this.grpAccionesClasesCRUD);
            this.Controls.Add(this.grpListaClasesCRUD);
            this.Controls.Add(this.grpDatosClasesCRUD);
            this.Name = "frmCRUDClases";
            this.Text = "Clases";
            this.Load += new System.EventHandler(this.frmClasesCRUD_Load);
            this.grpAccionesClasesCRUD.ResumeLayout(false);
            this.grpListaClasesCRUD.ResumeLayout(false);
            this.grpListaClasesCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClasesCRUD)).EndInit();
            this.grpDatosClasesCRUD.ResumeLayout(false);
            this.grpDatosClasesCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccionesClasesCRUD;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.GroupBox grpListaClasesCRUD;
        private MetroFramework.Controls.MetroGrid grdClasesCRUD;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private System.Windows.Forms.GroupBox grpDatosClasesCRUD;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;

    }
}