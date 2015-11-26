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
    public partial class frmCRUDNombreGenerico : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        string id = "";
        public frmCRUDNombreGenerico()
        {
            InitializeComponent();
            consultarNombresGenericos("");
        }

        void consultarNombresGenericos(string filtro)
        {
            string sSQL = "select id 'ID', desnomgen 'Descripcion' " +
                            "from nombre_genericos " +
                            "where concat(id,' ',desnomgen) like '%" + filtro + "%' ";
            grdNombresGenericosCRUD.DataSource = null;
            grdNombresGenericosCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarNombreGenerico()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "insert into nombre_genericos values (null, '" + des + "')";
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarNombresGenericos("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscarNombreGenerico()
        {
            string sSQL;
            sSQL = "select * from nombre_genericos where id = " + id;
            DataRow NombreGenerico = OCNX.ObtenerFila(sSQL);
            if (NombreGenerico != null)
            {
                txtDescripcion.Text = NombreGenerico["desnomgen"].ToString();
            }
        }

        void actualizarNombreGenerico()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "update nombre_genericos set " +
                    "desnomgen = '" + des + "' " +
                    "where id = " + id;
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarNombresGenericos("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCRUDNombreGenerico_Load(object sender, EventArgs e)
        {

        }

        private void grdNombresGenericosCRUD_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = grdNombresGenericosCRUD[0, e.RowIndex].Value.ToString();
            buscarNombreGenerico();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            consultarNombresGenericos(filtro);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                actualizarNombreGenerico();
            }
            else
            {
                insertarNombreGenerico();
            }
        }
    }
}
