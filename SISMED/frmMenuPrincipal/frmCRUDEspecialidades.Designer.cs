namespace frmMenuPrincipal
{
    partial class frmCRUDEspecialidades
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
            this.grpDatosEspecialidadesGenerosCRUD = new System.Windows.Forms.GroupBox();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.txtDes = new MetroFramework.Controls.MetroTextBox();
            this.grpListaEspecialidadesCRUD = new System.Windows.Forms.GroupBox();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.lblFiltrar = new MetroFramework.Controls.MetroLabel();
            this.grdEspecialidadesCRUD = new MetroFramework.Controls.MetroGrid();
            this.grpAccionesGenerosCRUD = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.grpDatosEspecialidadesGenerosCRUD.SuspendLayout();
            this.grpListaEspecialidadesCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEspecialidadesCRUD)).BeginInit();
            this.grpAccionesGenerosCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosEspecialidadesGenerosCRUD
            // 
            this.grpDatosEspecialidadesGenerosCRUD.Controls.Add(this.lblDescripcion);
            this.grpDatosEspecialidadesGenerosCRUD.Controls.Add(this.txtDes);
            this.grpDatosEspecialidadesGenerosCRUD.Location = new System.Drawing.Point(23, 53);
            this.grpDatosEspecialidadesGenerosCRUD.Name = "grpDatosEspecialidadesGenerosCRUD";
            this.grpDatosEspecialidadesGenerosCRUD.Size = new System.Drawing.Size(451, 73);
            this.grpDatosEspecialidadesGenerosCRUD.TabIndex = 9;
            this.grpDatosEspecialidadesGenerosCRUD.TabStop = false;
            this.grpDatosEspecialidadesGenerosCRUD.Text = "Datos";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 30);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 19);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDes
            // 
            this.txtDes.Lines = new string[0];
            this.txtDes.Location = new System.Drawing.Point(91, 30);
            this.txtDes.MaxLength = 32767;
            this.txtDes.Name = "txtDes";
            this.txtDes.PasswordChar = '\0';
            this.txtDes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDes.SelectedText = "";
            this.txtDes.Size = new System.Drawing.Size(342, 23);
            this.txtDes.TabIndex = 1;
            this.txtDes.UseSelectable = true;
            this.txtDes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDes_KeyPress);
            // 
            // grpListaEspecialidadesCRUD
            // 
            this.grpListaEspecialidadesCRUD.Controls.Add(this.txtFiltrar);
            this.grpListaEspecialidadesCRUD.Controls.Add(this.lblFiltrar);
            this.grpListaEspecialidadesCRUD.Controls.Add(this.grdEspecialidadesCRUD);
            this.grpListaEspecialidadesCRUD.Location = new System.Drawing.Point(23, 132);
            this.grpListaEspecialidadesCRUD.Name = "grpListaEspecialidadesCRUD";
            this.grpListaEspecialidadesCRUD.Size = new System.Drawing.Size(451, 130);
            this.grpListaEspecialidadesCRUD.TabIndex = 11;
            this.grpListaEspecialidadesCRUD.TabStop = false;
            this.grpListaEspecialidadesCRUD.Text = "Lista de roles";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Lines = new string[0];
            this.txtFiltrar.Location = new System.Drawing.Point(341, 12);
            this.txtFiltrar.MaxLength = 32767;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.Size = new System.Drawing.Size(92, 23);
            this.txtFiltrar.TabIndex = 9;
            this.txtFiltrar.UseSelectable = true;
            this.txtFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrar_KeyUp);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(288, 12);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(47, 19);
            this.lblFiltrar.TabIndex = 8;
            this.lblFiltrar.Text = "Filtrar:";
            // 
            // grdEspecialidadesCRUD
            // 
            this.grdEspecialidadesCRUD.AllowUserToResizeRows = false;
            this.grdEspecialidadesCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdEspecialidadesCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEspecialidadesCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdEspecialidadesCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEspecialidadesCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEspecialidadesCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEspecialidadesCRUD.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdEspecialidadesCRUD.EnableHeadersVisualStyles = false;
            this.grdEspecialidadesCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdEspecialidadesCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdEspecialidadesCRUD.Location = new System.Drawing.Point(3, 41);
            this.grdEspecialidadesCRUD.Name = "grdEspecialidadesCRUD";
            this.grdEspecialidadesCRUD.ReadOnly = true;
            this.grdEspecialidadesCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEspecialidadesCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdEspecialidadesCRUD.RowHeadersVisible = false;
            this.grdEspecialidadesCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdEspecialidadesCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEspecialidadesCRUD.Size = new System.Drawing.Size(442, 83);
            this.grdEspecialidadesCRUD.TabIndex = 7;
            this.grdEspecialidadesCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEspecialidadesCRUD_CellDoubleClick);
            // 
            // grpAccionesGenerosCRUD
            // 
            this.grpAccionesGenerosCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesGenerosCRUD.Controls.Add(this.btnGuardar);
            this.grpAccionesGenerosCRUD.Controls.Add(this.btnNuevo);
            this.grpAccionesGenerosCRUD.Location = new System.Drawing.Point(23, 268);
            this.grpAccionesGenerosCRUD.Name = "grpAccionesGenerosCRUD";
            this.grpAccionesGenerosCRUD.Size = new System.Drawing.Size(451, 65);
            this.grpAccionesGenerosCRUD.TabIndex = 10;
            this.grpAccionesGenerosCRUD.TabStop = false;
            this.grpAccionesGenerosCRUD.Text = "Acciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(307, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(162, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(10, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(129, 23);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmCRUDEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 358);
            this.Controls.Add(this.grpDatosEspecialidadesGenerosCRUD);
            this.Controls.Add(this.grpListaEspecialidadesCRUD);
            this.Controls.Add(this.grpAccionesGenerosCRUD);
            this.Name = "frmCRUDEspecialidades";
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.frmCRUDEspecialidades_Load);
            this.grpDatosEspecialidadesGenerosCRUD.ResumeLayout(false);
            this.grpDatosEspecialidadesGenerosCRUD.PerformLayout();
            this.grpListaEspecialidadesCRUD.ResumeLayout(false);
            this.grpListaEspecialidadesCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEspecialidadesCRUD)).EndInit();
            this.grpAccionesGenerosCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosEspecialidadesGenerosCRUD;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroTextBox txtDes;
        private System.Windows.Forms.GroupBox grpListaEspecialidadesCRUD;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private MetroFramework.Controls.MetroLabel lblFiltrar;
        private MetroFramework.Controls.MetroGrid grdEspecialidadesCRUD;
        private System.Windows.Forms.GroupBox grpAccionesGenerosCRUD;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnNuevo;
    }
}