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
    public partial class frmCRUDTiposVinculacion : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        String id = "";

        public frmCRUDTiposVinculacion()
        {
            InitializeComponent();
            consultarTiposVinculaciones("");
        }

        void consultarTiposVinculaciones(string filtro)
        {
            string sSQL = @"SELECT id 'ID', destipvin 'Descripcion' 
                            FROM tipo_vinculaciones 
                            WHERE concat(id,' ',destipvin) like '%" + filtro + "%' ";
            grdTiposVinculacionCRUD.DataSource = null;
            grdTiposVinculacionCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarTipoVinculacion()
        {
            string des, sSQL;
            des = txtDes.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM tipo_vinculaciones WHERE destipvin = '{0}'", des);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sSQL = String.Format(@"INSERT INTO tipo_vinculaciones VALUES (null, '{0}')", des);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Parentesco insertado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarTiposVinculaciones("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void buscarTipoVinculacion()
        {
            string sSQL;
            sSQL = String.Format(@"SELECT * FROM tipo_vinculaciones WHERE id = '{0}' ", id);
            DataRow tipoVinculacion = OCNX.ObtenerFila(sSQL);
            if (tipoVinculacion != null)
            {
                txtDes.Text = tipoVinculacion["destipvin"].ToString();
            }
        }

        void actualizarTipoVinculacion()
        {
            string des, sSQL;
            des = txtDes.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM tipo_vinculaciones WHERE destipvin = '{0}'", des);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sSQL = String.Format(@"UPDATE tipo_vinculaciones SET 
                                    destipvin = '{0}' 
                                    where id = '{1}'", des, id);
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Parentesco Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarTiposVinculaciones("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtDes.Text.Equals(""))
            {
                MetroMessageBox.Show(this, "Debe ingresar una descripción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (id != "")
            {
                DialogResult Result = MetroMessageBox.Show(this, "Confirmar actualización?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    actualizarTipoVinculacion();
                }

            }
            else
            {
                insertarTipoVinculacion();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDes.Text = "";
            txtFiltrar.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            String filtro = txtFiltrar.Text.Trim();
            consultarTiposVinculaciones(filtro);
        }

        private void grdTiposVinculacionCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdTiposVinculacionCRUD[0, e.RowIndex].Value.ToString();
            buscarTipoVinculacion();
        }
    }
}
