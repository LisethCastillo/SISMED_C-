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
    public partial class frmCRUDRoles : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        String id = "";
        public frmCRUDRoles()
        {
            InitializeComponent();
            consultarRoles("");
        }

        void consultarRoles(string filtro)
        {
            string sSQL = @"SELECT id 'ID', desrol 'Descripcion' 
                            FROM roles 
                            WHERE concat(id,' ',desrol) like '%" + filtro + "%' ";
            grdRolesCRUD.DataSource = null;
            grdRolesCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarRoles()
        {
            string des, sSQL;
            des = txtDes.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM roles WHERE desrol = '{0}'", des);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sSQL = String.Format(@"INSERT INTO roles VALUES (null, '{0}')", des);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Rol insertado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarRoles("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void buscarRol()
        {
            string sSQL;
            sSQL = String.Format(@"SELECT * FROM roles WHERE id = '{0}' ", id);
            DataRow Rol = OCNX.ObtenerFila(sSQL);
            if (Rol != null)
            {
                txtDes.Text = Rol["desrol"].ToString();
            }
        }

        void actualizarRol()
        {
            string des, sSQL;
            des = txtDes.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM roles WHERE desrol = '{0}'", des);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sSQL = String.Format(@"UPDATE roles SET 
                                    desrol = '{0}' 
                                    where id = '{1}'", des, id);
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarRoles("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRolesCRUD_Load(object sender, EventArgs e)
        {

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
                    actualizarRol();
                }

            }
            else
            {
                insertarRoles();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdRolesCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdRolesCRUD[0, e.RowIndex].Value.ToString();
            buscarRol();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            String filtro = txtFiltrar.Text.Trim();
            consultarRoles(filtro);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDes.Text = "";
            txtFiltrar.Text = "";
        }

        private void grdRolesCRUD_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
