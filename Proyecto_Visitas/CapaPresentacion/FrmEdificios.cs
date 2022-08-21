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
    public partial class FrmEdificios : Form
    {
        public FrmEdificios()
        {
            InitializeComponent();
        }

        N_Aulas n_Aulas = new N_Aulas();
        E_Aulas e_Aulas = new E_Aulas();
        N_Visitas n_Visitas = new N_Visitas();
        E_Visitas e_Visitas = new E_Visitas();

        public void Updatecbx()
        {
            cbxAula.Items.Clear();
            cbxEdificio.Items.Clear();
            n_Visitas.Loadingcbx(cbxEdificio);
            n_Aulas.Loadingcbx(cbxAula);
        }

        public void LimpiarCajas()
        {
            cbxEdificio.Text = "";
            cbxAula.Text = "";
            txtNuevo.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void visitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerVisitas frmVerVisitas = new FrmVerVisitas();
            frmVerVisitas.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void FrmEdificios_Load(object sender, EventArgs e)
        {
            Updatecbx();
        }

        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxEdificio.Text == "")
                {
                    MessageBox.Show("Para agregar llene el campo Edificio.");
                }
                else
                {
                    e_Visitas.NumeroEdificio = int.Parse(cbxEdificio.Text);
                    n_Visitas.InsertandoEdificio(e_Visitas, e_Aulas);

                    MessageBox.Show("Agregado con exito");
                    Updatecbx();
                    LimpiarCajas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar" + ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxEdificio.Text == "")
                {
                    MessageBox.Show("Debe llenar los campos");
                }
                else if (cbxAula.Text == "")
                {
                    MessageBox.Show("Debe llenar los campos");
                }
                else if (txtNuevo.Text == "")
                {
                    MessageBox.Show("Debe llenar los campos.");
                }
                else
                {
                    e_Visitas.NumeroEdificio = int.Parse(cbxEdificio.Text);
                    e_Aulas.Nombre = cbxAula.Text;
                    e_Aulas.NewAula = txtNuevo.Text;

                    n_Visitas.EditandoEdificio(e_Visitas, e_Aulas);
                    Updatecbx();
                    LimpiarCajas();
                    MessageBox.Show("Editado con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar, pruebe otra vez" + ex);
            }
        }

        private void btnAgregarAula_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxEdificio.Text == "")
                {
                    MessageBox.Show("Debe llenar los campos");
                }
                else if (cbxAula.Text == "")
                {
                    MessageBox.Show("Debe llenar los campos");
                }
                else
                {
                    e_Aulas.NumeroEdificio = int.Parse(cbxEdificio.Text);
                    e_Aulas.Nombre = cbxAula.Text;
                    n_Aulas.InsertandoAulas(e_Aulas);

                    MessageBox.Show("Aula Agregada.");
                    Updatecbx();
                    LimpiarCajas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el aula." + ex);
            }
        }
    }
}
