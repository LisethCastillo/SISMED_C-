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
using System.Text.RegularExpressions;

namespace frmMenuPrincipal
{
    public partial class frmCRUDUsuarios : MetroForm
    {
        clDatosMySQL OCNX = new clDatosMySQL();
        public String id = "", nomape= "";
        String sSQL = "";
        // Variable que se uará para guardar el ultimo id insertado en la tabla Ususuarios.
        String idusuario = "";
        public frmCRUDUsuarios()
        {
            InitializeComponent();
            consultarUsuarios("");
            cargarCboRoles();
            nuevo();
        }


        void cargarCboRoles()
        {
            String sSQL = "";
            sSQL = @"select id, desrol from roles";
            OCNX.CargarCombo(sSQL, cboRoles, "desrol", "id");
        }

        public void consultarUsuarios(string filtro)
        {
            sSQL = @"SELECT usu.id 'ID', nomusu 'NOMBRE', apeusu 'APELLIDO', docusu 'CEDULA', genusu 'GENERO',
                                   telusu 'TELEFONO', dirusu 'DIRECCION', corusu 'E-MAIL', desrol 'ROL'
                            FROM usuarios usu 
                            INNER JOIN roles rol ON usu.role_id = rol.id
                            where concat( usu.id,' ',nomusu,' ',apeusu,' ',docusu, ' ',desrol) like '%" + filtro + "%' ";
            grdUsuariosCRUD.DataSource = null;
            grdUsuariosCRUD.DataSource = OCNX.ObtenerDatos(sSQL);
            
        }

        public static bool ValidarEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        void frmAdicional(String id, String sentencia = "")
        {
            if (cboRoles.SelectedIndex == 1)
            {
                if (this.id == "")
                {
                    insertarUsuarioAdministrador();
                }
                else
                {
                    MetroMessageBox.Show(this, "Usuario actualizado con exito!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    consultarUsuarios("");
                    nuevo();
                }
            }
            else if (cboRoles.SelectedIndex == 4)
            {
                frmCRUDInfoBeneficiarios frmBen = new frmCRUDInfoBeneficiarios(id, this);
                frmBen.Show();
            }
            else if (cboRoles.SelectedIndex == 3)
            {
                frmCRUDInfoFuncionarios frmFun = new frmCRUDInfoFuncionarios(id, this);
                frmFun.Show();
            }
            else if (cboRoles.SelectedIndex == 2)
            {
                frmCRUDInfoMedico frmMed = new frmCRUDInfoMedico(id, this);
                if (sentencia.Equals(""))
                {
                    frmMed.buscarMedicoUsuario();
                    frmMed.datoMedico = txtNombre.Text.Trim() + " " + txtApellido.Text.Trim(); 
                }
                frmMed.buscarEspecialidades();
                frmMed.Show();
            }
        }

        void insertarUsuario()
        {
            string nombre, apellido, cedula, tel, genero = "", dir, email, fechaNaci, clave;
            int  rol;
            fechaNaci = dtFechaNaci.Value.ToString("yyyy-MM-dd");
            nombre = txtNombre.Text.Trim();
            apellido = txtApellido.Text.Trim();
            cedula = txtCedula.Text.Trim();
            tel = txtTelefono.Text.Trim();
            dir = txtDireccion.Text.Trim();
            clave = txtClave.Text.Trim();
            rol = int.Parse(cboRoles.SelectedValue.ToString());
            email = txtEmail.Text.Trim();
            if (!ValidarEmail(email))
            {
                MetroMessageBox.Show(this, "La dirección de e-mail no es valida!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (optFemenino.Checked)
            {
                genero = "F";
            }

            if (optMasculino.Checked)
            {
                genero = "M";
            }

            OCNX.IniciarTransaccion();
            sSQL = String.Format(@"SELECT count(*) FROM usuarios WHERE docusu = '{0}' ", cedula);
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Este usuario ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sSQL = String.Format(@"INSERT INTO usuarios VALUES (null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', '{9}')",
                                  cedula, nombre, apellido, email, tel, dir, genero, fechaNaci, clave, rol);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                OCNX.EjercuarTransaccion();
                idusuario = OCNX.ObtenerUltimoID().ToString();
                frmAdicional(idusuario, "insert");
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buscarUsuario()
        {
            
            sSQL = String.Format(@"SELECT * FROM usuarios WHERE id = '{0}'", id);
            DataRow Usuario = OCNX.ObtenerFila(sSQL);

            if (Usuario != null)
            {
                txtNombre.Text = Usuario["nomusu"].ToString();
                txtApellido.Text = Usuario["apeusu"].ToString();
                txtCedula.Text = Usuario["docusu"].ToString();
                txtTelefono.Text = Usuario["telusu"].ToString();
                txtDireccion.Text = Usuario["dirusu"].ToString();
                txtEmail.Text = Usuario["corusu"].ToString();
                txtClave.Text = Usuario["clausu"].ToString();
                cboRoles.SelectedValue = int.Parse(Usuario["role_id"].ToString());
                cboRoles.Enabled = false;
                dtFechaNaci.Value = DateTime.Parse(Usuario["fechanaciusu"].ToString());
                String genero = Usuario["genusu"].ToString();
                if (genero.Equals("F"))
                {
                    optFemenino.Checked = true;
                }
                else
                {
                    optMasculino.Checked = true;
                }
            }
        }

        void actualizarUsuario()
        {
            string nombre, apellido, cedula, tel, genero = "", dir, email, clave, sSQL;
            int rol;
            String fechaNaci = dtFechaNaci.Value.ToString("yyyy-MM-dd");
            nombre = txtNombre.Text.Trim();
            apellido = txtApellido.Text.Trim();
            cedula = txtCedula.Text.Trim();
            tel = txtTelefono.Text.Trim();
            dir = txtDireccion.Text.Trim();
            email = txtEmail.Text.Trim();
            clave = txtClave.Text.Trim();
            rol = int.Parse(cboRoles.SelectedValue.ToString());
            if (optFemenino.Checked)
            {
                genero = "F";
            }

            if (optMasculino.Checked)
            {
                genero = "M";
            }

            /*sSQL = @"SELECT count(*) FROM usuarios WHERE docusu = '" + cedula + "'";
            if (OCNX.obtenerCatidad(sSQL) > 0)
            {
                MetroMessageBox.Show(this, "Este usuario ya existe!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            OCNX.IniciarTransaccion();

            sSQL = String.Format(@"UPDATE usuarios SET nomusu = '{0}', apeusu = '{1}', docusu = '{2}', genusu = '{3}',
                                 telusu = '{4}', dirusu = '{5}', corusu = '{6}',fechanaciusu = '{7}', role_id = '{8}' WHERE id = '{9}'",
                                 nombre, apellido, cedula, genero,  tel, dir, email, fechaNaci, rol, this.id);
            Console.WriteLine(sSQL);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                OCNX.EjercuarTransaccion();
                frmAdicional(id);
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void inactivarCampos()
        {
            cboRoles.Enabled = false;
            lblClave.Visible = false;
            txtClave.Visible = false;
        }

        public void nuevo()
        {
            id = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            cargarCboRoles();
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtClave.Text = "";
            txtClave.Visible = true;
            lblClave.Visible = true;
            dtFechaNaci.Value = DateTime.Now;
            optFemenino.Checked = false;
            optMasculino.Checked = false;
            cboRoles.Enabled = true;
        }

        //-- Metodo publico para eliminar un usuario desde los otros formularios asociados a este al momento de una falla o
        //-- de cancelar la operacion, para mantener la integridad de los datos.
        public void eliminarUsuario()
        {

            // int especialidad = int.Parse(cboEspecialidad.SelectedValue.ToString());
            OCNX.IniciarTransaccion();
            sSQL = String.Format(@"DELETE FROM usuarios WHERE id = '{0}' ", this.idusuario);
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                OCNX.EjercuarTransaccion();
                MetroMessageBox.Show(this, "Operación canselada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarUsuarios("");
                nuevo();
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                consultarUsuarios("");
                nuevo();
            }
        }

        //Metodo para insertar un administrador
        void insertarUsuarioAdministrador()
        {
            sSQL = String.Format("INSERT INTO administradores VALUES(null, '{0}')", idusuario);
            OCNX.IniciarTransaccion();
            if (OCNX.EjercutarSQL(sSQL) > 0)
            {
                OCNX.EjercuarTransaccion();
                MetroMessageBox.Show(this, "Usuario Administrador, registrado con exito!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultarUsuarios("");
                nuevo();
            }
            else
            {
                OCNX.DeshacerTransaccion();
                MetroMessageBox.Show(this, "Error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                eliminarUsuario();
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || (optFemenino.Checked == false & optMasculino.Checked == false) || cboRoles.SelectedIndex.Equals(0) || txtCedula.Text.Equals("") || txtTelefono.Text.Equals("") || txtDireccion.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MetroMessageBox.Show(this, "Debe ingresar todos los items!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (id != "")
            {
                DialogResult Result = MetroMessageBox.Show(this, "Confirmar actualización?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    actualizarUsuario();
                }

            }
            else
            {
                insertarUsuario();
            }
        }

        private void grdUsuariosCRUD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grdUsuariosCRUD[0, e.RowIndex].Value.ToString();
            buscarUsuario();
            txtClave.Visible = false;
            lblClave.Visible = false;
        }

        private void txtFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            String filtro = txtFiltrar.Text.Trim();
            consultarUsuarios(filtro);
        }

        private void grdUsuariosCRUD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
