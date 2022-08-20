using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Carreras
    {
        private int idCarrera;
        private string descripcion;

        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
