namespace frmMenuPrincipal
{
    partial class frmCRUDTipificaciones
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
            this.grpAccionesTipificacionesCRUD = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.grpListaTipificacionesCRUD = new System.Windows.Forms.GroupBox();
            this.grdTipificacionesCRUD = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.grpDatosTipificacionesCRUD = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grpAccionesTipificacionesCRUD.SuspendLayout();
            this.grpListaTipificacionesCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipificacionesCRUD)).BeginInit();
            this.grpDatosTipificacionesCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccionesTipificacionesCRUD
            // 
            this.grpAccionesTipificacionesCRUD.Controls.Add(this.btnNuevo);
            this.grpAccionesTipificacionesCRUD.Controls.Add(this.btnGuardar);
            this.grpAccionesTipificacionesCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesTipificacionesCRUD.Location = new System.Drawing.Point(23, 301);
            this.grpAccionesTipificacionesCRUD.Name = "grpAccionesTipificacionesCRUD";
            this.grpAccionesTipificacionesCRUD.Size = new System.Drawing.Size(419, 54);
            this.grpAccionesTipificacionesCRUD.TabIndex = 44;
            this.grpAccionesTipificacionesCRUD.TabStop = false;
            this.grpAccionesTipificacionesCRUD.Text = "Acciones";
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
            // grpListaTipificacionesCRUD
            // 
            this.grpListaTipificacionesCRUD.Controls.Add(this.grdTipificacionesCRUD);
            this.grpListaTipificacionesCRUD.Controls.Add(this.metroLabel3);
            this.grpListaTipificacionesCRUD.Controls.Add(this.txtFiltrar);
            this.grpListaTipificacionesCRUD.Location = new System.Drawing.Point(23, 127);
            this.grpListaTipificacionesCRUD.Name = "grpListaTipificacionesCRUD";
            this.grpListaTipificacionesCRUD.Size = new System.Drawing.Size(419, 168);
            this.grpListaTipificacionesCRUD.TabIndex = 43;
            this.grpListaTipificacionesCRUD.TabStop = false;
            this.grpListaTipificacionesCRUD.Text = "Lista de tipificaciones";
            // 
            // grdTipificacionesCRUD
            // 
            this.grdTipificacionesCRUD.AllowUserToResizeRows = false;
            this.grdTipificacionesCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTipificacionesCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTipificacionesCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdTipificacionesCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTipificacionesCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdTipificacionesCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTipificacionesCRUD.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdTipificacionesCRUD.EnableHeadersVisualStyles = false;
            this.grdTipificacionesCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdTipificacionesCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTipificacionesCRUD.Location = new System.Drawing.Point(6, 48);
            this.grdTipificacionesCRUD.Name = "grdTipificacionesCRUD";
            this.grdTipificacionesCRUD.ReadOnly = true;
            this.grdTipificacionesCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTipificacionesCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdTipificacionesCRUD.RowHeadersVisible = false;
            this.grdTipificacionesCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdTipificacionesCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTipificacionesCRUD.Size = new System.Drawing.Size(393, 114);
            this.grdTipificacionesCRUD.TabIndex = 23;
            this.grdTipificacionesCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTipificacionesCRUD_CellDoubleClick);
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
            // grpDatosTipificacionesCRUD
            // 
            this.grpDatosTipificacionesCRUD.Controls.Add(this.txtDescripcion);
            this.grpDatosTipificacionesCRUD.Controls.Add(this.metroLabel1);
            this.grpDatosTipificacionesCRUD.Location = new System.Drawing.Point(23, 63);
            this.grpDatosTipificacionesCRUD.Name = "grpDatosTipificacionesCRUD";
            this.grpDatosTipificacionesCRUD.Size = new System.Drawing.Size(419, 58);
            this.grpDatosTipificacionesCRUD.TabIndex = 42;
            this.grpDatosTipificacionesCRUD.TabStop = false;
            this.grpDatosTipificacionesCRUD.Text = "Datos";
            this.grpDatosTipificacionesCRUD.Enter += new System.EventHandler(this.grpDatosTipificacionesCRUD_Enter);
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
            // frmCRUDTipificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 364);
            this.Controls.Add(this.grpAccionesTipificacionesCRUD);
            this.Controls.Add(this.grpListaTipificacionesCRUD);
            this.Controls.Add(this.grpDatosTipificacionesCRUD);
            this.Name = "frmCRUDTipificaciones";
            this.Text = "Tipificaciones";
            this.Load += new System.EventHandler(this.frmCRUDTipificaciones_Load);
            this.grpAccionesTipificacionesCRUD.ResumeLayout(false);
            this.grpListaTipificacionesCRUD.ResumeLayout(false);
            this.grpListaTipificacionesCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipificacionesCRUD)).EndInit();
            this.grpDatosTipificacionesCRUD.ResumeLayout(false);
            this.grpDatosTipificacionesCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccionesTipificacionesCRUD;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.GroupBox grpListaTipificacionesCRUD;
        private MetroFramework.Controls.MetroGrid grdTipificacionesCRUD;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private System.Windows.Forms.GroupBox grpDatosTipificacionesCRUD;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;

    }
}