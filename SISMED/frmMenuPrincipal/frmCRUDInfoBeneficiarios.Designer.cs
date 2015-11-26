namespace frmMenuPrincipal
{
    partial class frmCRUDInfoBeneficiarios
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
            this.grpAccionesBeneficiariosCRUD = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.grpDatosBeneficiariosCRUD = new System.Windows.Forms.GroupBox();
            this.cboFuncionario = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cboParentesco = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboLetra = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.grpAccionesBeneficiariosCRUD.SuspendLayout();
            this.grpDatosBeneficiariosCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccionesBeneficiariosCRUD
            // 
            this.grpAccionesBeneficiariosCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesBeneficiariosCRUD.Controls.Add(this.btnGuardar);
            this.grpAccionesBeneficiariosCRUD.Location = new System.Drawing.Point(23, 221);
            this.grpAccionesBeneficiariosCRUD.Name = "grpAccionesBeneficiariosCRUD";
            this.grpAccionesBeneficiariosCRUD.Size = new System.Drawing.Size(449, 73);
            this.grpAccionesBeneficiariosCRUD.TabIndex = 15;
            this.grpAccionesBeneficiariosCRUD.TabStop = false;
            this.grpAccionesBeneficiariosCRUD.Text = "Acciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(267, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 31);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(255, 31);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // grpDatosBeneficiariosCRUD
            // 
            this.grpDatosBeneficiariosCRUD.Controls.Add(this.cboFuncionario);
            this.grpDatosBeneficiariosCRUD.Controls.Add(this.metroLabel4);
            this.grpDatosBeneficiariosCRUD.Controls.Add(this.cboParentesco);
            this.grpDatosBeneficiariosCRUD.Controls.Add(this.metroLabel2);
            this.grpDatosBeneficiariosCRUD.Controls.Add(this.cboLetra);
            this.grpDatosBeneficiariosCRUD.Controls.Add(this.metroLabel1);
            this.grpDatosBeneficiariosCRUD.Location = new System.Drawing.Point(23, 63);
            this.grpDatosBeneficiariosCRUD.Name = "grpDatosBeneficiariosCRUD";
            this.grpDatosBeneficiariosCRUD.Size = new System.Drawing.Size(449, 152);
            this.grpDatosBeneficiariosCRUD.TabIndex = 14;
            this.grpDatosBeneficiariosCRUD.TabStop = false;
            this.grpDatosBeneficiariosCRUD.Text = "Datos";
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.ItemHeight = 23;
            this.cboFuncionario.Location = new System.Drawing.Point(111, 15);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(317, 29);
            this.cboFuncionario.TabIndex = 7;
            this.cboFuncionario.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Funcionario:";
            // 
            // cboParentesco
            // 
            this.cboParentesco.FormattingEnabled = true;
            this.cboParentesco.ItemHeight = 23;
            this.cboParentesco.Location = new System.Drawing.Point(111, 54);
            this.cboParentesco.Name = "cboParentesco";
            this.cboParentesco.Size = new System.Drawing.Size(317, 29);
            this.cboParentesco.TabIndex = 3;
            this.cboParentesco.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Parentesco:";
            // 
            // cboLetra
            // 
            this.cboLetra.FormattingEnabled = true;
            this.cboLetra.ItemHeight = 23;
            this.cboLetra.Location = new System.Drawing.Point(111, 98);
            this.cboLetra.Name = "cboLetra";
            this.cboLetra.Size = new System.Drawing.Size(317, 29);
            this.cboLetra.TabIndex = 1;
            this.cboLetra.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Letra:";
            // 
            // frmCRUDInfoBeneficiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 319);
            this.Controls.Add(this.grpAccionesBeneficiariosCRUD);
            this.Controls.Add(this.grpDatosBeneficiariosCRUD);
            this.Name = "frmCRUDInfoBeneficiarios";
            this.Text = "Información adicional para el Beneficiarios";
            this.grpAccionesBeneficiariosCRUD.ResumeLayout(false);
            this.grpDatosBeneficiariosCRUD.ResumeLayout(false);
            this.grpDatosBeneficiariosCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccionesBeneficiariosCRUD;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private System.Windows.Forms.GroupBox grpDatosBeneficiariosCRUD;
        private MetroFramework.Controls.MetroComboBox cboFuncionario;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cboParentesco;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboLetra;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}