using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Visita
    {
        private int _IdAlumno;
        private int _IdEdificio;
        private int _IdAula;
        private string _Motivo;
        private DateTime _Fecha;
        private TimeSpan _H_Entrada;
        private TimeSpan _H_Salida;

        public int IdAlumno { get => _IdAlumno; set => _IdAlumno = value; }
        public int IdEdificio { get => _IdEdificio; set => _IdEdificio = value; }
        public int IdAula { get => _IdAula; set => _IdAula = value; }
        public string Motivo { get => _Motivo; set => _Motivo = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public TimeSpan H_Entrada { get => _H_Entrada; set => _H_Entrada = value; }
        public TimeSpan H_Salida { get => _H_Salida; set => _H_Salida = value; }
    }
}
