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
    public partial class frmCRUDEstados : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        string id = "";
        public frmCRUDEstados()
        {
            InitializeComponent();
            consultarEstados("");
        }

        void consultarEstados(string filtro)
        {
            string sSQL = @"SELECT id 'ID', desest 'Descripcion' 
                            FROM estados 
                            WHERE concat(id,' ',desest) like '%" + filtro + "%' ";
            grdNovedadesCRUD.DataSource = null;
            grdNovedadesCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarEstado()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "INSERT INTO estados VALUES (null, '" + des + "')";
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nuevo();
                consultarEstados("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscarEstado()
        {
            string sSQL;
            sSQL = "SELECT * FROM estados WHERE id = " + id;
            DataRow Estado = OCNX.ObtenerFila(sSQL);
            if (Estado != null)
            {
                txtDescripcion.Text = Estado["desest"].ToString();
            }
        }

        void actualizarEstado()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = String.Format( @"UPDATE estados 
                                    SET desest = '{0}'
                                    WHERE id = '{1}' ",des, id);
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarEstados("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void nuevo()
        {
            txtDescripcion.Text = "";
            txtFiltrar.Text = "";
        }

        private void grdNovedadesCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdNovedadesCRUD[0, e.RowIndex].Value.ToString();
            buscarEstado();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            consultarEstados(filtro);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                actualizarEstado();
            }
            else
            {
                insertarEstado();
            }
        }
        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
