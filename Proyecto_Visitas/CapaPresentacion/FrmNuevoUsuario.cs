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
    public partial class FrmNuevoUsuario : Form
    {
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        N_Usuarios n_Usuarios = new N_Usuarios();
        E_Usuarios e_Usuarios = new E_Usuarios();

        private void visitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarVisita Visitas = new FrmRegistrarVisita();
            Visitas.Show();
            this.Hide();
        }

        private void edificioAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEdificios Edificio = new FrmEdificios();
            Edificio.Show();
            this.Hide();
        }

        private void visitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerVisitas VerVisitas = new FrmVerVisitas();
            VerVisitas.Show();
            this.Hide();
        }

        public void LimpiarCajas()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbxTipoUsu.Text = "";
            txtNombreUsu.Text = "";
            txtContrasena.Text = "";
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Debes llenar los campos faltantes.");
                }
                else if (txtApellido.Text == "")
                {
                    MessageBox.Show("Debes llenar los campos faltantes.");
                }
                else if (cbxTipoUsu.Text == "")
                {
                    MessageBox.Show("Debes llenar los campos faltantes.");
                }
                else if (txtNombreUsu.Text == "")
                {
                    MessageBox.Show("Debes llenar los campos faltantes.");
                }
                else if (txtContrasena.Text == "")
                {
                    MessageBox.Show("Debes llenar los campos faltantes.");
                }
                else
                {
                    e_Usuarios.Nombre = txtNombre.Text.ToString();
                    e_Usuarios.Apellido = txtApellido.Text.ToString();
                    e_Usuarios.Nacimiento = dateTimePicker1.Value;
                    e_Usuarios.TipoUsuario = cbxTipoUsu.Text.ToString();
                    e_Usuarios.NombreUsuario = txtNombreUsu.Text.ToString();
                    e_Usuarios.Contrasena = txtContrasena.Text.ToString();

                    n_Usuarios.InsertandoUsuarios(e_Usuarios);
                    MessageBox.Show("Usuario Agregado.");
                    LimpiarCajas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el usuario." + ex);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
