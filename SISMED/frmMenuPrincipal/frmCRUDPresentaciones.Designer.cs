namespace frmMenuPrincipal
{
    partial class frmCRUDPresentaciones
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
            this.grpListaParentescosCRUD = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.grpAccionesParentescosCRUD = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grpDotosParentescosCRUD = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.grdPresentacionesCRUD = new MetroFramework.Controls.MetroGrid();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.grpListaParentescosCRUD.SuspendLayout();
            this.grpAccionesParentescosCRUD.SuspendLayout();
            this.grpDotosParentescosCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPresentacionesCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListaParentescosCRUD
            // 
            this.grpListaParentescosCRUD.Controls.Add(this.btnNuevo);
            this.grpListaParentescosCRUD.Controls.Add(this.btnGuardar);
            this.grpListaParentescosCRUD.Controls.Add(this.btnCancelar);
            this.grpListaParentescosCRUD.Location = new System.Drawing.Point(23, 290);
            this.grpListaParentescosCRUD.Name = "grpListaParentescosCRUD";
            this.grpListaParentescosCRUD.Size = new System.Drawing.Size(428, 65);
            this.grpListaParentescosCRUD.TabIndex = 15;
            this.grpListaParentescosCRUD.TabStop = false;
            this.grpListaParentescosCRUD.Text = "Acciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(105, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(169, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(316, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // grpAccionesParentescosCRUD
            // 
            this.grpAccionesParentescosCRUD.Controls.Add(this.txtDescripcion);
            this.grpAccionesParentescosCRUD.Controls.Add(this.metroLabel1);
            this.grpAccionesParentescosCRUD.Location = new System.Drawing.Point(23, 60);
            this.grpAccionesParentescosCRUD.Name = "grpAccionesParentescosCRUD";
            this.grpAccionesParentescosCRUD.Size = new System.Drawing.Size(428, 73);
            this.grpAccionesParentescosCRUD.TabIndex = 14;
            this.grpAccionesParentescosCRUD.TabStop = false;
            this.grpAccionesParentescosCRUD.Text = "Datos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(110, 30);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(312, 23);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Descripción:";
            // 
            // grpDotosParentescosCRUD
            // 
            this.grpDotosParentescosCRUD.Controls.Add(this.metroLabel3);
            this.grpDotosParentescosCRUD.Controls.Add(this.grdPresentacionesCRUD);
            this.grpDotosParentescosCRUD.Controls.Add(this.txtFiltrar);
            this.grpDotosParentescosCRUD.Location = new System.Drawing.Point(23, 139);
            this.grpDotosParentescosCRUD.Name = "grpDotosParentescosCRUD";
            this.grpDotosParentescosCRUD.Size = new System.Drawing.Size(428, 145);
            this.grpDotosParentescosCRUD.TabIndex = 13;
            this.grpDotosParentescosCRUD.TabStop = false;
            this.grpDotosParentescosCRUD.Text = "Lista de roles";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(224, 12);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Filtrar:";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // grdPresentacionesCRUD
            // 
            this.grdPresentacionesCRUD.AllowUserToResizeRows = false;
            this.grdPresentacionesCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPresentacionesCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPresentacionesCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPresentacionesCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPresentacionesCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdPresentacionesCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPresentacionesCRUD.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdPresentacionesCRUD.EnableHeadersVisualStyles = false;
            this.grdPresentacionesCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPresentacionesCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPresentacionesCRUD.Location = new System.Drawing.Point(6, 48);
            this.grdPresentacionesCRUD.Name = "grdPresentacionesCRUD";
            this.grdPresentacionesCRUD.ReadOnly = true;
            this.grdPresentacionesCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPresentacionesCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdPresentacionesCRUD.RowHeadersVisible = false;
            this.grdPresentacionesCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPresentacionesCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPresentacionesCRUD.Size = new System.Drawing.Size(416, 91);
            this.grdPresentacionesCRUD.TabIndex = 6;
            this.grdPresentacionesCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPresentacionesCRUD_CellDoubleClick_1);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Lines = new string[0];
            this.txtFiltrar.Location = new System.Drawing.Point(286, 12);
            this.txtFiltrar.MaxLength = 32767;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.Size = new System.Drawing.Size(136, 23);
            this.txtFiltrar.TabIndex = 5;
            this.txtFiltrar.UseSelectable = true;
            this.txtFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrar_KeyUp_1);
            // 
            // frmCRUDPresentaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 379);
            this.Controls.Add(this.grpListaParentescosCRUD);
            this.Controls.Add(this.grpAccionesParentescosCRUD);
            this.Controls.Add(this.grpDotosParentescosCRUD);
            this.Name = "frmCRUDPresentaciones";
            this.Text = "Presentaciones";
            this.grpListaParentescosCRUD.ResumeLayout(false);
            this.grpAccionesParentescosCRUD.ResumeLayout(false);
            this.grpAccionesParentescosCRUD.PerformLayout();
            this.grpDotosParentescosCRUD.ResumeLayout(false);
            this.grpDotosParentescosCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPresentacionesCRUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListaParentescosCRUD;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.GroupBox grpAccionesParentescosCRUD;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox grpDotosParentescosCRUD;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid grdPresentacionesCRUD;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
    }
}