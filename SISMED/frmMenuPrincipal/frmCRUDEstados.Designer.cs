namespace frmMenuPrincipal
{
    partial class frmCRUDEstados
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
            this.grpAccionesEstadosCRUD = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.grpListaEstadosCRUD = new System.Windows.Forms.GroupBox();
            this.grdNovedadesCRUD = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.grpDatosEstadosCRUD = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.grpAccionesEstadosCRUD.SuspendLayout();
            this.grpListaEstadosCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNovedadesCRUD)).BeginInit();
            this.grpDatosEstadosCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccionesEstadosCRUD
            // 
            this.grpAccionesEstadosCRUD.Controls.Add(this.btnNuevo);
            this.grpAccionesEstadosCRUD.Controls.Add(this.btnGuardar);
            this.grpAccionesEstadosCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesEstadosCRUD.Location = new System.Drawing.Point(23, 301);
            this.grpAccionesEstadosCRUD.Name = "grpAccionesEstadosCRUD";
            this.grpAccionesEstadosCRUD.Size = new System.Drawing.Size(419, 54);
            this.grpAccionesEstadosCRUD.TabIndex = 34;
            this.grpAccionesEstadosCRUD.TabStop = false;
            this.grpAccionesEstadosCRUD.Text = "Acciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(6, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 23);
            this.btnNuevo.TabIndex = 26;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpListaEstadosCRUD
            // 
            this.grpListaEstadosCRUD.Controls.Add(this.grdNovedadesCRUD);
            this.grpListaEstadosCRUD.Controls.Add(this.metroLabel3);
            this.grpListaEstadosCRUD.Controls.Add(this.txtFiltrar);
            this.grpListaEstadosCRUD.Location = new System.Drawing.Point(23, 127);
            this.grpListaEstadosCRUD.Name = "grpListaEstadosCRUD";
            this.grpListaEstadosCRUD.Size = new System.Drawing.Size(419, 168);
            this.grpListaEstadosCRUD.TabIndex = 33;
            this.grpListaEstadosCRUD.TabStop = false;
            this.grpListaEstadosCRUD.Text = "Lista de estados";
            // 
            // grdNovedadesCRUD
            // 
            this.grdNovedadesCRUD.AllowUserToResizeRows = false;
            this.grdNovedadesCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdNovedadesCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdNovedadesCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdNovedadesCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNovedadesCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdNovedadesCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdNovedadesCRUD.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdNovedadesCRUD.EnableHeadersVisualStyles = false;
            this.grdNovedadesCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdNovedadesCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdNovedadesCRUD.Location = new System.Drawing.Point(6, 48);
            this.grdNovedadesCRUD.Name = "grdNovedadesCRUD";
            this.grdNovedadesCRUD.ReadOnly = true;
            this.grdNovedadesCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNovedadesCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdNovedadesCRUD.RowHeadersVisible = false;
            this.grdNovedadesCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdNovedadesCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNovedadesCRUD.Size = new System.Drawing.Size(393, 114);
            this.grdNovedadesCRUD.TabIndex = 23;
            this.grdNovedadesCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNovedadesCRUD_CellDoubleClick);
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
            // grpDatosEstadosCRUD
            // 
            this.grpDatosEstadosCRUD.Controls.Add(this.txtDescripcion);
            this.grpDatosEstadosCRUD.Controls.Add(this.metroLabel2);
            this.grpDatosEstadosCRUD.Location = new System.Drawing.Point(23, 63);
            this.grpDatosEstadosCRUD.Name = "grpDatosEstadosCRUD";
            this.grpDatosEstadosCRUD.Size = new System.Drawing.Size(419, 58);
            this.grpDatosEstadosCRUD.TabIndex = 32;
            this.grpDatosEstadosCRUD.TabStop = false;
            this.grpDatosEstadosCRUD.Text = "Datos";
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Descripcion:";
            // 
            // frmCRUDEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 373);
            this.Controls.Add(this.grpAccionesEstadosCRUD);
            this.Controls.Add(this.grpListaEstadosCRUD);
            this.Controls.Add(this.grpDatosEstadosCRUD);
            this.Name = "frmCRUDEstados";
            this.Text = "Estados";
            this.grpAccionesEstadosCRUD.ResumeLayout(false);
            this.grpListaEstadosCRUD.ResumeLayout(false);
            this.grpListaEstadosCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNovedadesCRUD)).EndInit();
            this.grpDatosEstadosCRUD.ResumeLayout(false);
            this.grpDatosEstadosCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccionesEstadosCRUD;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.GroupBox grpListaEstadosCRUD;
        private MetroFramework.Controls.MetroGrid grdNovedadesCRUD;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private System.Windows.Forms.GroupBox grpDatosEstadosCRUD;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}