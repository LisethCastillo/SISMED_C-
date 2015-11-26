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
    public partial class frmCRUDConsultorios : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        string id = "";
        public frmCRUDConsultorios()
        {
            InitializeComponent();
            consultarConsultorios("");
        }

        void consultarConsultorios(string filtro)
        {
            string sSQL = "select id 'ID', codcon 'Codigo', descon 'Descripcion' " +
                            "from consultorios " +
                            "where concat(id,' ',descon,' ',codcon) like '%" + filtro + "%' ";
            grdConsultoriosCRUD.DataSource = null;
            grdConsultoriosCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarConsultorio()
        {
            string des, cod, sSQL;
            cod = txtCodigo.Text.Trim();
            des = txtDescripcion.Text.Trim();            
            sSQL = "insert into consultorios values (null, '" + cod + "', '"+ des +"')";
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarConsultorios("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscarConsultorio()
        {
            string sSQL;
            sSQL = "select * from consultorios where id = " + id;
            DataRow Consultorio = OCNX.ObtenerFila(sSQL);
            if (Consultorio != null)
            {
                txtCodigo.Text = Consultorio["codcon"].ToString();
                txtDescripcion.Text = Consultorio["descon"].ToString();
            }
        }

        void actualizarConsultorios()
        {
            string des, cod, sSQL;
            cod = txtCodigo.Text.Trim();
            des = txtDescripcion.Text.Trim();            
            sSQL = "update consultorios set " +
                    "descon = '" + des + "', " +
                    "codcon = '"+ cod +"' " +
                    "where id = " + id;            
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarConsultorios("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCRUDConsultorios_Load(object sender, EventArgs e)
        {

        }

        private void grdConsultoriosCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdConsultoriosCRUD[0, e.RowIndex].Value.ToString();
            buscarConsultorio();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            consultarConsultorios(filtro);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                actualizarConsultorios();
            }
            else
            {
                insertarConsultorio();
            }
        }        
    }
}
