namespace frmMenuPrincipal
{
    partial class frmCRUDCentros
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
            this.grpAccionesCentrosCRUD = new System.Windows.Forms.GroupBox();
            this.txtDes = new MetroFramework.Controls.MetroTextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.grpDotosCentrosCRUD = new System.Windows.Forms.GroupBox();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.lblFiltar = new MetroFramework.Controls.MetroLabel();
            this.grdCentrosCRUD = new MetroFramework.Controls.MetroGrid();
            this.grpListaCentrosCRUD = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.grpAccionesCentrosCRUD.SuspendLayout();
            this.grpDotosCentrosCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCentrosCRUD)).BeginInit();
            this.grpListaCentrosCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccionesCentrosCRUD
            // 
            this.grpAccionesCentrosCRUD.Controls.Add(this.txtDes);
            this.grpAccionesCentrosCRUD.Controls.Add(this.lblDes);
            this.grpAccionesCentrosCRUD.Location = new System.Drawing.Point(23, 63);
            this.grpAccionesCentrosCRUD.Name = "grpAccionesCentrosCRUD";
            this.grpAccionesCentrosCRUD.Size = new System.Drawing.Size(451, 73);
            this.grpAccionesCentrosCRUD.TabIndex = 6;
            this.grpAccionesCentrosCRUD.TabStop = false;
            this.grpAccionesCentrosCRUD.Text = "Datos";
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
            // grpDotosCentrosCRUD
            // 
            this.grpDotosCentrosCRUD.Controls.Add(this.txtFiltrar);
            this.grpDotosCentrosCRUD.Controls.Add(this.lblFiltar);
            this.grpDotosCentrosCRUD.Controls.Add(this.grdCentrosCRUD);
            this.grpDotosCentrosCRUD.Location = new System.Drawing.Point(23, 143);
            this.grpDotosCentrosCRUD.Name = "grpDotosCentrosCRUD";
            this.grpDotosCentrosCRUD.Size = new System.Drawing.Size(451, 130);
            this.grpDotosCentrosCRUD.TabIndex = 8;
            this.grpDotosCentrosCRUD.TabStop = false;
            this.grpDotosCentrosCRUD.Text = "Lista de roles";
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
            // grdCentrosCRUD
            // 
            this.grdCentrosCRUD.AllowUserToResizeRows = false;
            this.grdCentrosCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCentrosCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCentrosCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdCentrosCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCentrosCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdCentrosCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCentrosCRUD.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdCentrosCRUD.EnableHeadersVisualStyles = false;
            this.grdCentrosCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdCentrosCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdCentrosCRUD.Location = new System.Drawing.Point(3, 41);
            this.grdCentrosCRUD.Name = "grdCentrosCRUD";
            this.grdCentrosCRUD.ReadOnly = true;
            this.grdCentrosCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCentrosCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdCentrosCRUD.RowHeadersVisible = false;
            this.grdCentrosCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdCentrosCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCentrosCRUD.Size = new System.Drawing.Size(442, 83);
            this.grdCentrosCRUD.TabIndex = 7;
            this.grdCentrosCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCentrosCRUD_CellDoubleClick);
            // 
            // grpListaCentrosCRUD
            // 
            this.grpListaCentrosCRUD.Controls.Add(this.btnCancelar);
            this.grpListaCentrosCRUD.Controls.Add(this.btnGuardar);
            this.grpListaCentrosCRUD.Controls.Add(this.btnNuevo);
            this.grpListaCentrosCRUD.Location = new System.Drawing.Point(23, 279);
            this.grpListaCentrosCRUD.Name = "grpListaCentrosCRUD";
            this.grpListaCentrosCRUD.Size = new System.Drawing.Size(451, 65);
            this.grpListaCentrosCRUD.TabIndex = 7;
            this.grpListaCentrosCRUD.TabStop = false;
            this.grpListaCentrosCRUD.Text = "Acciones";
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
            // frmCentrosCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 370);
            this.Controls.Add(this.grpAccionesCentrosCRUD);
            this.Controls.Add(this.grpDotosCentrosCRUD);
            this.Controls.Add(this.grpListaCentrosCRUD);
            this.Name = "frmCentrosCRUD";
            this.Text = "Centros";
            this.grpAccionesCentrosCRUD.ResumeLayout(false);
            this.grpAccionesCentrosCRUD.PerformLayout();
            this.grpDotosCentrosCRUD.ResumeLayout(false);
            this.grpDotosCentrosCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCentrosCRUD)).EndInit();
            this.grpListaCentrosCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccionesCentrosCRUD;
        private MetroFramework.Controls.MetroTextBox txtDes;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.GroupBox grpDotosCentrosCRUD;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private MetroFramework.Controls.MetroLabel lblFiltar;
        private MetroFramework.Controls.MetroGrid grdCentrosCRUD;
        private System.Windows.Forms.GroupBox grpListaCentrosCRUD;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnNuevo;
    }
}