using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Edificio
    {
        private int _IdEdificio;
        private string _Descripcion;

        public int IdEdificio { get => _IdEdificio; set => _IdEdificio = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}
