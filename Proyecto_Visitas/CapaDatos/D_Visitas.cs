using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class D_Visitas
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Visitas> ListarVisitas(string buscar)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_VISITAS_X_EDIFICIO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@EDIFICIO", buscar);
            leer = cmd.ExecuteReader();

            List<E_Visitas> Listar = new List<E_Visitas>();
            while (leer.Read())
            {
                Listar.Add(new E_Visitas
                {
                    IdVisitas = leer.GetInt32(0),
                    Nombre = leer.GetString(1),
                    Apellido = leer.GetString(2),
                    Carrera = leer.GetString(3),
                    Edificio = leer.GetInt32(4),
                    FechaHoraEntrada = leer.GetDateTime(5),
                    FechaHoraSalida = leer.GetDateTime(6),
                    MotivoVisita = leer.GetString(7),
                    Objetivo = leer.GetString(8)
                });
            }

            conn.Close();
            leer.Close();
            return Listar;
        }

        public void InsertarVisitas(E_Visitas e_Visitas)
        {
            SqlCommand cmd = new SqlCommand("SP_AGREGAR_VISITA", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", e_Visitas.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", e_Visitas.Apellido);
            cmd.Parameters.AddWithValue("@CARRERA", e_Visitas.Carrera);
            cmd.Parameters.AddWithValue("@EDIFICIO", e_Visitas.Edificio);
            cmd.Parameters.AddWithValue("@FECHA_Y_HORA_DE_ENTRADA", e_Visitas.FechaHoraEntrada);
            cmd.Parameters.AddWithValue("@FECHA_Y_HORA_DE_SALIDA", e_Visitas.FechaHoraSalida);
            cmd.Parameters.AddWithValue("@MOTIVO_VISITA", e_Visitas.MotivoVisita);
            cmd.Parameters.AddWithValue("@AULA_LUGAR", e_Visitas.Objetivo);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void InsertarEdificio(E_Visitas e_Visitas, E_Aulas e_Aulas)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_EDIFICIO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NUMERO_EDIFICIO", e_Visitas.NumeroEdificio);
            cmd.Parameters.AddWithValue("@NOMBRE_AULA", e_Aulas.Nombre);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditarEdificio(E_Visitas e_Visitas, E_Aulas e_Aulas)
        {
            SqlCommand cmd = new SqlCommand("SP_MODIFICAR_EDIFICIO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NUMERO_EDIFICIO", e_Visitas.NumeroEdificio);
            cmd.Parameters.AddWithValue("@NOMBRE_AULA", e_Aulas.Nombre);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Loadcbx(ComboBox cbx)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_VER_EDIFICIOS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            leer = cmd.ExecuteReader();

            while (leer.Read())
            {
                cbx.Items.Add(leer["NUMERO_EDIFICIO"].ToString());
            }

            conn.Close();
            leer.Close();
        }
    }
}
