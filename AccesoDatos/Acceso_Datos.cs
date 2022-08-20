using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Entities;

namespace AccesoDatos
{

    public class Acceso_Datos
    {
        SqlConnection miConexion = new SqlConnection(
            ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);

        public DataTable ListarAlumnos(int nId)
        {
            DataTable dtDato = new DataTable();

            SqlCommand cmd = new SqlCommand("ListarAlumnos", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@idAlumno", nId);
            SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
            oAdaptador.Fill(dtDato);
            miConexion.Close();


            return dtDato;
        }
        public int AddAlumno(Alumno oAlumno)
        {
            int nResultado = 0;
            try
            {

                SqlCommand cmd = new SqlCommand("AgregarAlumno", miConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                miConexion.Open();
                cmd.Parameters.AddWithValue("@Nombre", oAlumno.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", oAlumno.Apellido);
                cmd.Parameters.AddWithValue("@FechaNac", oAlumno.Fnacimiento);
                cmd.Parameters.AddWithValue("@Direccion", oAlumno.Direccion);
                cmd.Parameters.AddWithValue("@Genero", oAlumno.Genero);
                cmd.Parameters.AddWithValue("@IdCarrera", oAlumno.Idcarrera);
                cmd.Parameters.AddWithValue("@Correo", oAlumno.Correo);

                nResultado = cmd.ExecuteNonQuery();
                miConexion.Close();

            }
            catch (Exception ex)
            {


            }
            return nResultado;




        }

        public int ActualizarAlumno(Alumno oAlumno)
        {
            int nResultado = 0;
            try
            {

                SqlCommand cmd = new SqlCommand("ActualizaAlumno", miConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                miConexion.Open();
                cmd.Parameters.AddWithValue("@IdAlumno", oAlumno.IdAlumno);
                cmd.Parameters.AddWithValue("@Nombre", oAlumno.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", oAlumno.Apellido);
                cmd.Parameters.AddWithValue("@FechaNac", oAlumno.Fnacimiento);
                cmd.Parameters.AddWithValue("@Direccion", oAlumno.Direccion);
                cmd.Parameters.AddWithValue("@Genero", oAlumno.Genero);
                cmd.Parameters.AddWithValue("@IdCarrera", oAlumno.Idcarrera);
                cmd.Parameters.AddWithValue("@Correo", oAlumno.Correo);

                nResultado = cmd.ExecuteNonQuery();
                miConexion.Close();

            }
            catch (Exception ex)
            {


            }
            return nResultado;




        }


        public DataTable MostrarCarrera(int nId)
        {
            DataTable dtDato = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("ListarCarreras", miConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                miConexion.Open();
                cmd.Parameters.AddWithValue("@idCarrera", nId);
                SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
                oAdaptador.Fill(dtDato);
                miConexion.Close();

            } catch (Exception ex)
            {

            }

            return dtDato;

        }
        /*public void EditContacto(EContacto oContacto)
        {
            SqlCommand cmd = new SqlCommand("EditContactos", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdContacto", oContacto.IdContacto);
            cmd.Parameters.AddWithValue("@Nombre", oContacto.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", oContacto.Apellido);
            cmd.Parameters.AddWithValue("@FechaNac", oContacto.FechaNac);
            cmd.Parameters.AddWithValue("@Direccion", oContacto.Direccion);
            cmd.Parameters.AddWithValue("@Genero", oContacto.Genero);
            cmd.Parameters.AddWithValue("@EstadoCivil", oContacto.EstadoCivil);
            cmd.Parameters.AddWithValue("@Celular", oContacto.Celular);
            cmd.Parameters.AddWithValue("@Telefono", oContacto.Telefono);
            cmd.Parameters.AddWithValue("@Email", oContacto.Email);
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }*/
        public int DeletContacto(int nId)
        {
            string query = "delete from Alumnos where idAlumno = " + nId;
            miConexion.Open();
            SqlCommand cmd = new SqlCommand(query, miConexion);
            int nResultado = cmd.ExecuteNonQuery();
            miConexion.Close();

            return nResultado;
        }

        public DataTable MostrarUsuario(int Nid)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("MostrarUsuario", miConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                miConexion.Open();
                cmd.Parameters.AddWithValue("@Id", Nid);
                SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
                oAdaptador.Fill(dataTable);
                cmd.ExecuteNonQuery();
                miConexion.Close();
            }
            catch (Exception ex)
            {

            }

            return dataTable;
        }

        public DataTable MostrarUsuario(string cConsulta)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand(cConsulta, miConexion);
                miConexion.Open();
                SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
                oAdaptador.Fill(dataTable);
                cmd.ExecuteNonQuery();
                miConexion.Close();
            }
            catch (Exception ex)
            {

            }

            return dataTable;
        }

        public int AgregarUsuario(Usuarios oUsuarios)
        {
            int nResultado = 0;

            try
            {
                SqlCommand cmd = new SqlCommand("AgregarUsuario", miConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                miConexion.Open();
                cmd.Parameters.AddWithValue("@IdAlumno", oUsuarios.IdUser);
                cmd.Parameters.AddWithValue("@Usuario", oUsuarios.Usuario);
                cmd.Parameters.AddWithValue("@Password", oUsuarios.Password);
                cmd.Parameters.AddWithValue("@Roles", oUsuarios.Roles);
                nResultado = cmd.ExecuteNonQuery();
                miConexion.Close();
            }
            catch (Exception ex)
            {

            }

            return nResultado;
        }
        public bool ValidarUsuario(string cUserName, string cPassword)
        {
            bool lResultado = false;
           
                string cConsulta = "select * from Usuarios where Usuario = '" + cUserName + " ' and Password  = '" + cPassword + "'";




            try
            {
                DataTable dataTable = new DataTable();
                miConexion.Open();
                SqlCommand cmd = new SqlCommand(cConsulta, miConexion);

                SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
                oAdaptador.Fill(dataTable);
                int nResultado = cmd.ExecuteNonQuery();
                if (dataTable.Rows.Count > 0)
                {
                    lResultado = true;  
                }
                miConexion.Close();
            }
            catch (Exception ex)
            {

            }



            return lResultado;
        }

        public DataTable ListarEdificios(int nId)
        {
            DataTable dtDato = new DataTable();

            SqlCommand cmd = new SqlCommand("ListarEdificios", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@Id", nId);
            SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
            oAdaptador.Fill(dtDato);
            miConexion.Close();


            return dtDato;
        }

        public DataTable ListarAulas(int nId)
        {
            DataTable dtDato = new DataTable();

            SqlCommand cmd = new SqlCommand("ListarAulas", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@Id", nId);
            SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
            oAdaptador.Fill(dtDato);
            miConexion.Close();


            return dtDato;
        }

        public DataTable ListarAulasPorEdificio(int nId)
        {
            DataTable dtDato = new DataTable();

            SqlCommand cmd = new SqlCommand("Select * from Aulas where IdEdificio = '"+nId+"'", miConexion);
            miConexion.Open();
            SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
            oAdaptador.Fill(dtDato);
            miConexion.Close();


            return dtDato;
        }

        public void AddVisitas(Visita oVisita)
        {
            SqlCommand cmd = new SqlCommand("AgregarVisita", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdAlumno", oVisita.IdAlumno);
            cmd.Parameters.AddWithValue("@IdEdificio", oVisita.IdEdificio);
            cmd.Parameters.AddWithValue("@IdAula", oVisita.IdAula);
            cmd.Parameters.AddWithValue("@Fecha", oVisita.Fecha);
            cmd.Parameters.AddWithValue("@H_Entrada", oVisita.H_Entrada);
            cmd.Parameters.AddWithValue("@H_Salida", oVisita.H_Salida);
            cmd.Parameters.AddWithValue("@Motivo", oVisita.Motivo);
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }
        public void ActualizarVisitas(Visita oVisita)
        {
            SqlCommand cmd = new SqlCommand("ActualizarVisita", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdAlumno", oVisita.IdAlumno);
            cmd.Parameters.AddWithValue("@IdEdificio", oVisita.IdEdificio);
            cmd.Parameters.AddWithValue("@IdAula", oVisita.IdAula);
            cmd.Parameters.AddWithValue("@Fecha", oVisita.Fecha);
            cmd.Parameters.AddWithValue("@H_Entrada", oVisita.H_Entrada);
            cmd.Parameters.AddWithValue("@H_Salida", oVisita.H_Salida);
            cmd.Parameters.AddWithValue("@Motivo", oVisita.Motivo);
            cmd.ExecuteNonQuery();
            miConexion.Close();
        }
        public DataTable ListarVisitas(int nId)
        {
            DataTable dtDato = new DataTable();

            SqlCommand cmd = new SqlCommand("ListarVisitas", miConexion);
            cmd.CommandType = CommandType.StoredProcedure;
            miConexion.Open();
            cmd.Parameters.AddWithValue("@IdAlumno", nId);
            SqlDataAdapter oAdaptador = new SqlDataAdapter(cmd);
            oAdaptador.Fill(dtDato);
            miConexion.Close();


            return dtDato;
        }
    }
}
