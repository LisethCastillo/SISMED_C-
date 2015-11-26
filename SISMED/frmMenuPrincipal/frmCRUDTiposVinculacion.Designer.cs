namespace frmMenuPrincipal
{
    partial class frmCRUDTiposVinculacion
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
            this.grpListaTipoVinculacionCRUD = new System.Windows.Forms.GroupBox();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.lblFiltar = new MetroFramework.Controls.MetroLabel();
            this.grdTiposVinculacionCRUD = new MetroFramework.Controls.MetroGrid();
            this.grpAccionesTipoVinculacionCRUD = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.grpDotosTipoVinculacionCRUD = new System.Windows.Forms.GroupBox();
            this.txtDes = new MetroFramework.Controls.MetroTextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.grpListaTipoVinculacionCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposVinculacionCRUD)).BeginInit();
            this.grpAccionesTipoVinculacionCRUD.SuspendLayout();
            this.grpDotosTipoVinculacionCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListaTipoVinculacionCRUD
            // 
            this.grpListaTipoVinculacionCRUD.Controls.Add(this.txtFiltrar);
            this.grpListaTipoVinculacionCRUD.Controls.Add(this.lblFiltar);
            this.grpListaTipoVinculacionCRUD.Controls.Add(this.grdTiposVinculacionCRUD);
            this.grpListaTipoVinculacionCRUD.Location = new System.Drawing.Point(23, 143);
            this.grpListaTipoVinculacionCRUD.Name = "grpListaTipoVinculacionCRUD";
            this.grpListaTipoVinculacionCRUD.Size = new System.Drawing.Size(451, 130);
            this.grpListaTipoVinculacionCRUD.TabIndex = 8;
            this.grpListaTipoVinculacionCRUD.TabStop = false;
            this.grpListaTipoVinculacionCRUD.Text = "Lista de roles";
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
            // lblFiltar
            // 
            this.lblFiltar.AutoSize = true;
            this.lblFiltar.Location = new System.Drawing.Point(288, 12);
            this.lblFiltar.Name = "lblFiltar";
            this.lblFiltar.Size = new System.Drawing.Size(47, 19);
            this.lblFiltar.TabIndex = 8;
            this.lblFiltar.Text = "Filtrar:";
            // 
            // grdTiposVinculacionCRUD
            // 
            this.grdTiposVinculacionCRUD.AllowUserToResizeRows = false;
            this.grdTiposVinculacionCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTiposVinculacionCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTiposVinculacionCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdTiposVinculacionCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTiposVinculacionCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTiposVinculacionCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTiposVinculacionCRUD.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdTiposVinculacionCRUD.EnableHeadersVisualStyles = false;
            this.grdTiposVinculacionCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdTiposVinculacionCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdTiposVinculacionCRUD.Location = new System.Drawing.Point(3, 41);
            this.grdTiposVinculacionCRUD.Name = "grdTiposVinculacionCRUD";
            this.grdTiposVinculacionCRUD.ReadOnly = true;
            this.grdTiposVinculacionCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTiposVinculacionCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdTiposVinculacionCRUD.RowHeadersVisible = false;
            this.grdTiposVinculacionCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdTiposVinculacionCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTiposVinculacionCRUD.Size = new System.Drawing.Size(442, 83);
            this.grdTiposVinculacionCRUD.TabIndex = 7;
            this.grdTiposVinculacionCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTiposVinculacionCRUD_CellDoubleClick);
            // 
            // grpAccionesTipoVinculacionCRUD
            // 
            this.grpAccionesTipoVinculacionCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesTipoVinculacionCRUD.Controls.Add(this.btnGuardar);
            this.grpAccionesTipoVinculacionCRUD.Controls.Add(this.btnNuevo);
            this.grpAccionesTipoVinculacionCRUD.Location = new System.Drawing.Point(23, 279);
            this.grpAccionesTipoVinculacionCRUD.Name = "grpAccionesTipoVinculacionCRUD";
            this.grpAccionesTipoVinculacionCRUD.Size = new System.Drawing.Size(451, 65);
            this.grpAccionesTipoVinculacionCRUD.TabIndex = 7;
            this.grpAccionesTipoVinculacionCRUD.TabStop = false;
            this.grpAccionesTipoVinculacionCRUD.Text = "Acciones";
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
            // grpDotosTipoVinculacionCRUD
            // 
            this.grpDotosTipoVinculacionCRUD.Controls.Add(this.txtDes);
            this.grpDotosTipoVinculacionCRUD.Controls.Add(this.lblDes);
            this.grpDotosTipoVinculacionCRUD.Location = new System.Drawing.Point(23, 63);
            this.grpDotosTipoVinculacionCRUD.Name = "grpDotosTipoVinculacionCRUD";
            this.grpDotosTipoVinculacionCRUD.Size = new System.Drawing.Size(451, 73);
            this.grpDotosTipoVinculacionCRUD.TabIndex = 6;
            this.grpDotosTipoVinculacionCRUD.TabStop = false;
            this.grpDotosTipoVinculacionCRUD.Text = "Datos";
            // 
            // txtDes
            // 
            this.txtDes.Lines = new string[0];
            this.txtDes.Location = new System.Drawing.Point(80, 30);
            this.txtDes.MaxLength = 32767;
            this.txtDes.Name = "txtDes";
            this.txtDes.PasswordChar = '\0';
            this.txtDes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDes.SelectedText = "";
            this.txtDes.Size = new System.Drawing.Size(353, 23);
            this.txtDes.TabIndex = 1;
            this.txtDes.UseSelectable = true;
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(8, 30);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(66, 13);
            this.lblDes.TabIndex = 0;
            this.lblDes.Text = "Descripción:";
            // 
            // frmTiposVinculacionCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 371);
            this.Controls.Add(this.grpListaTipoVinculacionCRUD);
            this.Controls.Add(this.grpAccionesTipoVinculacionCRUD);
            this.Controls.Add(this.grpDotosTipoVinculacionCRUD);
            this.Name = "frmTiposVinculacionCRUD";
            this.Text = "Tipos de Vinculacion";
            this.grpListaTipoVinculacionCRUD.ResumeLayout(false);
            this.grpListaTipoVinculacionCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTiposVinculacionCRUD)).EndInit();
            this.grpAccionesTipoVinculacionCRUD.ResumeLayout(false);
            this.grpDotosTipoVinculacionCRUD.ResumeLayout(false);
            this.grpDotosTipoVinculacionCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListaTipoVinculacionCRUD;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private MetroFramework.Controls.MetroLabel lblFiltar;
        private MetroFramework.Controls.MetroGrid grdTiposVinculacionCRUD;
        private System.Windows.Forms.GroupBox grpAccionesTipoVinculacionCRUD;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private System.Windows.Forms.GroupBox grpDotosTipoVinculacionCRUD;
        private MetroFramework.Controls.MetroTextBox txtDes;
        private System.Windows.Forms.Label lblDes;
    }
}