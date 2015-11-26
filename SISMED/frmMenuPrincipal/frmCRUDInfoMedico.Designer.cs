namespace frmMenuPrincipal
{
    partial class frmCRUDInfoMedico
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
            this.cboEspecialidad = new MetroFramework.Controls.MetroComboBox();
            this.lblEspecialidad = new MetroFramework.Controls.MetroLabel();
            this.grpAccionesGenerosCRUD = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.grpEspecialidadesCRUD = new System.Windows.Forms.GroupBox();
            this.grpDotosMedicosCRUD = new System.Windows.Forms.GroupBox();
            this.lblMedico = new MetroFramework.Controls.MetroLabel();
            this.grdEspecialidadesCRUD = new MetroFramework.Controls.MetroGrid();
            this.grpAccionesGenerosCRUD.SuspendLayout();
            this.grpEspecialidadesCRUD.SuspendLayout();
            this.grpDotosMedicosCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEspecialidadesCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.ItemHeight = 23;
            this.cboEspecialidad.Location = new System.Drawing.Point(112, 28);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(294, 29);
            this.cboEspecialidad.TabIndex = 3;
            this.cboEspecialidad.UseSelectable = true;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(16, 32);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(79, 19);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Epecialidad:";
            // 
            // grpAccionesGenerosCRUD
            // 
            this.grpAccionesGenerosCRUD.Controls.Add(this.btnEliminar);
            this.grpAccionesGenerosCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesGenerosCRUD.Controls.Add(this.btnAgregar);
            this.grpAccionesGenerosCRUD.Controls.Add(this.btnEditar);
            this.grpAccionesGenerosCRUD.Location = new System.Drawing.Point(292, 78);
            this.grpAccionesGenerosCRUD.Name = "grpAccionesGenerosCRUD";
            this.grpAccionesGenerosCRUD.Size = new System.Drawing.Size(114, 190);
            this.grpAccionesGenerosCRUD.TabIndex = 12;
            this.grpAccionesGenerosCRUD.TabStop = false;
            this.grpAccionesGenerosCRUD.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 93);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 31);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 130);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 31);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 56);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 31);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 31);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // grpEspecialidadesCRUD
            // 
            this.grpEspecialidadesCRUD.Controls.Add(this.grpDotosMedicosCRUD);
            this.grpEspecialidadesCRUD.Controls.Add(this.cboEspecialidad);
            this.grpEspecialidadesCRUD.Controls.Add(this.grpAccionesGenerosCRUD);
            this.grpEspecialidadesCRUD.Controls.Add(this.lblEspecialidad);
            this.grpEspecialidadesCRUD.Location = new System.Drawing.Point(23, 63);
            this.grpEspecialidadesCRUD.Name = "grpEspecialidadesCRUD";
            this.grpEspecialidadesCRUD.Size = new System.Drawing.Size(424, 283);
            this.grpEspecialidadesCRUD.TabIndex = 14;
            this.grpEspecialidadesCRUD.TabStop = false;
            this.grpEspecialidadesCRUD.Text = "Especialidades";
            // 
            // grpDotosMedicosCRUD
            // 
            this.grpDotosMedicosCRUD.Controls.Add(this.lblMedico);
            this.grpDotosMedicosCRUD.Controls.Add(this.grdEspecialidadesCRUD);
            this.grpDotosMedicosCRUD.Location = new System.Drawing.Point(16, 78);
            this.grpDotosMedicosCRUD.Name = "grpDotosMedicosCRUD";
            this.grpDotosMedicosCRUD.Size = new System.Drawing.Size(270, 190);
            this.grpDotosMedicosCRUD.TabIndex = 16;
            this.grpDotosMedicosCRUD.TabStop = false;
            this.grpDotosMedicosCRUD.Text = "Lista de especialidades del medico";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(12, 22);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(0, 0);
            this.lblMedico.TabIndex = 12;
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
            this.grdEspecialidadesCRUD.Location = new System.Drawing.Point(10, 51);
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
            this.grdEspecialidadesCRUD.Size = new System.Drawing.Size(254, 133);
            this.grdEspecialidadesCRUD.TabIndex = 11;
            this.grdEspecialidadesCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEspecialidadesCRUD_CellDoubleClick);
            // 
            // frmCRUDInfoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 368);
            this.Controls.Add(this.grpEspecialidadesCRUD);
            this.Name = "frmCRUDInfoMedico";
            this.Text = "Información adicional del medico";
            this.grpAccionesGenerosCRUD.ResumeLayout(false);
            this.grpEspecialidadesCRUD.ResumeLayout(false);
            this.grpEspecialidadesCRUD.PerformLayout();
            this.grpDotosMedicosCRUD.ResumeLayout(false);
            this.grpDotosMedicosCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEspecialidadesCRUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cboEspecialidad;
        private MetroFramework.Controls.MetroLabel lblEspecialidad;
        private System.Windows.Forms.GroupBox grpAccionesGenerosCRUD;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private System.Windows.Forms.GroupBox grpEspecialidadesCRUD;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroGrid grdEspecialidadesCRUD;
        private System.Windows.Forms.GroupBox grpDotosMedicosCRUD;
        private MetroFramework.Controls.MetroLabel lblMedico;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}