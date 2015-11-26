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
    public partial class frmCRUDLetras : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        String id = "";
        public frmCRUDLetras()
        {
            InitializeComponent();
            consultarLetras("");
        }

        void consultarLetras(string filtro)
        {
            string sSQL = @"SELECT id 'ID', letlet 'Letra' 
                            FROM letras 
                            WHERE concat(id,' ',letlet) like '%" + filtro + "%' ";
            grdLetrasCRUD.DataSource = null;
            grdLetrasCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarLetra()
        {
            string letra, sSQL;
            letra = txtLetra.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM letras WHERE letlet = '{0}'", letra);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta letra ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sSQL = String.Format(@"INSERT INTO letras VALUES (null, '{0}')", letra);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Letra insertado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarLetras("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void buscarLetra()
        {
            string sSQL;
            sSQL = String.Format(@"SELECT * FROM letras WHERE id = '{0}' ", id);
            DataRow Letras = OCNX.ObtenerFila(sSQL);
            if (Letras != null)
            {
                txtLetra.Text = Letras["letlet"].ToString();
            }
        }

        void actualizarLetra()
        {
            string letra, sSQL;
            letra = txtLetra.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM letras WHERE letlet = '{0}'", letra);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta letra ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sSQL = String.Format(@"UPDATE letras SET 
                                    letlet = '{0}' 
                                    where id = '{1}'", letra, id);
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Letra Actualizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarLetras("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            String filtro = txtFiltrar.Text.Trim();
            consultarLetras(filtro);
        }

        private void grdLetrasCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdLetrasCRUD[0, e.RowIndex].Value.ToString();
            buscarLetra();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtLetra.Text.Equals(""))
            {
                MetroMessageBox.Show(this, "Debe ingresar una letra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (id != "")
            {
                DialogResult Result = MetroMessageBox.Show(this, "Confirmar actualización?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    actualizarLetra();
                }

            }
            else
            {
                insertarLetra();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtLetra.Text = "";
            txtFiltrar.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
