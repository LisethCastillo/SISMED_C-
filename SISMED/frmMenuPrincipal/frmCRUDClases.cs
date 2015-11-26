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
    public partial class frmCRUDClases : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        string id = "";
        public frmCRUDClases()
        {
            InitializeComponent();
            consultarClases("");
        }

        void consultarClases(string filtro)
        {
            string sSQL =   "select id 'ID', descla 'Descripcion' " +
                            "from clases " +
                            "where concat(id,' ',descla) like '%" + filtro +"%' ";
            grdClasesCRUD.DataSource = null;
            grdClasesCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarClase()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "insert into clases values (null, '"+des+"')";
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarClases("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscarClase()
        {
            string sSQL;
            sSQL = "select * from clases where id = " + id;
            DataRow Clase = OCNX.ObtenerFila(sSQL);
            if (Clase != null)
            {
                txtDescripcion.Text = Clase["descla"].ToString();                
            }
        }

        void actualizarClase()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();            
            sSQL =  "update clases set " +
                    "descla = '" + des + "' " +
                    "where id = " + id;
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);              
                id = "";
                consultarClases("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClasesCRUD_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                actualizarClase();
            }
            else
            {
                insertarClase();
            }
        }

        private void grdClasesCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdClasesCRUD[0, e.RowIndex].Value.ToString();
            buscarClase();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            consultarClases(filtro);
        }   

        
    }
}
