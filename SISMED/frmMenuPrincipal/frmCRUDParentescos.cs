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
    public partial class frmCRUDParentescos : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        String id = "";
        public frmCRUDParentescos()
        {
            InitializeComponent();
            consultarParentescos("");
        }

        void consultarParentescos(string filtro)
        {
            string sSQL = @"SELECT id 'ID', despar 'Descripcion' 
                            FROM parentescos 
                            WHERE concat(id,' ',despar) like '%" + filtro + "%' ";
            grdParentCRUD.DataSource = null;
            grdParentCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarParentesco()
        {
            string des, sSQL;
            des = txtDes.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM parentescos WHERE despar = '{0}'", des);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sSQL = String.Format(@"INSERT INTO parentescos VALUES (null, '{0}')", des);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Parentesco insertado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarParentescos("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void buscarParentesco()
        {
            string sSQL;
            sSQL = String.Format(@"SELECT * FROM parentescos WHERE id = '{0}' ", id);
            DataRow Parentesco = OCNX.ObtenerFila(sSQL);
            if (Parentesco != null)
            {
                txtDes.Text = Parentesco["despar"].ToString();
            }
        }

        void actualizarParentesco()
        {
            string des, sSQL;
            des = txtDes.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM parentescos WHERE despar = '{0}'", des);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sSQL = String.Format(@"UPDATE parentescos SET 
                                    despar = '{0}' 
                                    where id = '{1}'", des, id);
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Parentesco Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarParentescos("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmParentescosCRUD_Load(object sender, EventArgs e)
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
                    actualizarParentesco();
                }

            }
            else
            {
                insertarParentesco();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            String filtro = txtFiltrar.Text.Trim();
            consultarParentescos(filtro);
        }

        private void grdParentCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdParentCRUD[0, e.RowIndex].Value.ToString();
            buscarParentesco();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDes.Text = "";
            txtFiltrar.Text = "";
        }
    }
}
