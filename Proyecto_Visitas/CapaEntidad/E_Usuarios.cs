using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Usuarios
    {
        private int _IdUsuario;
        private string _Nombre;
        private string _Apellido;
        private DateTime _Nacimiento;
        private string _TipoUsuario;
        private string _NombreUsuario;
        private string _Contrasena;

        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime Nacimiento { get => _Nacimiento; set => _Nacimiento = value; }
        public string TipoUsuario { get => _TipoUsuario; set => _TipoUsuario = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }
    }
}
