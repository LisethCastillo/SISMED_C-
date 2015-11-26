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
    public partial class frmCRUDCanales : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        string id = "";
        public frmCRUDCanales()
        {
            InitializeComponent();
            consultarCanales("");
        }

        void consultarCanales(string filtro)
        {
            string sSQL = "select id 'ID', descan 'Descripcion' " +
                            "from canales " +
                            "where concat(id,' ',descan) like '%" + filtro + "%' ";
            grdCanalesCRUD.DataSource = null;
            grdCanalesCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarCanal()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "insert into canales values (null, '" + des + "')";
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarCanales("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscarCanal()
        {
            string sSQL;
            sSQL = "select * from canales where id = " + id;
            DataRow Canal = OCNX.ObtenerFila(sSQL);
            if (Canal != null)
            {
                txtDescripcion.Text = Canal["descan"].ToString();
            }
        }

        void actualizarCanal()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "update canales set " +
                    "descan = '" + des + "' " +
                    "where id = " + id;
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarCanales("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCRUDCanales_Load(object sender, EventArgs e)
        {

        }
                
        private void grdCanalesCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdCanalesCRUD[0, e.RowIndex].Value.ToString();
            buscarCanal();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            consultarCanales(filtro);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (id != "")
            {
                actualizarCanal();
            }
            else
            {
                insertarCanal();
            }
        }
    }
}
