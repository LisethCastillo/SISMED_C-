namespace frmMenuPrincipal
{
    partial class frmCRUDCanales
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
            this.grpDatosCanalesCRUD = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grpListaCanalesCRUD = new System.Windows.Forms.GroupBox();
            this.grdCanalesCRUD = new MetroFramework.Controls.MetroGrid();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.grpAccionesCanalesCRUD = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.grpDatosCanalesCRUD.SuspendLayout();
            this.grpListaCanalesCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCanalesCRUD)).BeginInit();
            this.grpAccionesCanalesCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosCanalesCRUD
            // 
            this.grpDatosCanalesCRUD.Controls.Add(this.txtDescripcion);
            this.grpDatosCanalesCRUD.Controls.Add(this.metroLabel1);
            this.grpDatosCanalesCRUD.Location = new System.Drawing.Point(23, 63);
            this.grpDatosCanalesCRUD.Name = "grpDatosCanalesCRUD";
            this.grpDatosCanalesCRUD.Size = new System.Drawing.Size(419, 58);
            this.grpDatosCanalesCRUD.TabIndex = 33;
            this.grpDatosCanalesCRUD.TabStop = false;
            this.grpDatosCanalesCRUD.Text = "Datos";
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
            // grpListaCanalesCRUD
            // 
            this.grpListaCanalesCRUD.Controls.Add(this.grdCanalesCRUD);
            this.grpListaCanalesCRUD.Controls.Add(this.metroLabel3);
            this.grpListaCanalesCRUD.Controls.Add(this.txtFiltrar);
            this.grpListaCanalesCRUD.Location = new System.Drawing.Point(23, 127);
            this.grpListaCanalesCRUD.Name = "grpListaCanalesCRUD";
            this.grpListaCanalesCRUD.Size = new System.Drawing.Size(419, 168);
            this.grpListaCanalesCRUD.TabIndex = 34;
            this.grpListaCanalesCRUD.TabStop = false;
            this.grpListaCanalesCRUD.Text = "Lista de canales";
            // 
            // grdCanalesCRUD
            // 
            this.grdCanalesCRUD.AllowUserToResizeRows = false;
            this.grdCanalesCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCanalesCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCanalesCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdCanalesCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCanalesCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCanalesCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCanalesCRUD.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdCanalesCRUD.EnableHeadersVisualStyles = false;
            this.grdCanalesCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdCanalesCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCanalesCRUD.Location = new System.Drawing.Point(6, 48);
            this.grdCanalesCRUD.Name = "grdCanalesCRUD";
            this.grdCanalesCRUD.ReadOnly = true;
            this.grdCanalesCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCanalesCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdCanalesCRUD.RowHeadersVisible = false;
            this.grdCanalesCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdCanalesCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCanalesCRUD.Size = new System.Drawing.Size(393, 114);
            this.grdCanalesCRUD.TabIndex = 23;
            this.grdCanalesCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCanalesCRUD_CellDoubleClick);
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
            // grpAccionesCanalesCRUD
            // 
            this.grpAccionesCanalesCRUD.Controls.Add(this.btnNuevo);
            this.grpAccionesCanalesCRUD.Controls.Add(this.btnGuardar);
            this.grpAccionesCanalesCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesCanalesCRUD.Location = new System.Drawing.Point(23, 301);
            this.grpAccionesCanalesCRUD.Name = "grpAccionesCanalesCRUD";
            this.grpAccionesCanalesCRUD.Size = new System.Drawing.Size(419, 54);
            this.grpAccionesCanalesCRUD.TabIndex = 35;
            this.grpAccionesCanalesCRUD.TabStop = false;
            this.grpAccionesCanalesCRUD.Text = "Acciones";
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
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
            // frmCRUDCanales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 439);
            this.Controls.Add(this.grpAccionesCanalesCRUD);
            this.Controls.Add(this.grpListaCanalesCRUD);
            this.Controls.Add(this.grpDatosCanalesCRUD);
            this.Name = "frmCRUDCanales";
            this.Text = "Canales";
            this.Load += new System.EventHandler(this.frmCRUDCanales_Load);
            this.grpDatosCanalesCRUD.ResumeLayout(false);
            this.grpDatosCanalesCRUD.PerformLayout();
            this.grpListaCanalesCRUD.ResumeLayout(false);
            this.grpListaCanalesCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCanalesCRUD)).EndInit();
            this.grpAccionesCanalesCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosCanalesCRUD;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox grpListaCanalesCRUD;
        private MetroFramework.Controls.MetroGrid grdCanalesCRUD;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private System.Windows.Forms.GroupBox grpAccionesCanalesCRUD;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}