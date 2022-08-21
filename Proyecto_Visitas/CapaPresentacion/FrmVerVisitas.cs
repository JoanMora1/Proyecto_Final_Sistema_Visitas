using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmVerVisitas : Form
    {
        public FrmVerVisitas()
        {
            InitializeComponent();
        }

        N_Visitas n_Visitas = new N_Visitas();

        private void visitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarVisita frmRegistrarVisita = new FrmRegistrarVisita();
            frmRegistrarVisita.Show();
            this.Hide();
        }

        private void edificioAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frmNuevoUsuario = new FrmNuevoUsuario();
            frmNuevoUsuario.Show();
            this.Hide();
        }

        private void edificioAulaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEdificios frmEdificios = new FrmEdificios();
            frmEdificios.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnVerVisitas_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = n_Visitas.ListarVisita(cbxBuscarVisitas.Text);
        }

        private void FrmVerVisitas_Load(object sender, EventArgs e)
        {
            n_Visitas.Loadingcbx(cbxBuscarVisitas);
        }
    }
}
