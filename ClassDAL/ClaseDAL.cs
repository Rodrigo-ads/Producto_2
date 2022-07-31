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
        public SqlDataReader ProfesContagiados(int cuatri, int educativo)
        {
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlDataReader reader;
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.CommandText = @"select
                Profesor.id,
                Profesor.Ap_pat,
                Profesor.Ap_Mat,
                Profesor.Nombre,
                Profesor.Celular,
                Profesor.Correo,
                Profesor.Categoria,
                Profesor.Genero
                from PositivoProfe
                inner join Profesor on Profesor.id = PositivoProfe.id
                inner join ProfeGRupo on ProfeGRupo.F_Profe = Profesor.id
                inner join GrupoCuatrimestre on GrupoCuatrimestre.id = ProfeGRupo.id
                inner join Cuatrimestre on Cuatrimestre.id = GrupoCuatrimestre.F_Cuatri
                inner join ProgramaEducativo on ProgramaEducativo.id = GrupoCuatrimestre.F_ProgEd
                where  Cuatrimestre.id = @cua  and ProgramaEducativo.id = @pro ";
            com.Parameters.AddWithValue("@cua", cuatri);
            com.Parameters.AddWithValue("@pro", educativo);
            reader = com.ExecuteReader();
            return reader;
        }


        public SqlDataReader AlumnoContagiados(int cuatri, int educativo)
        {
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlDataReader reader;
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.CommandText = @"select
                Alumno.id,
                Alumno.Ap_pat,
                Alumno.Ap_Mat,
                Alumno.Nombre,
                Alumno.Celular,
                Alumno.Correo,
                Alumno.Genero
                from PositivoAlumno
                inner join Alumno on Alumno.id = PositivoAlumno.id
                inner join AlumnoGrupo on AlumnoGrupo.F_Alumn = Alumno.id
                inner join GrupoCuatrimestre on GrupoCuatrimestre.id = AlumnoGrupo.id
                inner join Cuatrimestre on Cuatrimestre.id = GrupoCuatrimestre.F_Cuatri
                inner join ProgramaEducativo on ProgramaEducativo.id = GrupoCuatrimestre.F_ProgEd
                where  Cuatrimestre.id = @cuatri  and ProgramaEducativo.id = @educativo";
            com.Parameters.AddWithValue("@cuatri", cuatri);
            com.Parameters.AddWithValue("@educativo", educativo);
            reader = com.ExecuteReader();
            return reader;
        }
        public SqlDataReader AlumnoContagiadosGrupo(int cuatri, int educativo, int grupo)
        {
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlDataReader reader;
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.CommandText = @"select
                Alumno.id,
                Alumno.Ap_pat,
                Alumno.Ap_Mat,
                Alumno.Nombre,
                Alumno.Celular,
                Alumno.Correo,
                Alumno.Genero
                from PositivoAlumno
                inner join Alumno on Alumno.id = PositivoAlumno.id
                inner join AlumnoGrupo on AlumnoGrupo.F_Alumn = Alumno.id
                inner join GrupoCuatrimestre on GrupoCuatrimestre.id = AlumnoGrupo.id
                inner join Cuatrimestre on Cuatrimestre.id = GrupoCuatrimestre.F_Cuatri
                inner join ProgramaEducativo on ProgramaEducativo.id = GrupoCuatrimestre.F_ProgEd
                inner join Grupo on Grupo.id = GrupoCuatrimestre.F_Grupo
                where  Cuatrimestre.id = 1  and ProgramaEducativo.id = 1 and Grupo.id = 1
                ";
            com.Parameters.AddWithValue("@cuatri", cuatri);
            com.Parameters.AddWithValue("@educativo", educativo);
            com.Parameters.AddWithValue("@grupo", grupo);
            reader = com.ExecuteReader();
            return reader;
        }
        public SqlDataReader AlumnoSeguimiento(int cuatri, string matri)
        {
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlDataReader reader;
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.CommandText = @"select
                Alumno.Ap_pat,
                Alumno.Ap_mat,
                Alumno.Nombre,
                Alumno.Genero,
                Alumno.Correo,
                SeguimientoAL.Entrevista,
                SeguimientoAL.Fecha,
                SeguimientoAL.Reporte,
                SeguimientoAL.Form_Comunica
                from
                SeguimientoAL
                inner join PositivoAlumno on PositivoAlumno.id = SeguimientoAL.F_PositivoAL
                inner join Alumno on Alumno.id = PositivoAlumno.F_Alumno
                inner join AlumnoGrupo on AlumnoGrupo.F_Alumn = Alumno.id
                inner join GrupoCuatrimestre on GrupoCuatrimestre.id = AlumnoGrupo.id
                inner join Cuatrimestre on Cuatrimestre.id = GrupoCuatrimestre.F_Cuatri
                where Cuatrimestre.id = @cuatri and Alumno.Matricula = @matri
                ";
            com.Parameters.AddWithValue("@cuatri", cuatri);
            com.Parameters.AddWithValue("@matri", matri);
            reader = com.ExecuteReader();
            return reader;
        }
        public SqlDataReader ProfesorContagiado(int registro)
        {
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlDataReader reader;
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.CommandText = @"
                select
                Profesor.Ap_pat,
                Profesor.Ap_Mat,
                Profesor.Nombre,
                Profesor.Categoria,
                Profesor.Celular,
                Profesor.Genero,
                PositivoProfe.Antecedentes,
                PositivoProfe.Comprobacion,
                PositivoProfe.FechaConfirmado,
                PositivoProfe.NumContaio,
                PositivoProfe.discpacidad
                from PositivoProfe
                inner join Profesor on Profesor.id = PositivoProfe.F_Profe
                where Profesor.RegistroEmpleado = @registro
                ";
            com.Parameters.AddWithValue("@registro", registro);
            reader = com.ExecuteReader();
            return reader;
        }
    }
}
