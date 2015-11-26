namespace frmMenuPrincipal
{
    partial class frmCRUDTipoCitas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpAccionesTipoCitasCRUD = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.grpListaTipoCitasCRUD = new System.Windows.Forms.GroupBox();
            this.grdTipoCitasCRUD = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.grpDatosTipoCitasCRUD = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grpAccionesTipoCitasCRUD.SuspendLayout();
            this.grpListaTipoCitasCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoCitasCRUD)).BeginInit();
            this.grpDatosTipoCitasCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccionesTipoCitasCRUD
            // 
            this.grpAccionesTipoCitasCRUD.Controls.Add(this.btnNuevo);
            this.grpAccionesTipoCitasCRUD.Controls.Add(this.btnGuardar);
            this.grpAccionesTipoCitasCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesTipoCitasCRUD.Location = new System.Drawing.Point(23, 301);
            this.grpAccionesTipoCitasCRUD.Name = "grpAccionesTipoCitasCRUD";
            this.grpAccionesTipoCitasCRUD.Size = new System.Drawing.Size(419, 54);
            this.grpAccionesTipoCitasCRUD.TabIndex = 47;
            this.grpAccionesTipoCitasCRUD.TabStop = false;
            this.grpAccionesTipoCitasCRUD.Text = "Acciones";
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
            // grpListaTipoCitasCRUD
            // 
            this.grpListaTipoCitasCRUD.Controls.Add(this.grdTipoCitasCRUD);
            this.grpListaTipoCitasCRUD.Controls.Add(this.metroLabel3);
            this.grpListaTipoCitasCRUD.Controls.Add(this.txtFiltrar);
            this.grpListaTipoCitasCRUD.Location = new System.Drawing.Point(23, 127);
            this.grpListaTipoCitasCRUD.Name = "grpListaTipoCitasCRUD";
            this.grpListaTipoCitasCRUD.Size = new System.Drawing.Size(419, 168);
            this.grpListaTipoCitasCRUD.TabIndex = 46;
            this.grpListaTipoCitasCRUD.TabStop = false;
            this.grpListaTipoCitasCRUD.Text = "Lista de tipificaciones";
            // 
            // grdTipoCitasCRUD
            // 
            this.grdTipoCitasCRUD.AllowUserToResizeRows = false;
            this.grdTipoCitasCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTipoCitasCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTipoCitasCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdTipoCitasCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTipoCitasCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdTipoCitasCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTipoCitasCRUD.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdTipoCitasCRUD.EnableHeadersVisualStyles = false;
            this.grdTipoCitasCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdTipoCitasCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTipoCitasCRUD.Location = new System.Drawing.Point(6, 48);
            this.grdTipoCitasCRUD.Name = "grdTipoCitasCRUD";
            this.grdTipoCitasCRUD.ReadOnly = true;
            this.grdTipoCitasCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTipoCitasCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdTipoCitasCRUD.RowHeadersVisible = false;
            this.grdTipoCitasCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdTipoCitasCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTipoCitasCRUD.Size = new System.Drawing.Size(393, 114);
            this.grdTipoCitasCRUD.TabIndex = 23;
            this.grdTipoCitasCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTipoCitasCRUD_CellDoubleClick);
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
            // grpDatosTipoCitasCRUD
            // 
            this.grpDatosTipoCitasCRUD.Controls.Add(this.txtDescripcion);
            this.grpDatosTipoCitasCRUD.Controls.Add(this.metroLabel1);
            this.grpDatosTipoCitasCRUD.Location = new System.Drawing.Point(23, 63);
            this.grpDatosTipoCitasCRUD.Name = "grpDatosTipoCitasCRUD";
            this.grpDatosTipoCitasCRUD.Size = new System.Drawing.Size(419, 58);
            this.grpDatosTipoCitasCRUD.TabIndex = 45;
            this.grpDatosTipoCitasCRUD.TabStop = false;
            this.grpDatosTipoCitasCRUD.Text = "Datos";
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
            // frmCRUDTipoCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 366);
            this.Controls.Add(this.grpAccionesTipoCitasCRUD);
            this.Controls.Add(this.grpListaTipoCitasCRUD);
            this.Controls.Add(this.grpDatosTipoCitasCRUD);
            this.Name = "frmCRUDTipoCitas";
            this.Text = "Tipo citas";
            this.Load += new System.EventHandler(this.frmCRUDTipoCitas_Load);
            this.grpAccionesTipoCitasCRUD.ResumeLayout(false);
            this.grpListaTipoCitasCRUD.ResumeLayout(false);
            this.grpListaTipoCitasCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTipoCitasCRUD)).EndInit();
            this.grpDatosTipoCitasCRUD.ResumeLayout(false);
            this.grpDatosTipoCitasCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccionesTipoCitasCRUD;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.GroupBox grpListaTipoCitasCRUD;
        private MetroFramework.Controls.MetroGrid grdTipoCitasCRUD;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private System.Windows.Forms.GroupBox grpDatosTipoCitasCRUD;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;

    }
}