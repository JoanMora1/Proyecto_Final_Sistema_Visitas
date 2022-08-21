using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Aulas
    {
        private int _IdAulas;
        private string _Nombre;
        private int _NumeroEdificio;
        private string _NewAula;

        public int IdAulas { get => _IdAulas; set => _IdAulas = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int NumeroEdificio { get => _NumeroEdificio; set => _NumeroEdificio = value; }
        public string NewAula { get => _NewAula; set => _NewAula = value; }
    }
}
