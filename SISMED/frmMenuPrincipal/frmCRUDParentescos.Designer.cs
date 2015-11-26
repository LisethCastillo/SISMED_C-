namespace frmMenuPrincipal
{
    partial class frmCRUDParentescos
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
            this.grpDotosParentescosCRUD = new System.Windows.Forms.GroupBox();
            this.txtFiltrar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.grdParentCRUD = new MetroFramework.Controls.MetroGrid();
            this.grpListaParentescosCRUD = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.grpAccionesParentescosCRUD = new System.Windows.Forms.GroupBox();
            this.txtDes = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDotosParentescosCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParentCRUD)).BeginInit();
            this.grpListaParentescosCRUD.SuspendLayout();
            this.grpAccionesParentescosCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDotosParentescosCRUD
            // 
            this.grpDotosParentescosCRUD.Controls.Add(this.txtFiltrar);
            this.grpDotosParentescosCRUD.Controls.Add(this.metroLabel2);
            this.grpDotosParentescosCRUD.Controls.Add(this.grdParentCRUD);
            this.grpDotosParentescosCRUD.Location = new System.Drawing.Point(23, 131);
            this.grpDotosParentescosCRUD.Name = "grpDotosParentescosCRUD";
            this.grpDotosParentescosCRUD.Size = new System.Drawing.Size(451, 130);
            this.grpDotosParentescosCRUD.TabIndex = 5;
            this.grpDotosParentescosCRUD.TabStop = false;
            this.grpDotosParentescosCRUD.Text = "Lista de roles";
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
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(288, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Filtrar:";
            // 
            // grdParentCRUD
            // 
            this.grdParentCRUD.AllowUserToResizeRows = false;
            this.grdParentCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdParentCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdParentCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdParentCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdParentCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdParentCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdParentCRUD.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdParentCRUD.EnableHeadersVisualStyles = false;
            this.grdParentCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdParentCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdParentCRUD.Location = new System.Drawing.Point(3, 41);
            this.grdParentCRUD.Name = "grdParentCRUD";
            this.grdParentCRUD.ReadOnly = true;
            this.grdParentCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdParentCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdParentCRUD.RowHeadersVisible = false;
            this.grdParentCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdParentCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdParentCRUD.Size = new System.Drawing.Size(442, 83);
            this.grdParentCRUD.TabIndex = 7;
            this.grdParentCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdParentCRUD_CellDoubleClick);
            // 
            // grpListaParentescosCRUD
            // 
            this.grpListaParentescosCRUD.Controls.Add(this.btnCancelar);
            this.grpListaParentescosCRUD.Controls.Add(this.btnGuardar);
            this.grpListaParentescosCRUD.Controls.Add(this.btnNuevo);
            this.grpListaParentescosCRUD.Location = new System.Drawing.Point(23, 267);
            this.grpListaParentescosCRUD.Name = "grpListaParentescosCRUD";
            this.grpListaParentescosCRUD.Size = new System.Drawing.Size(451, 65);
            this.grpListaParentescosCRUD.TabIndex = 4;
            this.grpListaParentescosCRUD.TabStop = false;
            this.grpListaParentescosCRUD.Text = "Acciones";
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
            // grpAccionesParentescosCRUD
            // 
            this.grpAccionesParentescosCRUD.Controls.Add(this.txtDes);
            this.grpAccionesParentescosCRUD.Controls.Add(this.label1);
            this.grpAccionesParentescosCRUD.Location = new System.Drawing.Point(23, 51);
            this.grpAccionesParentescosCRUD.Name = "grpAccionesParentescosCRUD";
            this.grpAccionesParentescosCRUD.Size = new System.Drawing.Size(451, 73);
            this.grpAccionesParentescosCRUD.TabIndex = 3;
            this.grpAccionesParentescosCRUD.TabStop = false;
            this.grpAccionesParentescosCRUD.Text = "Datos";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción:";
            // 
            // frmParentescosCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.grpAccionesParentescosCRUD);
            this.Controls.Add(this.grpDotosParentescosCRUD);
            this.Controls.Add(this.grpListaParentescosCRUD);
            this.Name = "frmParentescosCRUD";
            this.Text = "Parentescos";
            this.Load += new System.EventHandler(this.frmParentescosCRUD_Load);
            this.grpDotosParentescosCRUD.ResumeLayout(false);
            this.grpDotosParentescosCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParentCRUD)).EndInit();
            this.grpListaParentescosCRUD.ResumeLayout(false);
            this.grpAccionesParentescosCRUD.ResumeLayout(false);
            this.grpAccionesParentescosCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDotosParentescosCRUD;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid grdParentCRUD;
        private System.Windows.Forms.GroupBox grpListaParentescosCRUD;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private System.Windows.Forms.GroupBox grpAccionesParentescosCRUD;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtFiltrar;
        private MetroFramework.Controls.MetroTextBox txtDes;
    }
}