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
    public partial class frmCRUDCentros : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        String id = "";
        public frmCRUDCentros()
        {
            InitializeComponent();
            consultarCentros("");
        }

        void consultarCentros(string filtro)
        {
            string sSQL = @"SELECT id 'ID', nomcen 'NOMBRE' 
                            FROM centros 
                            WHERE concat(id,' ',nomcen) like '%" + filtro + "%' ";
            grdCentrosCRUD.DataSource = null;
            grdCentrosCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarCentro()
        {
            string nom, sSQL;
            nom = txtDes.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM centros WHERE nomcen = '{0}'", nom);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sSQL = String.Format(@"INSERT INTO centros VALUES (null, '{0}')", nom);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Parentesco insertado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarCentros("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void buscarCentro()
        {
            string sSQL;
            sSQL = String.Format(@"SELECT * FROM centros WHERE id = '{0}' ", id);
            DataRow Centro = OCNX.ObtenerFila(sSQL);
            if (Centro != null)
            {
                txtDes.Text = Centro["nomcen"].ToString();
            }
        }

        void actualizarCentro()
        {
            string nom, sSQL;
            nom = txtDes.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM centros WHERE nomcen = '{0}'", nom);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Este nombre ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sSQL = String.Format(@"UPDATE centros SET 
                                    nomcen = '{0}' 
                                    where id = '{1}'", nom, id);
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Centro Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarCentros("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            id = "";
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
            consultarCentros(filtro);
        }

        private void grdCentrosCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdCentrosCRUD[0, e.RowIndex].Value.ToString();
            buscarCentro();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDes.Text.Equals(""))
            {
                MetroMessageBox.Show(this, "Debe ingresar un nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (id != "")
            {
                DialogResult Result = MetroMessageBox.Show(this, "Confirmar actualización?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    actualizarCentro();
                }

            }
            else
            {
                insertarCentro();
            }
        }
    }
}
