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
    public partial class frmCRUDPresentaciones : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        String id = "";

        public frmCRUDPresentaciones()
        {
            InitializeComponent();
            consultarPresentaciones("");
        }

        void consultarPresentaciones(String filtro)
        {
            String sSQL = @"SELECT id as 'ID', despre as 'DESCRIPCIÓN' 
                            FROM presentaciones 
                            WHERE concat(id, ' ', despre) like '%"+filtro+"%'";
            grdPresentacionesCRUD.DataSource = null;
            grdPresentacionesCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarPresentacion()
        {
            string des, sSQL, sSQL2;
            des = txtDescripcion.Text.Trim();
            sSQL2 = @"SELECT count(*) FROM presentaciones WHERE despre = '" + des + "'";
            if (OCNX.obtenerCatidad(sSQL2) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sSQL = @"INSERT INTO presentaciones VALUES (null, '"+ des +"')";
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarPresentaciones("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscarPresentacion()
        {
            String sSQL;
            sSQL = @"SELECT * FROM presentaciones WHERE id = " + id;
            DataRow presentacion = OCNX.ObtenerFila(sSQL);
            if (presentacion != null)
            {
                txtDescripcion.Text = presentacion["despre"].ToString();
            }
        }

        void actualizarPresentacion()
        {
            string des, sSQL, sSQL2;
            des = txtDescripcion.Text.Trim();
            sSQL2 = @"SELECT count(*) FROM presentaciones WHERE despre = '" + des + "'";
            if (OCNX.obtenerCatidad(sSQL2) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sSQL = @"UPDATE presentaciones SET despre = '"+ des +"' WHERE id = " + id;
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarPresentaciones("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

      

       
        

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Equals(""))
            {
                MetroMessageBox.Show(this, "Debe ingresar una descripción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (id != "")
            {
                DialogResult Result = MetroMessageBox.Show(this, "Confirmar actualización?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    actualizarPresentacion();
                }
            }
            else
            {
                insertarPresentacion();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtFiltrar.Text = "";
        }

        private void grdPresentacionesCRUD_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id = grdPresentacionesCRUD[0, e.RowIndex].Value.ToString();
            buscarPresentacion();
        }

        private void txtFiltrar_KeyUp_1(object sender, KeyEventArgs e)
        {
            String filtro = txtFiltrar.Text.Trim();
            consultarPresentaciones(filtro);
        }
    }
}
