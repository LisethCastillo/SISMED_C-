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
    public partial class frmCRUDInfoMedico : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        frmCRUDUsuarios usu = null;
        String sSQL;
        String id = "", idespe = "";
        public String datoMedico = "";
        int idmedico = 0;

        public frmCRUDInfoMedico(String dato, frmCRUDUsuarios usuarios)
        {
            this.usu = usuarios;
            this.id = dato;
            InitializeComponent();
            cargarCboEspecialidades();
        }

        void cargarCboEspecialidades()
        {
            sSQL = @"select id, desesp from especialidades";
            OCNX.CargarCombo(sSQL, cboEspecialidad, "desesp", "id");
        }

        //Metodo utilizado desde el frmCRUDUsuarios, para obtener el id de medico de un usuario.
        public void buscarMedicoUsuario()
        {
            sSQL = String.Format(@"SELECT id FROM medicos WHERE usuario_id = '{0}'", this.id);
            DataRow idMedico = OCNX.ObtenerFila(sSQL);
            if (idMedico != null)
            {
                idmedico = int.Parse(idMedico["id"].ToString());
                //MetroMessageBox.Show(this, "ID de usuario = "+ idUsu +"!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Metodo para buscar todas las especialidades relacionadas con un medico
        public void buscarEspecialidades()
        {
            lblMedico.Text = datoMedico;
            sSQL = String.Format(@"SELECT medesp.id, esp.desesp 'ESPECIALIDADES'
                                    FROM especialidades esp
                                    INNER JOIN medicos_especialidades medesp
                                    ON esp.id = medesp.especialidades_id
                                    INNER JOIN medicos med
                                    ON med.id = medesp.medicos_id
                                    WHERE med.id = '{0}'", this.idmedico);
            grdEspecialidadesCRUD.DataSource = null;
            grdEspecialidadesCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
            //lblNombre.Text = "Medico: " + nomape;
        }


       

        void insertarMedico()
        {
          
            int especialidad = int.Parse(cboEspecialidad.SelectedValue.ToString());
            OCNX.IniciarTransaccion();
            sSQL = String.Format(@"INSERT INTO medicos VALUES (null, '{0}')", id);            
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {                
                idmedico = OCNX.ObtenerUltimoID();
                string sSQL1 = "INSERT INTO medicos_especialidades VALUES (null, "+idmedico+", "+especialidad+")";
                if (OCNX.EjercutarSQL(sSQL1) > 0)
                {
                    OCNX.EjercuarTransaccion();
                    MetroMessageBox.Show(this, "Medico insertado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buscarEspecialidades();
                }
                else
                {
                    OCNX.DeshacerTransaccion();
                    MetroMessageBox.Show(this, "No se ha insertado el medico!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usu.eliminarUsuario();
                }
               
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usu.eliminarUsuario();
                this.Close();
            }
        }

        void agregarEspesialidadMedico()
        {
            int cboidEspe = int.Parse(cboEspecialidad.SelectedValue.ToString());
            sSQL = String.Format(@"INSERT INTO medicos_especialidades VALUES(null, '{0}', '{1}')", this.idmedico, cboidEspe);
            OCNX.IniciarTransaccion();
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                OCNX.EjercuarTransaccion();
                MetroMessageBox.Show(this, "Especialidad agregada con exito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buscarEspecialidades();
                cargarCboEspecialidades();
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "Error: no se pudo agregar la especialidad!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo para buscar una especialidad y mostrarla en el Combobox
        void buscarEspecialidadMedico()
        {
            btnAgregar.Enabled = false;
            sSQL = String.Format(@"SELECT especialidades_id FROM medicos_especialidades WHERE id = '{0}'", this.idespe);
            DataRow especialidad = OCNX.ObtenerFila(sSQL);
            if (especialidad != null)
            {
                cboEspecialidad.SelectedValue = int.Parse(especialidad["especialidades_id"].ToString());
            }
        }

        void actualizarEspecialidadMedico()
        {
            btnAgregar.Enabled = true;
            int cboidEspe = int.Parse(cboEspecialidad.SelectedValue.ToString());
            sSQL = String.Format(@"UPDATE medicos_especialidades SET especialidades_id = '{0}' WHERE id = '{1}'", cboidEspe, this.idespe);
            OCNX.IniciarTransaccion();
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                OCNX.EjercuarTransaccion();
                MetroMessageBox.Show(this, "Especialidad del medico actualizada con exito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buscarEspecialidades();
                cargarCboEspecialidades();
                idespe = "";
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "Error: no se pudo actualizar la especialidad!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void EliminarEspecialidadMedico()
        {
            btnAgregar.Enabled = true;
            int cboidEspe = int.Parse(cboEspecialidad.SelectedValue.ToString());
            sSQL = String.Format(@"DELETE FROM medicos_especialidades WHERE id = '{0}'", this.idespe);
            OCNX.IniciarTransaccion();
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                OCNX.EjercuarTransaccion();
                buscarEspecialidades();
                cargarCboEspecialidades();
                idespe = "";
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "Error: no se pudo eliminar la especialidad!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboEspecialidad.SelectedIndex.Equals(0))
            {
                MetroMessageBox.Show(this, "Debe escoger una especialidad!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            insertarMedico();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Enabled == false)
            {
                btnAgregar.Enabled = true;
                cargarCboEspecialidades();
            }
            else
            {
                DialogResult Result = MetroMessageBox.Show(this, "Cancelar operación?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    if (usu.id != "")
                    {
                        this.Close();
                    }
                    else
                    {
                        usu.eliminarUsuario();
                        this.Close();
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboEspecialidad.SelectedIndex.Equals(0))
            {
                MetroMessageBox.Show(this, "Debe escoger una especialidad!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (idmedico == 0)
            {
                insertarMedico();
            }
            else
            {
                agregarEspesialidadMedico();
            }
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cboEspecialidad.SelectedIndex.Equals(0) || idespe == "")
            {
                MetroMessageBox.Show(this, "Debe escoger una especialidad!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            actualizarEspecialidadMedico();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboEspecialidad.SelectedIndex.Equals(0) || idespe == "")
            {
                MetroMessageBox.Show(this, "Debe escoger una especialidad!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult Result = MetroMessageBox.Show(this, "Realmente desea eliminar esta especialidad?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                EliminarEspecialidadMedico();
            }
        }

        private void grdEspecialidadesCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idespe = grdEspecialidadesCRUD[0, e.RowIndex].Value.ToString();
            buscarEspecialidadMedico();
        }
    }
}
