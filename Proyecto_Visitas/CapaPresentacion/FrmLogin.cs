using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        E_Usuarios e_Usuarios = new E_Usuarios();
        N_Usuarios n_Usuarios = new N_Usuarios();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                e_Usuarios.NombreUsuario = txtUsuario.Text.ToString();
                e_Usuarios.Contrasena = txtContaseña.Text.ToString();
                string verificar = n_Usuarios.ValidandoUsuario(e_Usuarios);

                if (verificar is null)
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto");
                    txtUsuario.Text = "";
                    txtContaseña.Text = "";
                }
                else if (verificar == "Administrador")
                {
                    FrmNuevoUsuario Nuevo = new FrmNuevoUsuario();
                    Nuevo.Show();
                    this.Hide();
                }
                else
                {
                    FrmVisitas_General frmVisitas_General = new FrmVisitas_General();
                    frmVisitas_General.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, intente nueva vez");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario Nuevo = new FrmNuevoUsuario();
            Nuevo.Show();
            this.Hide();
        }
    }
}
