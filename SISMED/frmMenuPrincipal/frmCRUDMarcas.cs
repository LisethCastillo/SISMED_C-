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
    public partial class frmCRUDMarcas : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        string id = "";
        public frmCRUDMarcas()
        {
            InitializeComponent();
            consultarMarcas("");
        }
        void consultarMarcas(string filtro)
        {
            string sSQL = "select id 'ID', desmar 'Descripcion' " +
                            "from marcas " +
                            "where concat(id,' ',desmar) like '%" + filtro + "%' ";
            grdMarcasCRUD.DataSource = null;
            grdMarcasCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarMarca()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "insert into marcas values (null, '" + des + "')";
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarMarcas("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscarMarca()
        {
            string sSQL;
            sSQL = "select * from marcas where id = " + id;
            DataRow Marca = OCNX.ObtenerFila(sSQL);
            if (Marca != null)
            {
                txtDescripcion.Text = Marca["desmar"].ToString();
            }
        }

        void actualizarMarca()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "update marcas set " +
                    "desmar = '" + des + "' " +
                    "where id = " + id;
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarMarcas("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void frmMarcasCRUD_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                actualizarMarca();
            }
            else
            {
                insertarMarca();
            }
        }

        private void grdMarcasCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdMarcasCRUD[0, e.RowIndex].Value.ToString();
            buscarMarca();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            consultarMarcas(filtro);
        }

        
    }
}
