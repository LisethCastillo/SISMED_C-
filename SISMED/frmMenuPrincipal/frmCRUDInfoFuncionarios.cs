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
    public partial class frmCRUDInfoFuncionarios : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        frmCRUDUsuarios usuarios = null;
        string idusu, sSQL = "";

        public frmCRUDInfoFuncionarios(string id, frmCRUDUsuarios frm)
        {
            this.idusu = id;
            this.usuarios = frm;
            InitializeComponent();
            cargarTipoVinculacion();
            cargarCentros();
            buscarFuncionario();
        }

        void cargarTipoVinculacion()
        {
            sSQL = @"select id, destipvin from tipo_vinculaciones";
            OCNX.CargarCombo(sSQL, cboTipoVinculacion, "destipvin", "id");
        }
        void cargarCentros()
        {
            sSQL = @"SELECT id, nomcen FROM centros";
            OCNX.CargarCombo(sSQL, cboCentro, "nomcen", "id");
        }

        void insertarFuncionario()
        {
            sSQL = string.Format(@" INSERT INTO funcionarios 
                                    VALUES (null, '{0}', '{1}', '{2}')",
                                    cboTipoVinculacion.SelectedValue, cboCentro.SelectedValue, this.idusu);
            OCNX.IniciarTransaccion();
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                OCNX.EjercuarTransaccion();
                MetroMessageBox.Show(this, "Funcionario insertado con exito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuarios.consultarUsuarios("");
                usuarios.nuevo();
                this.Close();
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "Error: no se pudo insertar el Funcionario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarios.eliminarUsuario();
                this.Close();
            }
        }

        void buscarFuncionario()
        {
            if (usuarios.id != "")
            {
                sSQL = String.Format(@"SELECT * FROM funcionarios WHERE usuario_id = '{0}' ", this.idusu);
                DataRow funcionario = OCNX.ObtenerFila(sSQL);
                if (funcionario != null)
                {
                    cboTipoVinculacion.SelectedValue = int.Parse(funcionario["tipo_vinculacione_id"].ToString());
                    cboCentro.SelectedValue = int.Parse(funcionario["centro_id"].ToString());
                }
            }
        }

        void actualizarFuncionario()
        {
            sSQL = string.Format(@" UPDATE funcionarios 
                                    SET tipo_vinculacione_id = '{0}', centro_id = '{1}'
                                    WHERE usuario_id = '{2}' ",
                                    cboTipoVinculacion.SelectedValue, cboCentro.SelectedValue, this.idusu);
            OCNX.IniciarTransaccion();
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                OCNX.EjercuarTransaccion();
                MetroMessageBox.Show(this, "Funcionario actualizado con exito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuarios.consultarUsuarios("");
                usuarios.nuevo();
                this.Close();
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "Error: no se ha actualizar el funcionario!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarios.eliminarUsuario();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboTipoVinculacion.SelectedIndex.Equals(0) || cboCentro.SelectedIndex.Equals(0))
            {
                MetroMessageBox.Show(this, "Debe ingresar todos los items!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (usuarios.id != "")
            {
                DialogResult Result = MetroMessageBox.Show(this, "Confirmar actualización?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    actualizarFuncionario();
                }

            }
            else
            {
                insertarFuncionario();
            }
        }

       

    }
}
