using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace frmMenuPrincipal
{
    public partial class frmMenuPrincipal : MetroForm
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDClases frmClases = new frmCRUDClases();
            frmClases.MdiParent = this;
            frmClases.Show();
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDMedidas frmMedidas = new frmCRUDMedidas();
            frmMedidas.MdiParent = this;
            frmMedidas.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDMarcas frmMarcas = new frmCRUDMarcas();
            frmMarcas.MdiParent = this;
            frmMarcas.Show();
        }

        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDPresentaciones frmPresentaciones = new frmCRUDPresentaciones();
            frmPresentaciones.MdiParent = this;
            frmPresentaciones.Show();
        }

        

        private void madicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicamentos frmMedicamentos = new frmMedicamentos();
            frmMedicamentos.MdiParent = this;
            frmMedicamentos.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDRoles frmRoles = new frmCRUDRoles();
            frmRoles.MdiParent = this;
            frmRoles.Show();
        }

        private void parentescosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDParentescos frmParentescos = new frmCRUDParentescos();
            frmParentescos.MdiParent = this;
            frmParentescos.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDUsuarios frm = new frmCRUDUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

       
        private void agendarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDAgendarCita frmAgendarCita = new frmCRUDAgendarCita();
            frmAgendarCita.MdiParent = this;
            frmAgendarCita.Show();
        }

        private void gestionDeEstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDEstados frmEsatdos = new frmCRUDEstados();
            frmEsatdos.MdiParent = this;
            frmEsatdos.Show();
        }

        private void tipificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDTipificaciones frm = new frmCRUDTipificaciones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nombresGenericosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDNombreGenerico frm = new frmCRUDNombreGenerico();
            frm.MdiParent = this;
            frm.Show();
        }

        private void canalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDCanales frm = new frmCRUDCanales();
            frm.MdiParent = this;
            frm.Show();
        }

        private void centrosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCRUDCentros frm = new frmCRUDCentros();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tipoDeVinculacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDTiposVinculacion frm = new frmCRUDTiposVinculacion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prentescosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDParentescos frm = new frmCRUDParentescos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void letrasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCRUDLetras frm = new frmCRUDLetras();
            frm.MdiParent = this;
            frm.Show();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDEspecialidades frm = new frmCRUDEspecialidades();
            frm.MdiParent = this;
            frm.Show();
        }

        private void actualizarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDConsultorios frm = new frmCRUDConsultorios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tipoCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDTipoCitas frm = new frmCRUDTipoCitas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRUDEstados frm = new frmCRUDEstados();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sañirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
