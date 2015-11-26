namespace frmMenuPrincipal
{
    partial class frmCRUDLetras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpAccionesLetrasCRUD = new System.Windows.Forms.GroupBox();
            this.grpDotosLetrasCRUD = new System.Windows.Forms.GroupBox();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.lblFiltrar = new MetroFramework.Controls.MetroLabel();
            this.grdLetrasCRUD = new MetroFramework.Controls.MetroGrid();
            this.grpListaLetrasCRUD = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtLetra = new MetroFramework.Controls.MetroTextBox();
            this.grpAccionesLetrasCRUD.SuspendLayout();
            this.grpDotosLetrasCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLetrasCRUD)).BeginInit();
            this.grpListaLetrasCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccionesLetrasCRUD
            // 
            this.grpAccionesLetrasCRUD.Controls.Add(this.txtLetra);
            this.grpAccionesLetrasCRUD.Controls.Add(this.metroLabel1);
            this.grpAccionesLetrasCRUD.Location = new System.Drawing.Point(23, 54);
            this.grpAccionesLetrasCRUD.Name = "grpAccionesLetrasCRUD";
            this.grpAccionesLetrasCRUD.Size = new System.Drawing.Size(451, 77);
            this.grpAccionesLetrasCRUD.TabIndex = 9;
            this.grpAccionesLetrasCRUD.TabStop = false;
            this.grpAccionesLetrasCRUD.Text = "Datos";
            // 
            // grpDotosLetrasCRUD
            // 
            this.grpDotosLetrasCRUD.Controls.Add(this.txtFiltrar);
            this.grpDotosLetrasCRUD.Controls.Add(this.lblFiltrar);
            this.grpDotosLetrasCRUD.Controls.Add(this.grdLetrasCRUD);
            this.grpDotosLetrasCRUD.Location = new System.Drawing.Point(23, 137);
            this.grpDotosLetrasCRUD.Name = "grpDotosLetrasCRUD";
            this.grpDotosLetrasCRUD.Size = new System.Drawing.Size(451, 130);
            this.grpDotosLetrasCRUD.TabIndex = 11;
            this.grpDotosLetrasCRUD.TabStop = false;
            this.grpDotosLetrasCRUD.Text = "Lista de roles";
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
            // grdLetrasCRUD
            // 
            this.grdLetrasCRUD.AllowUserToResizeRows = false;
            this.grdLetrasCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdLetrasCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdLetrasCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdLetrasCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLetrasCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdLetrasCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLetrasCRUD.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdLetrasCRUD.EnableHeadersVisualStyles = false;
            this.grdLetrasCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdLetrasCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdLetrasCRUD.Location = new System.Drawing.Point(3, 41);
            this.grdLetrasCRUD.Name = "grdLetrasCRUD";
            this.grdLetrasCRUD.ReadOnly = true;
            this.grdLetrasCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLetrasCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdLetrasCRUD.RowHeadersVisible = false;
            this.grdLetrasCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdLetrasCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLetrasCRUD.Size = new System.Drawing.Size(442, 83);
            this.grdLetrasCRUD.TabIndex = 7;
            this.grdLetrasCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLetrasCRUD_CellDoubleClick);
            // 
            // grpListaLetrasCRUD
            // 
            this.grpListaLetrasCRUD.Controls.Add(this.btnCancelar);
            this.grpListaLetrasCRUD.Controls.Add(this.btnGuardar);
            this.grpListaLetrasCRUD.Controls.Add(this.btnNuevo);
            this.grpListaLetrasCRUD.Location = new System.Drawing.Point(23, 273);
            this.grpListaLetrasCRUD.Name = "grpListaLetrasCRUD";
            this.grpListaLetrasCRUD.Size = new System.Drawing.Size(451, 65);
            this.grpListaLetrasCRUD.TabIndex = 10;
            this.grpListaLetrasCRUD.TabStop = false;
            this.grpListaLetrasCRUD.Text = "Acciones";
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Letra:";
            // 
            // txtLetra
            // 
            this.txtLetra.Lines = new string[0];
            this.txtLetra.Location = new System.Drawing.Point(91, 28);
            this.txtLetra.MaxLength = 32767;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.PasswordChar = '\0';
            this.txtLetra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLetra.SelectedText = "";
            this.txtLetra.Size = new System.Drawing.Size(342, 23);
            this.txtLetra.TabIndex = 4;
            this.txtLetra.UseSelectable = true;
            // 
            // frmLetrasCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 365);
            this.Controls.Add(this.grpAccionesLetrasCRUD);
            this.Controls.Add(this.grpDotosLetrasCRUD);
            this.Controls.Add(this.grpListaLetrasCRUD);
            this.Name = "frmLetrasCRUD";
            this.Text = "Letras";
            this.grpAccionesLetrasCRUD.ResumeLayout(false);
            this.grpAccionesLetrasCRUD.PerformLayout();
            this.grpDotosLetrasCRUD.ResumeLayout(false);
            this.grpDotosLetrasCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLetrasCRUD)).EndInit();
            this.grpListaLetrasCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccionesLetrasCRUD;
        private System.Windows.Forms.GroupBox grpDotosLetrasCRUD;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private MetroFramework.Controls.MetroLabel lblFiltrar;
        private MetroFramework.Controls.MetroGrid grdLetrasCRUD;
        private System.Windows.Forms.GroupBox grpListaLetrasCRUD;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private MetroFramework.Controls.MetroTextBox txtLetra;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}