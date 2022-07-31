using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClassEntidad;
using System.Configuration;

namespace ClassDAL
{
    public class ClaseDAL
    {
        private string Cadena;
        public ClaseDAL()
        {
            Cadena = ConfigurationManager.ConnectionStrings["bdCovid"].ConnectionString;
        }
        public string InsertaAlumno(Alumno alumno)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@Matricula", alumno.Matricula);
            com.Parameters.AddWithValue("@Nombre", alumno.Nombre);
            com.Parameters.AddWithValue("@Appat", alumno.Ap_pat);
            com.Parameters.AddWithValue("@Apmat", alumno.Ap_mat);
            com.Parameters.AddWithValue("@Genero", alumno.Genero);
            com.Parameters.AddWithValue("@Correo", alumno.Correo);
            com.Parameters.AddWithValue("@Celular", alumno.Celular);
            com.Parameters.AddWithValue("@F_EdoCivl", alumno.f_edoCivil);
            com.CommandText = "insert into Alumno values (@Matricula, @Nombre, @Appat, @Apmat, @Genero, @Correo, @Celular, @F_EdoCivl)";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo alumno";
            conexion.Close();
            return respuesta;
        }

        public string InsertaProfe(Profesor profesor)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@RegistroE", profesor.RegistroEmpleado);
            com.Parameters.AddWithValue("@Nombre", profesor.Nombre);
            com.Parameters.AddWithValue("@Appat", profesor.Ap_pat);
            com.Parameters.AddWithValue("@Apmat", profesor.Ap_Mat);
            com.Parameters.AddWithValue("@Genero", profesor.Genero);
            com.Parameters.AddWithValue("@Categoria", profesor.Categoria);
            com.Parameters.AddWithValue("@Correo", profesor.Correo);
            com.Parameters.AddWithValue("@Celular", profesor.Celular);
            com.Parameters.AddWithValue("@F_EdoCivil", profesor.F_EdoCivil);
            com.CommandText = "insert into Profesor values (@RegistroE, @Nombre, @Appat, @Apmat, @Genero, @Categoria, @Correo, @Celular, @F_EdoCivil)";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo profesor";
            conexion.Close();
            return respuesta;
        }
        public SqlDataReader Select(string table)
        {
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlDataReader reader;
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.CommandText = "select * from " + table;
            reader = com.ExecuteReader();
            return reader;
        }
        public string Delete(string table, int id)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@id", id);
            com.CommandText = "delete from " + table + " where id = @id";
            com.ExecuteNonQuery();
            respuesta = "Se eliminó un registro";
            conexion.Close();
            return respuesta;
        }
    }   
}
