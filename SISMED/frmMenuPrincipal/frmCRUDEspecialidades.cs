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
    public partial class frmCRUDEspecialidades : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        String id = "";
        public frmCRUDEspecialidades()
        {
            InitializeComponent();
            consultarEspecialidades("");
        }

        void consultarEspecialidades(string filtro)
        {
            string sSQL = @"SELECT id 'ID', desesp 'Descripcion' 
                            FROM especialidades 
                            WHERE concat(id,' ',desesp) like '%" + filtro + "%' ";
            grdEspecialidadesCRUD.DataSource = null;
            grdEspecialidadesCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarEspecialidad()
        {
            string des, sSQL;
            des = txtDes.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM especialidades WHERE desesp = '{0}'", des);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sSQL = String.Format(@"INSERT INTO especialidades VALUES (null, '{0}')", des);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Especialidad insertada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarEspecialidades("");
                nuevo();
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void buscarEspecialidades()
        {
            string sSQL;
            sSQL = String.Format(@"SELECT * FROM especialidades WHERE id = '{0}' ", id);
            DataRow Especialidades = OCNX.ObtenerFila(sSQL);
            if (Especialidades != null)
            {
                txtDes.Text = Especialidades["desesp"].ToString();
            }
        }

        void actualizarEspecialidad()
        {
            string des, sSQL;
            des = txtDes.Text.Trim();
            sSQL = String.Format(@"SELECT count(*) FROM especialidades WHERE desesp = '{0}'", des);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta descripción ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sSQL = String.Format(@"UPDATE especialidades SET 
                                    desesp = '{0}' 
                                    where id = '{1}'", des, id);
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Especialidad Actualizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                id = "";
                consultarEspecialidades("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void nuevo()
        {
            txtDes.Text = "";
            txtFiltrar.Text = "";
            id = "";
        }


        private void frmCRUDEspecialidades_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDes.Text.Equals(""))
            {
                MetroMessageBox.Show(this, "Debe ingresar una descripción", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (id != "")
            {
                DialogResult Result = MetroMessageBox.Show(this, "Confirmar actualización?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    actualizarEspecialidad();
                }

            }
            else
            {
                insertarEspecialidad();
            }
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            String filtro = txtFiltrar.Text.Trim();
            consultarEspecialidades(filtro);
        }

        private void grdEspecialidadesCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdEspecialidadesCRUD[0, e.RowIndex].Value.ToString();
            buscarEspecialidades();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
