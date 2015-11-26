using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace frmMenuPrincipal
{
    public partial class frmCRUDInfoBeneficiarios : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        frmCRUDUsuarios usuarios = null;
        string idusu, sSQL = "";
        public frmCRUDInfoBeneficiarios(string id, frmCRUDUsuarios frm)
        {
            InitializeComponent();
            this.usuarios = frm;
            this.idusu = id;
            cargarLetras();
            cargarFuncionarios();
            cargarParentescos();
            buscarBeneficiario();
        }
        

        void cargarLetras()
        {
            sSQL = @"select id, letlet from letras";
            OCNX.CargarCombo(sSQL, cboLetra, "letlet", "id");
        }

        void cargarParentescos()
        {
            sSQL = @"select id, despar from parentescos";
            OCNX.CargarCombo(sSQL, cboParentesco, "despar", "id");
        }

        void cargarFuncionarios()
        {
            sSQL = @"select fun.id 'id', concat(usu.nomusu,' ',usu.apeusu) 'funcionario'
                            from usuarios usu
                            inner join funcionarios fun 
                            on usu.id = fun.usuario_id;";
            OCNX.CargarCombo(sSQL, cboFuncionario, "funcionario", "fun.id");
        }

        void insertarBeneficiario()
        {
            sSQL = string.Format(@" insert into beneficiarios 
                                    values (null, '{0}', '{1}', '{2}', '{3}')",
                                    cboLetra.SelectedValue, cboParentesco.SelectedValue,
                                    cboFuncionario.SelectedValue, this.idusu);
            OCNX.IniciarTransaccion();
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                OCNX.EjercuarTransaccion();
                MetroMessageBox.Show(this, "Beneficiario insertado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuarios.consultarUsuarios("");
                usuarios.nuevo();
                this.Close();
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "No se ha insertado el Beneficiario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarios.eliminarUsuario();
                this.Close();
            }
        }

        void buscarBeneficiario()
        {
            if (usuarios.id != "") {
                sSQL = String.Format(@"SELECT * FROM beneficiarios WHERE usuario_id = '{0}' ", this.idusu);
                DataRow beneficiario = OCNX.ObtenerFila(sSQL);
                if (beneficiario != null)
                {
                    cboLetra.SelectedValue = int.Parse(beneficiario["letra_id"].ToString());
                    cboParentesco.SelectedValue = int.Parse(beneficiario["parentesco_id"].ToString());
                    cboFuncionario.SelectedValue = int.Parse(beneficiario["funcionario_id"].ToString());
                }
            }
        }

        void actualizarBeneficiario()
        {
            sSQL = string.Format(@" UPDATE beneficiarios 
                                    SET letra_id = '{0}', parentesco_id = '{1}', funcionario_id = '{2}'
                                    WHERE usuario_id = '{3}' ",
                                    cboLetra.SelectedValue, cboParentesco.SelectedValue,
                                    cboFuncionario.SelectedValue, this.idusu);
            OCNX.IniciarTransaccion();
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                OCNX.EjercuarTransaccion();
                MetroMessageBox.Show(this, "Beneficiario actualizado con exito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuarios.consultarUsuarios("");
                usuarios.nuevo();
                this.Close();
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "Error: no se ha actualizar el Beneficiario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarios.eliminarUsuario();
                this.Close();
            }
        }



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (cboLetra.SelectedIndex.Equals(0) || cboParentesco.SelectedIndex.Equals(0) || cboFuncionario.SelectedIndex.Equals(0))
            {
                MetroMessageBox.Show(this, "Debe ingresar todos los items!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (usuarios.id != "")
            {
                DialogResult Result = MetroMessageBox.Show(this, "Confirmar actualización?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    actualizarBeneficiario();
                }

            }
            else
            {
                insertarBeneficiario();
            }
            
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult Result = MetroMessageBox.Show(this, "Cancelar operación?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                if (usuarios.id != "")
                {
                    this.Close();
                }
                else
                {
                    usuarios.eliminarUsuario();
                    this.Close();
                }
            }
        }
    }
}
