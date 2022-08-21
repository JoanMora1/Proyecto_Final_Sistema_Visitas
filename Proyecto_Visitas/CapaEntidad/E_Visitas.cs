using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Visitas
    {
        //Atributos de Edificios

        private int _IdEdificio;
        private int _NumeroEdificio;

        //Atributos de visitas

        private int _IdVisitas;
        private string _Nombre;
        private string _Apellido;
        private string _Carrera;
        private int _Edificio;
        private DateTime _FechaHoraEntrada;
        private DateTime _FechaHoraSalida;
        private string _MotivoVisita;
        private string _Objetivo;
        
        public int IdVisitas { get => _IdVisitas; set => _IdVisitas = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Carrera { get => _Carrera; set => _Carrera = value; }
        public int Edificio { get => _Edificio; set => _Edificio = value; }
        public DateTime FechaHoraEntrada { get => _FechaHoraEntrada; set => _FechaHoraEntrada = value; }
        public DateTime FechaHoraSalida { get => _FechaHoraSalida; set => _FechaHoraSalida = value; }
        public string MotivoVisita { get => _MotivoVisita; set => _MotivoVisita = value; }
        public string Objetivo { get => _Objetivo; set => _Objetivo = value; }
        public int IdEdificio { get => _IdEdificio; set => _IdEdificio = value; }
        public int NumeroEdificio { get => _NumeroEdificio; set => _NumeroEdificio = value; }
    }
}
