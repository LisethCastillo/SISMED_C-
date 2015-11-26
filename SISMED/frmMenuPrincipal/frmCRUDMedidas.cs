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
    public partial class frmCRUDMedidas : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        string id = "";

        public frmCRUDMedidas()
        {
            InitializeComponent();
            consultarMedidas("");
        }

        void consultarMedidas(string filtro)
        {
            string sSQL = "select id 'ID', desmed 'Descripcion' " +
                            "from medidas " +
                            "where concat(id,' ',desmed) like '%" + filtro + "%' ";
            grdMedidasCRUD.DataSource = null;
            grdMedidasCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarMedida()
        {
            string des, sSQL, sSQL2;
            des = txtDescripcion.Text.Trim();
            sSQL2 = @"SELECT count(*) FROM medidas WHERE desmed = '" + des + "'";
            if (OCNX.obtenerCatidad(sSQL2) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sSQL = "insert into medidas values (null, '" + des + "')";
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarMedidas("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscarMedida()
        {
            string sSQL;
            sSQL = "select * from medidas where id = " + id;
            DataRow Medida = OCNX.ObtenerFila(sSQL);
            if (Medida != null)
            {
                txtDescripcion.Text = Medida["desmed"].ToString();
            }
        }

        void actualizarMedida()
        {
            string des, sSQL, sSQL2;
            des = txtDescripcion.Text.Trim();
            sSQL2 = @"SELECT count(*) FROM medidas WHERE desmed = '" + des + "'";
            if (OCNX.obtenerCatidad(sSQL2) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sSQL = "update medidas set " +
                    "desmed = '" + des + "' " +
                    "where id = " + id;
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarMedidas("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMedidasCRUD_Load(object sender, EventArgs e)
        {

        }

        private void grdMarcasCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdMedidasCRUD[0, e.RowIndex].Value.ToString();
            buscarMedida();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Equals(""))
            {
                MetroMessageBox.Show(this, "Debe ingresar una descripción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (id != "")
            {
                DialogResult Result = MetroMessageBox.Show(this, "Confirmar actualización?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    actualizarMedida();
                }
            }
            else
            {
                insertarMedida();
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            String filtro = txtFiltrar.Text.Trim();
            consultarMedidas(filtro);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtFiltrar.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
