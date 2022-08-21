using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Usuarios
    {
        D_Usuarios d_Usuarios = new D_Usuarios();

        public void InsertandoUsuarios(E_Usuarios e_Usuarios)
        {
            d_Usuarios.InsertarUsuario(e_Usuarios);
        }

        public string ValidandoUsuario(E_Usuarios e_Usuarios)
        {
            string TipoDato = d_Usuarios.ValidarUsuario(e_Usuarios);
            return TipoDato;
        }
    }
}
