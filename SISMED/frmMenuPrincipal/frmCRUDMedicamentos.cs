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
using System.Diagnostics;

namespace frmMenuPrincipal
{
    public partial class frmMedicamentos : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        string id = "";

        public frmMedicamentos()
        {
            InitializeComponent();
            consultarMedicamentos("");
            cargarCboMarcas();
            cargarCboCanles();
            cargarCboNomGenericos();
            cargarCboPresentaciones();
            cargarCboMedidas();
            cargarCboTipifi();
            cargarCboClases();
        }
        void cargarCboMarcas()
        {
            String sSQL = "";
            sSQL = @"select id, desmar from marcas";
            OCNX.CargarCombo(sSQL,cboMarca,"desmar", "id");
        }
        void cargarCboCanles()
        {
            String sSQL = "";
            sSQL = @"select id, descan from canales";
            OCNX.CargarCombo(sSQL, cboCanal, "descan", "id");
        }
        void cargarCboNomGenericos()
        {
            String sSQL = "";
            sSQL = @"select id, desnomgen from nombre_genericos";
            OCNX.CargarCombo(sSQL, cboNomGen, "desnomgen", "id");
        }
        void cargarCboPresentaciones()
        {
            String sSQL = "";
            sSQL = @"select id, despre from presentaciones";
            OCNX.CargarCombo(sSQL, cboPresentacion, "despre", "id");
        }
        void cargarCboMedidas()
        {
            String sSQL = "";
            sSQL = @"select id, desmed from medidas";
            OCNX.CargarCombo(sSQL, cboMedida, "desmed", "id");
        }
        void cargarCboTipifi()
        {
            String sSQL = "";
            sSQL = @"select id, destip from tipificaciones";
            OCNX.CargarCombo(sSQL, cboTipificacion, "destip", "id");
        }
        void cargarCboClases()
        {
            String sSQL = "";
            sSQL = @"select id, descla from clases";
            OCNX.CargarCombo(sSQL, cboClase, "descla", "id");
        }

        void consultarMedicamentos(string filtro)
        {
            string sSQL = @"SELECT med.id 'ID', plumed 'Codigo unico', med.nomcommed 'Descripcion', desmar 'Marca',
                            descan 'Canales', despre 'Presentacion', medi.desmed 'Medida', destip 'Tipificacion',
                            descla 'Clase', desnomgen 'Nombre generico'
                            FROM medicamentos med
                            INNER JOIN marcas mar ON med.Marca_id = mar.id
                            INNER JOIN canales can ON med.Canale_id = can.id
                            INNER JOIN presentaciones pre ON med.Presentacione_id = pre.id
                            INNER JOIN medidas medi ON med.Medida_id = medi.id
                            INNER JOIN tipificaciones tip ON med.Tipificacione_id = tip.id
                            INNER JOIN clases cla ON med.Clase_id = cla.id
                            INNER JOIN nombre_genericos nomgen ON med.Nombre_Generico_id = nomgen.id
                            where concat(med.id,' ',plumed,' ',med.nomcommed) like '%" + filtro + "%' ";
            grdMedicamentosCRUD.DataSource = null;
            grdMedicamentosCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
        }

        void insertarMedicamento()
        {
            string codUni, des, sSQL;
            int marca, canal, presen, medida, tipifi, clase, nomGen;
            codUni = txtCodUni.Text.Trim();
            des = txtDes.Text.Trim();
            marca = int.Parse(cboMarca.SelectedValue.ToString());
            canal = int.Parse(cboCanal.SelectedValue.ToString());
            presen = int.Parse(cboPresentacion.SelectedValue.ToString());
            medida = int.Parse(cboMedida.SelectedValue.ToString());
            tipifi = int.Parse(cboTipificacion.SelectedValue.ToString());
            clase = int.Parse(cboClase.SelectedValue.ToString());
            nomGen = int.Parse(cboNomGen.SelectedValue.ToString());
            sSQL = @"SELECT count(*) FROM medicamentos WHERE plumed = '" + codUni + "'";
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta Medicamento ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sSQL = String.Format(@"INSERT INTO medicamentos VALUES (null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", 
                                  codUni,des,marca,canal,presen,medida,tipifi,clase,nomGen);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Medicamento insertado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarMedicamentos("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void buscarMedicamento()
        {
            string sSQL;
            sSQL = String.Format(@"SELECT * FROM medicamentos WHERE id = '{0}'", id);
            DataRow Medicamento = OCNX.ObtenerFila(sSQL);
            Debug.WriteLine(Medicamento);
            
            if (Medicamento != null)
            {
                txtCodUni.Text = Medicamento["plumed"].ToString();
                txtDes.Text = Medicamento["nomcommed"].ToString();
                cboCanal.SelectedValue = int.Parse(Medicamento["canale_id"].ToString());
                cboClase.SelectedValue = int.Parse(Medicamento["clase_id"].ToString());
                cboMarca.SelectedValue = int.Parse(Medicamento["marca_id"].ToString());
                cboMedida.SelectedValue = int.Parse(Medicamento["medida_id"].ToString());
                cboNomGen.SelectedValue = int.Parse(Medicamento["nombre_generico_id"].ToString());
                cboPresentacion.SelectedValue = int.Parse(Medicamento["presentacione_id"].ToString());
                cboTipificacion.SelectedValue = int.Parse(Medicamento["tipificacione_id"].ToString());
            }
        }

        void actualizarMedicamento()
        {
            string codUni, des, sSQL;
            int marca, canal, presen, medida, tipifi, clase, nomGen;
            codUni = txtCodUni.Text.Trim();
            des = txtDes.Text.Trim();
            marca = int.Parse(cboMarca.SelectedValue.ToString());
            canal = int.Parse(cboCanal.SelectedValue.ToString());
            presen = int.Parse(cboPresentacion.SelectedValue.ToString());
            medida = int.Parse(cboMedida.SelectedValue.ToString());
            tipifi = int.Parse(cboTipificacion.SelectedValue.ToString());
            clase = int.Parse(cboClase.SelectedValue.ToString());
            nomGen = int.Parse(cboNomGen.SelectedValue.ToString());
            sSQL = String.Format(@"SELECT count(*) FROM medicamentos WHERE nomcommed = '{0}' AND plumed = '{1}'", des, codUni);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Esta medicamento ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sSQL = String.Format(@"UPDATE medicamentos SET plumed = '{0}', nomcommed = '{1}', marca_id = '{2}', canale_id = '{3}',
                                 presentacione_id = '{4}', medida_id = '{5}', tipificacione_id = '{6}', clase_id = '{7}', nombre_generico_id = '{8}' WHERE id = '{9}'",
                                 codUni, des, marca, canal, presen, medida, tipifi, clase, nomGen, id);
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                id = "";
                MetroMessageBox.Show(this, "Medicamento Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarMedicamentos("");
            }
            else
            {
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodUni.Text.Equals("") || txtDes.Text.Equals("") || cboCanal.SelectedIndex.Equals(0) || cboMarca.SelectedIndex.Equals(0) || cboPresentacion.SelectedIndex.Equals(0) || cboMedida.SelectedIndex.Equals(0) || cboTipificacion.SelectedIndex.Equals(0) || cboNomGen.SelectedIndex.Equals(0) || cboClase.SelectedIndex.Equals(0))
            {

                MetroMessageBox.Show(this, "Debe ingresar todos los items!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (id != "")
            {
                DialogResult Result = MetroMessageBox.Show(this, "Confirmar actualización?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    actualizarMedicamento();   
                }

            }
            else
            {
                insertarMedicamento();
            }
        }
        

        private void grdMedicamentosCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdMedicamentosCRUD[0, e.RowIndex].Value.ToString();
            buscarMedicamento();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro = txtFiltro.Text.Trim();
            consultarMedicamentos(filtro);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            id = "";
            txtCodUni.Text = "";
            txtDes.Text = "";
            txtFiltro.Text = "";
            cargarCboMarcas();
            cargarCboCanles();
            cargarCboNomGenericos();
            cargarCboPresentaciones();
            cargarCboMedidas();
            cargarCboTipifi();
            cargarCboClases();
        }

        private void frmMedicamentos_Load(object sender, EventArgs e)
        {

        }
    }
}
