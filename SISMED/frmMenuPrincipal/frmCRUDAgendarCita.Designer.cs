namespace frmMenuPrincipal
{
    partial class frmCRUDAgendarCita
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.cboConsultorio = new MetroFramework.Controls.MetroComboBox();
            this.cboMedico = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblConsultorio = new MetroFramework.Controls.MetroLabel();
            this.txtHoraFin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.cboHoraInicio = new MetroFramework.Controls.MetroComboBox();
            this.lblInicio = new MetroFramework.Controls.MetroLabel();
            this.cboTipocita = new MetroFramework.Controls.MetroComboBox();
            this.lblTipoCita = new MetroFramework.Controls.MetroLabel();
            this.lblMedico = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.grdBeneficiarios = new MetroFramework.Controls.MetroGrid();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.grpAccionesCanalesCRUD = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBeneficiarios)).BeginInit();
            this.grpAccionesCanalesCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroDateTime1);
            this.groupBox1.Controls.Add(this.cboConsultorio);
            this.groupBox1.Controls.Add(this.cboMedico);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.lblConsultorio);
            this.groupBox1.Controls.Add(this.txtHoraFin);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.cboHoraInicio);
            this.groupBox1.Controls.Add(this.lblInicio);
            this.groupBox1.Controls.Add(this.cboTipocita);
            this.groupBox1.Controls.Add(this.lblTipoCita);
            this.groupBox1.Controls.Add(this.lblMedico);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(99, 102);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 20;
            // 
            // cboConsultorio
            // 
            this.cboConsultorio.FormattingEnabled = true;
            this.cboConsultorio.ItemHeight = 23;
            this.cboConsultorio.Location = new System.Drawing.Point(99, 139);
            this.cboConsultorio.Name = "cboConsultorio";
            this.cboConsultorio.Size = new System.Drawing.Size(201, 29);
            this.cboConsultorio.TabIndex = 18;
            this.cboConsultorio.UseSelectable = true;
            // 
            // cboMedico
            // 
            this.cboMedico.FormattingEnabled = true;
            this.cboMedico.ItemHeight = 23;
            this.cboMedico.Location = new System.Drawing.Point(99, 25);
            this.cboMedico.Name = "cboMedico";
            this.cboMedico.Size = new System.Drawing.Size(403, 29);
            this.cboMedico.TabIndex = 17;
            this.cboMedico.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Fecha:";
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Location = new System.Drawing.Point(8, 144);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(79, 19);
            this.lblConsultorio.TabIndex = 13;
            this.lblConsultorio.Text = "Consultorio:";
            // 
            // txtHoraFin
            // 
            this.txtHoraFin.Enabled = false;
            this.txtHoraFin.Lines = new string[0];
            this.txtHoraFin.Location = new System.Drawing.Point(387, 137);
            this.txtHoraFin.MaxLength = 32767;
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.PasswordChar = '\0';
            this.txtHoraFin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoraFin.SelectedText = "";
            this.txtHoraFin.Size = new System.Drawing.Size(115, 31);
            this.txtHoraFin.TabIndex = 12;
            this.txtHoraFin.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(322, 145);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Hora fin:";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // cboHoraInicio
            // 
            this.cboHoraInicio.FormattingEnabled = true;
            this.cboHoraInicio.ItemHeight = 23;
            this.cboHoraInicio.Location = new System.Drawing.Point(387, 102);
            this.cboHoraInicio.Name = "cboHoraInicio";
            this.cboHoraInicio.Size = new System.Drawing.Size(115, 29);
            this.cboHoraInicio.TabIndex = 10;
            this.cboHoraInicio.UseSelectable = true;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(306, 105);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(75, 19);
            this.lblInicio.TabIndex = 9;
            this.lblInicio.Text = "Hora inicio:";
            this.lblInicio.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // cboTipocita
            // 
            this.cboTipocita.FormattingEnabled = true;
            this.cboTipocita.ItemHeight = 23;
            this.cboTipocita.Location = new System.Drawing.Point(99, 60);
            this.cboTipocita.Name = "cboTipocita";
            this.cboTipocita.Size = new System.Drawing.Size(403, 29);
            this.cboTipocita.TabIndex = 5;
            this.cboTipocita.UseSelectable = true;
            // 
            // lblTipoCita
            // 
            this.lblTipoCita.AutoSize = true;
            this.lblTipoCita.Location = new System.Drawing.Point(6, 64);
            this.lblTipoCita.Name = "lblTipoCita";
            this.lblTipoCita.Size = new System.Drawing.Size(81, 19);
            this.lblTipoCita.TabIndex = 4;
            this.lblTipoCita.Text = "Tipo de cita:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(6, 29);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(56, 19);
            this.lblMedico.TabIndex = 0;
            this.lblMedico.Text = "Medico:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroTextBox4);
            this.groupBox2.Controls.Add(this.grdBeneficiarios);
            this.groupBox2.Controls.Add(this.metroComboBox2);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Location = new System.Drawing.Point(23, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 202);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Beneficiario:";
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(373, 24);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.PromptText = "Filtar...";
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.Size = new System.Drawing.Size(129, 30);
            this.metroTextBox4.TabIndex = 25;
            this.metroTextBox4.UseSelectable = true;
            // 
            // grdBeneficiarios
            // 
            this.grdBeneficiarios.AllowUserToResizeRows = false;
            this.grdBeneficiarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdBeneficiarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdBeneficiarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdBeneficiarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBeneficiarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBeneficiarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdBeneficiarios.EnableHeadersVisualStyles = false;
            this.grdBeneficiarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdBeneficiarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdBeneficiarios.Location = new System.Drawing.Point(10, 70);
            this.grdBeneficiarios.Name = "grdBeneficiarios";
            this.grdBeneficiarios.ReadOnly = true;
            this.grdBeneficiarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBeneficiarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdBeneficiarios.RowHeadersVisible = false;
            this.grdBeneficiarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBeneficiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBeneficiarios.Size = new System.Drawing.Size(492, 121);
            this.grdBeneficiarios.TabIndex = 24;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(92, 25);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(275, 29);
            this.metroComboBox2.TabIndex = 10;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 29);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Beneficiario:";
            // 
            // grpAccionesCanalesCRUD
            // 
            this.grpAccionesCanalesCRUD.Controls.Add(this.btnGuardar);
            this.grpAccionesCanalesCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesCanalesCRUD.Location = new System.Drawing.Point(23, 455);
            this.grpAccionesCanalesCRUD.Name = "grpAccionesCanalesCRUD";
            this.grpAccionesCanalesCRUD.Size = new System.Drawing.Size(521, 65);
            this.grpAccionesCanalesCRUD.TabIndex = 36;
            this.grpAccionesCanalesCRUD.TabStop = false;
            this.grpAccionesCanalesCRUD.Text = "Acciones";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(10, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(242, 30);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Agendar Cita";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(270, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(232, 30);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            // 
            // frmCRUDAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 535);
            this.Controls.Add(this.grpAccionesCanalesCRUD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCRUDAgendarCita";
            this.Text = "Agendar Cita";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBeneficiarios)).EndInit();
            this.grpAccionesCanalesCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cboHoraInicio;
        private MetroFramework.Controls.MetroLabel lblInicio;
        private MetroFramework.Controls.MetroComboBox cboTipocita;
        private MetroFramework.Controls.MetroLabel lblTipoCita;
        private MetroFramework.Controls.MetroLabel lblMedico;
        private MetroFramework.Controls.MetroTextBox txtHoraFin;
        private MetroFramework.Controls.MetroLabel lblConsultorio;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private System.Windows.Forms.GroupBox grpAccionesCanalesCRUD;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroComboBox cboConsultorio;
        private MetroFramework.Controls.MetroComboBox cboMedico;
        private MetroFramework.Controls.MetroGrid grdBeneficiarios;
    }
}