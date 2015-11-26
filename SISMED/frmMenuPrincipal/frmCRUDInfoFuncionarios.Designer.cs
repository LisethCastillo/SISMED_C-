namespace frmMenuPrincipal
{
    partial class frmCRUDInfoFuncionarios
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
            this.grpAccionesFuncionarioCRUD = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.grpDatosFuncionarioCRUD = new System.Windows.Forms.GroupBox();
            this.cboTipoVinculacion = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cboCentro = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.grpAccionesFuncionarioCRUD.SuspendLayout();
            this.grpDatosFuncionarioCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccionesFuncionarioCRUD
            // 
            this.grpAccionesFuncionarioCRUD.Controls.Add(this.btnCancelar);
            this.grpAccionesFuncionarioCRUD.Controls.Add(this.btnGuardar);
            this.grpAccionesFuncionarioCRUD.Location = new System.Drawing.Point(23, 175);
            this.grpAccionesFuncionarioCRUD.Name = "grpAccionesFuncionarioCRUD";
            this.grpAccionesFuncionarioCRUD.Size = new System.Drawing.Size(449, 73);
            this.grpAccionesFuncionarioCRUD.TabIndex = 17;
            this.grpAccionesFuncionarioCRUD.TabStop = false;
            this.grpAccionesFuncionarioCRUD.Text = "Acciones";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(267, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 31);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 21);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(255, 31);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpDatosFuncionarioCRUD
            // 
            this.grpDatosFuncionarioCRUD.Controls.Add(this.cboTipoVinculacion);
            this.grpDatosFuncionarioCRUD.Controls.Add(this.metroLabel4);
            this.grpDatosFuncionarioCRUD.Controls.Add(this.cboCentro);
            this.grpDatosFuncionarioCRUD.Controls.Add(this.metroLabel2);
            this.grpDatosFuncionarioCRUD.Location = new System.Drawing.Point(23, 63);
            this.grpDatosFuncionarioCRUD.Name = "grpDatosFuncionarioCRUD";
            this.grpDatosFuncionarioCRUD.Size = new System.Drawing.Size(449, 106);
            this.grpDatosFuncionarioCRUD.TabIndex = 16;
            this.grpDatosFuncionarioCRUD.TabStop = false;
            this.grpDatosFuncionarioCRUD.Text = "Datos";
            // 
            // cboTipoVinculacion
            // 
            this.cboTipoVinculacion.FormattingEnabled = true;
            this.cboTipoVinculacion.ItemHeight = 23;
            this.cboTipoVinculacion.Location = new System.Drawing.Point(142, 60);
            this.cboTipoVinculacion.Name = "cboTipoVinculacion";
            this.cboTipoVinculacion.Size = new System.Drawing.Size(286, 29);
            this.cboTipoVinculacion.TabIndex = 7;
            this.cboTipoVinculacion.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 64);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(124, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Tipo de vinculación:";
            // 
            // cboCentro
            // 
            this.cboCentro.FormattingEnabled = true;
            this.cboCentro.ItemHeight = 23;
            this.cboCentro.Location = new System.Drawing.Point(142, 25);
            this.cboCentro.Name = "cboCentro";
            this.cboCentro.Size = new System.Drawing.Size(286, 29);
            this.cboCentro.TabIndex = 3;
            this.cboCentro.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Centro:";
            // 
            // frmCRUDInfoFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 273);
            this.Controls.Add(this.grpAccionesFuncionarioCRUD);
            this.Controls.Add(this.grpDatosFuncionarioCRUD);
            this.Name = "frmCRUDInfoFuncionarios";
            this.Text = "Información adicional para Funcionario";
            this.grpAccionesFuncionarioCRUD.ResumeLayout(false);
            this.grpDatosFuncionarioCRUD.ResumeLayout(false);
            this.grpDatosFuncionarioCRUD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccionesFuncionarioCRUD;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private System.Windows.Forms.GroupBox grpDatosFuncionarioCRUD;
        private MetroFramework.Controls.MetroComboBox cboTipoVinculacion;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cboCentro;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}