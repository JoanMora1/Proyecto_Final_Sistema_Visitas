using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using CapaEntidad;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class D_Aulas
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void InsertarAula(E_Aulas e_Aulas)
        {
            SqlCommand cmd = new SqlCommand("SP_AGREGAR_AULAS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NUMERO_EDIFICIO", e_Aulas.NumeroEdificio);
            cmd.Parameters.AddWithValue("@NOMBRE_AULA", e_Aulas.Nombre);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void LoadCbx(ComboBox cbx)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_VER_AULAS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            leer = cmd.ExecuteReader();

            while (leer.Read())
            {
                cbx.Items.Add(leer["NOMBRE"].ToString());
            }

            conn.Close();
            leer.Close();
        }

        public void LoadcbxAulas(ComboBox cbx, int buscar)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_AULAS_X_EDIFICIO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NUMERO_EDIFICIO", buscar);
            cmd.ExecuteNonQuery();
            leer = cmd.ExecuteReader();

            while (leer.Read())
            {
                cbx.Items.Add(leer["NOMBRE"].ToString());
            }
            conn.Close();
            leer.Close();
        }
    }
}
