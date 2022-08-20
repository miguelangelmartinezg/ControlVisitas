using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Alumno
    {
        /*
        oAlumno.nombre = txtNombre.Text;
                oAlumno.apellido = txtApellido.Text;
                oAlumno.correo = txtCorreo.Text;
                oAlumno.idcarrera = int.Parse(cboCarrera.SelectedValue.ToString());
        oAlumno.genero = cRdbCheck;
                oAlumno.Fnacimiento = dtFNacimiento.Text;
        [nombre]
      ,[apellido]
      ,[correo]
      ,[idcarrera]
      ,[genero]
      ,[Fnacimiento]
      ,[direccion]
        */
        private int _IdAlumno;      
        private string _Nombre;
        private string _apellido;
        private string _correo;
        private string _direccion;
        private int _idcarrera;
        private string _genero;
        private DateTime _Fnacimiento;

        public int IdAlumno { get => _IdAlumno; set => _IdAlumno = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Correo { get => _correo; set => _correo = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int Idcarrera { get => _idcarrera; set => _idcarrera = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public DateTime Fnacimiento { get => _Fnacimiento; set => _Fnacimiento = value; }
    }
}
