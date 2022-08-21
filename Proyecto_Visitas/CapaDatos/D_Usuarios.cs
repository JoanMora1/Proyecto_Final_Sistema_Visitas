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
    public class D_Usuarios
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public void InsertarUsuario(E_Usuarios e_Usuarios)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_USUARIO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", e_Usuarios.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", e_Usuarios.Apellido);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", e_Usuarios.Nacimiento);
            cmd.Parameters.AddWithValue("@TIPO_USUARIO", e_Usuarios.TipoUsuario);
            cmd.Parameters.AddWithValue("@NOMBRE_USUARIO", e_Usuarios.NombreUsuario);
            cmd.Parameters.AddWithValue("@CONTRASENA", e_Usuarios.Contrasena);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public string ValidarUsuario(E_Usuarios e_Usuarios)
        {
            SqlDataReader leer;
            SqlCommand cmd = new SqlCommand("SP_VALIDAR_USUARIO", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            cmd.Parameters.AddWithValue("@NOMBRE_USUARIO", e_Usuarios.NombreUsuario);
            cmd.Parameters.AddWithValue("@CONTRASENA", e_Usuarios.Contrasena);
            leer = cmd.ExecuteReader();

            if (leer.Read())
            {
                e_Usuarios.TipoUsuario = leer.GetString(0);
            }

            conn.Close();
            leer.Close();
            return e_Usuarios.TipoUsuario;
        }
    }
}
