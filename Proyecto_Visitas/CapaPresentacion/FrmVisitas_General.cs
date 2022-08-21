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
    public partial class FrmVisitas_General : Form
    {
        public FrmVisitas_General()
        {
            InitializeComponent();
        }

        N_Visitas n_Visitas = new N_Visitas();
        E_Visitas e_Visitas = new E_Visitas();
        N_Aulas n_Aulas = new N_Aulas();
        E_Aulas e_Aulas = new E_Aulas();

        private void Limpiarcajas()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCarrera.Text = "";
            cbxEdificio.Text = "";
            cbxObjetivo.Text = "";
            txtMotivo.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void visitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerVisitas_General frmVerVisitas = new FrmVerVisitas_General();
            frmVerVisitas.Show();
            this.Hide();
        }

        private void btnRegistrarVisita_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                }
                else if (txtApellido.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                }
                else if (txtCarrera.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                }
                else if (cbxEdificio.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                }
                else if (cbxObjetivo.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                }
                else if (txtMotivo.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos.");
                }
                else
                {
                    e_Visitas.Nombre = txtNombre.Text.ToString();
                    e_Visitas.Apellido = txtApellido.Text.ToString();
                    e_Visitas.Carrera = txtCarrera.Text.ToString();
                    e_Visitas.Edificio = int.Parse(cbxEdificio.Text);
                    e_Visitas.FechaHoraEntrada = dtpEntrada.Value;
                    e_Visitas.FechaHoraSalida = dtpSalida.Value;
                    e_Visitas.MotivoVisita = txtMotivo.Text.ToString();
                    e_Visitas.Objetivo = cbxObjetivo.Text.ToString();

                    n_Visitas.InsertandoVisitas(e_Visitas);
                    MessageBox.Show("Se ha registrado su visita.");
                    Limpiarcajas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar su visita" + ex);
            }
        }

        private void FrmVisitas_General_Load(object sender, EventArgs e)
        {
            n_Visitas.Loadingcbx(cbxEdificio);
        }

        private void cbxEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxObjetivo.Items.Clear();
            int listar = int.Parse(cbxEdificio.Text);
            n_Aulas.LoadingcbxAulas(cbxObjetivo, listar);
        }
    }
}
