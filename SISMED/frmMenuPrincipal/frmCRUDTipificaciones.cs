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
    public partial class frmCRUDTipificaciones : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        string id = "";
        public frmCRUDTipificaciones()
        {
            InitializeComponent();
            consultarTipificaciones("");
        }

        void consultarTipificaciones(string filtro)
        {
            string sSQL = "select id 'ID', destip 'Descripcion' " +
                            "from tipificaciones " +
                            "where concat(id,' ',destip) like '%" + filtro + "%' ";
            grdTipificacionesCRUD.DataSource = null;
            grdTipificacionesCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarTipificacion()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "insert into tipificaciones values (null, '" + des + "')";
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarTipificaciones("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscarTipificacion()
        {
            string sSQL;
            sSQL = "select * from tipificaciones where id = " + id;
            DataRow Tipificacion = OCNX.ObtenerFila(sSQL);
            if (Tipificacion != null)
            {
                txtDescripcion.Text = Tipificacion["destip"].ToString();
            }
        }

        void actualizarTipificacion()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "update tipificaciones set " +
                    "destip = '" + des + "' " +
                    "where id = " + id;
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarTipificaciones("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCRUDTipificaciones_Load(object sender, EventArgs e)
        {

        }

        private void grdTipificacionesCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdTipificacionesCRUD[0, e.RowIndex].Value.ToString();
            buscarTipificacion();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            consultarTipificaciones(filtro);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                actualizarTipificacion();
            }
            else
            {
                insertarTipificacion();
            }
        }

        private void grpDatosTipificacionesCRUD_Enter(object sender, EventArgs e)
        {

        }        
    }
}
