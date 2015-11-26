namespace frmMenuPrincipal
{
    partial class frmMedicamentos
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
            this.cboNomGen = new System.Windows.Forms.ComboBox();
            this.lblNonGen = new System.Windows.Forms.Label();
            this.cboClase = new System.Windows.Forms.ComboBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.cboTipificacion = new System.Windows.Forms.ComboBox();
            this.lblTipificacion = new System.Windows.Forms.Label();
            this.cboMedida = new System.Windows.Forms.ComboBox();
            this.lblMedida = new System.Windows.Forms.Label();
            this.cboPresentacion = new System.Windows.Forms.ComboBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.cboCanal = new System.Windows.Forms.ComboBox();
            this.lblCanal = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lbeDes = new System.Windows.Forms.Label();
            this.txtCodUni = new System.Windows.Forms.TextBox();
            this.lblCodUni = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.btnNuevo = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.grdMedicamentosCRUD = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicamentosCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboNomGen);
            this.groupBox1.Controls.Add(this.lblNonGen);
            this.groupBox1.Controls.Add(this.cboClase);
            this.groupBox1.Controls.Add(this.lblClase);
            this.groupBox1.Controls.Add(this.cboTipificacion);
            this.groupBox1.Controls.Add(this.lblTipificacion);
            this.groupBox1.Controls.Add(this.cboMedida);
            this.groupBox1.Controls.Add(this.lblMedida);
            this.groupBox1.Controls.Add(this.cboPresentacion);
            this.groupBox1.Controls.Add(this.lblPresentacion);
            this.groupBox1.Controls.Add(this.cboCanal);
            this.groupBox1.Controls.Add(this.lblCanal);
            this.groupBox1.Controls.Add(this.cboMarca);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.txtDes);
            this.groupBox1.Controls.Add(this.lbeDes);
            this.groupBox1.Controls.Add(this.txtCodUni);
            this.groupBox1.Controls.Add(this.lblCodUni);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Medicamento";
            // 
            // cboNomGen
            // 
            this.cboNomGen.FormattingEnabled = true;
            this.cboNomGen.Location = new System.Drawing.Point(106, 150);
            this.cboNomGen.Name = "cboNomGen";
            this.cboNomGen.Size = new System.Drawing.Size(221, 21);
            this.cboNomGen.TabIndex = 17;
            // 
            // lblNonGen
            // 
            this.lblNonGen.AutoSize = true;
            this.lblNonGen.Location = new System.Drawing.Point(9, 153);
            this.lblNonGen.Name = "lblNonGen";
            this.lblNonGen.Size = new System.Drawing.Size(91, 13);
            this.lblNonGen.TabIndex = 16;
            this.lblNonGen.Text = "Nombre genérico:";
            // 
            // cboClase
            // 
            this.cboClase.FormattingEnabled = true;
            this.cboClase.Location = new System.Drawing.Point(425, 119);
            this.cboClase.Name = "cboClase";
            this.cboClase.Size = new System.Drawing.Size(220, 21);
            this.cboClase.TabIndex = 15;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(347, 119);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(36, 13);
            this.lblClase.TabIndex = 14;
            this.lblClase.Text = "Clase:";
            // 
            // cboTipificacion
            // 
            this.cboTipificacion.FormattingEnabled = true;
            this.cboTipificacion.Location = new System.Drawing.Point(425, 87);
            this.cboTipificacion.Name = "cboTipificacion";
            this.cboTipificacion.Size = new System.Drawing.Size(220, 21);
            this.cboTipificacion.TabIndex = 13;
            // 
            // lblTipificacion
            // 
            this.lblTipificacion.AutoSize = true;
            this.lblTipificacion.Location = new System.Drawing.Point(347, 87);
            this.lblTipificacion.Name = "lblTipificacion";
            this.lblTipificacion.Size = new System.Drawing.Size(64, 13);
            this.lblTipificacion.TabIndex = 12;
            this.lblTipificacion.Text = "Tipificación:";
            // 
            // cboMedida
            // 
            this.cboMedida.FormattingEnabled = true;
            this.cboMedida.Location = new System.Drawing.Point(425, 57);
            this.cboMedida.Name = "cboMedida";
            this.cboMedida.Size = new System.Drawing.Size(220, 21);
            this.cboMedida.TabIndex = 11;
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(347, 57);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(45, 13);
            this.lblMedida.TabIndex = 10;
            this.lblMedida.Text = "Medida:";
            // 
            // cboPresentacion
            // 
            this.cboPresentacion.FormattingEnabled = true;
            this.cboPresentacion.Location = new System.Drawing.Point(425, 24);
            this.cboPresentacion.Name = "cboPresentacion";
            this.cboPresentacion.Size = new System.Drawing.Size(220, 21);
            this.cboPresentacion.TabIndex = 9;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(347, 28);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(72, 13);
            this.lblPresentacion.TabIndex = 8;
            this.lblPresentacion.Text = "Presentación:";
            // 
            // cboCanal
            // 
            this.cboCanal.FormattingEnabled = true;
            this.cboCanal.Location = new System.Drawing.Point(106, 119);
            this.cboCanal.Name = "cboCanal";
            this.cboCanal.Size = new System.Drawing.Size(221, 21);
            this.cboCanal.TabIndex = 7;
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Location = new System.Drawing.Point(9, 119);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(37, 13);
            this.lblCanal.TabIndex = 6;
            this.lblCanal.Text = "Canal:";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(106, 87);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(221, 21);
            this.cboMarca.TabIndex = 5;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(9, 87);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(106, 54);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(221, 20);
            this.txtDes.TabIndex = 3;
            // 
            // lbeDes
            // 
            this.lbeDes.AutoSize = true;
            this.lbeDes.Location = new System.Drawing.Point(9, 57);
            this.lbeDes.Name = "lbeDes";
            this.lbeDes.Size = new System.Drawing.Size(96, 13);
            this.lbeDes.TabIndex = 2;
            this.lbeDes.Text = "Nombre Comercial:";
            // 
            // txtCodUni
            // 
            this.txtCodUni.Location = new System.Drawing.Point(106, 25);
            this.txtCodUni.Name = "txtCodUni";
            this.txtCodUni.Size = new System.Drawing.Size(221, 20);
            this.txtCodUni.TabIndex = 1;
            // 
            // lblCodUni
            // 
            this.lblCodUni.AutoSize = true;
            this.lblCodUni.Location = new System.Drawing.Point(9, 28);
            this.lblCodUni.Name = "lblCodUni";
            this.lblCodUni.Size = new System.Drawing.Size(72, 13);
            this.lblCodUni.TabIndex = 0;
            this.lblCodUni.Text = "Código unico:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(23, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(470, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 29);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(246, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 29);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(165, 29);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseSelectable = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFiltro);
            this.groupBox3.Controls.Add(this.lblFiltro);
            this.groupBox3.Controls.Add(this.grdMedicamentosCRUD);
            this.groupBox3.Location = new System.Drawing.Point(23, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de medicamentos";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(425, 16);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(220, 20);
            this.txtFiltro.TabIndex = 9;
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(384, 19);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(35, 13);
            this.lblFiltro.TabIndex = 8;
            this.lblFiltro.Text = "Filtrar:";
            // 
            // grdMedicamentosCRUD
            // 
            this.grdMedicamentosCRUD.AllowUserToResizeRows = false;
            this.grdMedicamentosCRUD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMedicamentosCRUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdMedicamentosCRUD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdMedicamentosCRUD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMedicamentosCRUD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMedicamentosCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMedicamentosCRUD.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdMedicamentosCRUD.EnableHeadersVisualStyles = false;
            this.grdMedicamentosCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdMedicamentosCRUD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMedicamentosCRUD.Location = new System.Drawing.Point(12, 43);
            this.grdMedicamentosCRUD.Name = "grdMedicamentosCRUD";
            this.grdMedicamentosCRUD.ReadOnly = true;
            this.grdMedicamentosCRUD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMedicamentosCRUD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdMedicamentosCRUD.RowHeadersVisible = false;
            this.grdMedicamentosCRUD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMedicamentosCRUD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMedicamentosCRUD.Size = new System.Drawing.Size(639, 119);
            this.grdMedicamentosCRUD.TabIndex = 7;
            this.grdMedicamentosCRUD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMedicamentosCRUD_CellDoubleClick);
            // 
            // frmMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 528);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMedicamentos";
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.frmMedicamentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMedicamentosCRUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lbeDes;
        private System.Windows.Forms.TextBox txtCodUni;
        private System.Windows.Forms.Label lblCodUni;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboPresentacion;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.ComboBox cboCanal;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboClase;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.ComboBox cboTipificacion;
        private System.Windows.Forms.Label lblTipificacion;
        private System.Windows.Forms.ComboBox cboMedida;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.ComboBox cboNomGen;
        private System.Windows.Forms.Label lblNonGen;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroButton btnNuevo;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroGrid grdMedicamentosCRUD;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
    }
}