using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace LogicaNegocio
{
    public class Logica_Negocio
    {
       // Alumno oAlumno = new Alumno();
       Acceso_Datos oAccsoDatos = new Acceso_Datos();

        public void AgregarAlumno(Alumno oAlumno)
        {
            oAccsoDatos.AddAlumno(oAlumno);
        }
        public void ActualizarAlumno(Alumno oAlumno)
        {
            oAccsoDatos.ActualizarAlumno(oAlumno);
        }

        public DataTable MostrarCarreras(int nId)
        {
            DataTable dtResultados = oAccsoDatos.MostrarCarrera(nId);
            return dtResultados;
        }

        public DataTable ListarAlumnos(int nId)
        {
            DataTable dtResultados = oAccsoDatos.ListarAlumnos(nId);
            return dtResultados;
        }

        public DataTable MostrarUsuario(int nId)
        {
            DataTable dtResultados = oAccsoDatos.MostrarUsuario(nId);
            return dtResultados;
        }

        public DataTable MostrarUsuario(string cConsulta)
        {
            DataTable dtResultados = oAccsoDatos.MostrarUsuario(cConsulta);
            return dtResultados;
        }

        public void AgregarUsuario(Usuarios oUsuarios)
        {
            oAccsoDatos.AgregarUsuario(oUsuarios);
        }
        public bool ValidarUsuario(string cUsuario, string cPassword)
        {
          return  oAccsoDatos.ValidarUsuario(cUsuario, cPassword);
        }

        public DataTable ListarEdificios(int nId)
        {
            return oAccsoDatos.ListarEdificios(nId);
        }

        public DataTable ListarAulas(int nId)
        {
            return oAccsoDatos.ListarAulas(nId);
        }

        public DataTable ListarAulasPorEdificio(int nId)
        {
            return oAccsoDatos.ListarAulasPorEdificio(nId);
        }

        public void AgregarVisita(Visita oVisita)
        {
            oAccsoDatos.AddVisitas(oVisita);
        }
        public void ActualizarVisita(Visita oVisita)
        {
            oAccsoDatos.ActualizarVisitas(oVisita);
        }

        public DataTable ListarVisitas(int nId)
        {
            DataTable dtResultados = oAccsoDatos.ListarVisitas(nId);
            return dtResultados;
        }
    }
}
