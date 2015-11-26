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
    public partial class frmCRUDTipoCitas : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        string id = "";
        public frmCRUDTipoCitas()
        {
            InitializeComponent();
        }

        void consultarTipoCitas(string filtro)
        {
            string sSQL = "select id 'ID', destipcit 'Descripcion' " +
                            "from tipo_citas " +
                            "where concat(id,' ',destipcit) like '%" + filtro + "%' ";
            grdTipoCitasCRUD.DataSource = null;
            grdTipoCitasCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarTipoCitas()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "insert into tipo_citas values (null, '" + des + "')";
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarTipoCitas("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscarTipoCita()
        {
            string sSQL;
            sSQL = "select * from tipo_citas where id = " + id;
            DataRow TipoCita = OCNX.ObtenerFila(sSQL);
            if (TipoCita != null)
            {
                txtDescripcion.Text = TipoCita["destipcit"].ToString();
            }
        }

        void actualizarCanal()
        {
            string des, sSQL;
            des = txtDescripcion.Text.Trim();
            sSQL = "update tipo_citas set " +
                    "destipcit = '" + des + "' " +
                    "where id = " + id;
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarTipoCitas("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCRUDTipoCitas_Load(object sender, EventArgs e)
        {
            string filtro = txtFiltrar.Text.Trim();
            consultarTipoCitas(filtro);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                actualizarCanal();
            }
            else
            {
                insertarTipoCitas();
            }
        }

        private void grdTipoCitasCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdTipoCitasCRUD[0, e.RowIndex].Value.ToString();
            buscarTipoCita();
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {

        }
        
       
    }
}
