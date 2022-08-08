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
                Alumno.id as 'ID_Alumno',
                Alumno.Ap_pat,
                Alumno.Ap_Mat,
                Alumno.Nombre,
                Alumno.Celular,
                Alumno.Correo,
                Alumno.Genero
                from PositivoAlumno
                inner join Alumno on Alumno.id = PositivoAlumno.F_Alumno
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
                inner join Alumno on Alumno.id = PositivoAlumno.F_Alumno
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
                inner join PositivoAlumno on PositivoAlumno.F_Alumno = SeguimientoAL.F_PositivoAL
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

        public string InsertaCarrera(Carrera carrera)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@nomCarrera", carrera.nombreCarrera);
            com.CommandText = "insert into Carrera values(@nomCarrera);";
            com.ExecuteNonQuery();
            respuesta = "Se creó una nueva carrera";
            conexion.Close();
            return respuesta;
        }

        public string InsertaProgramaEducativo(ProgramaEducativo programaEducativo)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@ProgramaED", programaEducativo.ProgramaEd);
            com.Parameters.AddWithValue("@F_Carrera", programaEducativo.F_Carrera);
            com.Parameters.AddWithValue("@Extra", programaEducativo.Extra);
            com.CommandText = "insert into ProgramaEducativo values(@ProgramaED, @F_Carrera, @Extra);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo programa educativo";
            conexion.Close();
            return respuesta;
        }

        public string InsertaGrupo(Grupo grupo)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@Grado", grupo.Grado);
            com.Parameters.AddWithValue("@Letra", grupo.Letra);
            com.Parameters.AddWithValue("@Extra", grupo.extra);
            com.CommandText = "insert into ProgramaEducativo values(@ProgramaED, @F_Carrera, @Extra);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo grupo";
            conexion.Close();
            return respuesta;
        }

        public string InsertaGrupoCuatrimestre(GrupoCuatrimestre grupoCuatrimestre)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@F_ProgEd", grupoCuatrimestre.F_prod);
            com.Parameters.AddWithValue("@F_Grupo", grupoCuatrimestre.F_Grupo);
            com.Parameters.AddWithValue("@F_Cuatri", grupoCuatrimestre.F_Cuatri);
            com.Parameters.AddWithValue("@Turno", grupoCuatrimestre.Turno);
            com.Parameters.AddWithValue("@Modalidad", grupoCuatrimestre.Modalidad);
            com.Parameters.AddWithValue("@Extra", grupoCuatrimestre.Extra);
            com.CommandText = "insert into GrupoCuatrimestre values(@F_ProgEd, @F_Grupo, @F_Cuatri, @Turno, @Modalidad, @Extra);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo grupoCuatrimestre";
            conexion.Close();
            return respuesta;
        }

        public string InsertaCuatrimestre(Cuatrimestre cuatrimestre)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@Periodo", cuatrimestre.Periodo);
            com.Parameters.AddWithValue("@Anio", cuatrimestre.Anio);
            com.Parameters.AddWithValue("@Inicio", cuatrimestre.Inicio);
            com.Parameters.AddWithValue("@Fin", cuatrimestre.fin);
            com.Parameters.AddWithValue("@Extra", cuatrimestre.Extra);
            com.CommandText = "insert into Cuatrimestre values(@Periodo, @Anio, @Inicio, @Fin, @Extra);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo Cuatrimestre";
            conexion.Close();
            return respuesta;
        }
        public string InsertaAlumnoGrupo(AlumnoGrupo alumnoGrupo)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@F_Alumn", alumnoGrupo.f_alumn);
            com.Parameters.AddWithValue("@F_GruCuat", alumnoGrupo.f_grucuat);
            com.Parameters.AddWithValue("@Extra", alumnoGrupo.extra);
            com.Parameters.AddWithValue("@Extra2", alumnoGrupo.extra2);
            com.CommandText = "insert into AlumnoGrupo values(@F_Alumn, @F_GruCuat, @Extra, @Extra2);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo AlumnoGrupo";
            conexion.Close();
            return respuesta;
        }
        public string InsertaEstadoCivil(EstadoCivil estadoCivil)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@Estado", estadoCivil.Estado);
            com.Parameters.AddWithValue("@Extra", estadoCivil.Extra);
            com.CommandText = "insert into EstadoCivil values(@Estado, @Extra);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo Estado Civil";
            conexion.Close();
            return respuesta;
        }
        public string InsertaPositivoProfe(PositivoProfe positivoProfe)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@FechaConfirmado", positivoProfe.FechaConfirmado);
            com.Parameters.AddWithValue("@Comprobacion", positivoProfe.Comprobacion);
            com.Parameters.AddWithValue("@Antecedentes", positivoProfe.Antecedentes);
            com.Parameters.AddWithValue("@Riesgo", positivoProfe.Riesgo);
            com.Parameters.AddWithValue("@NumContai", positivoProfe.NumContaio);
            com.Parameters.AddWithValue("@Extra", positivoProfe.Extra);
            com.Parameters.AddWithValue("@F_Profe", positivoProfe.F_Profe);
            com.Parameters.AddWithValue("@imagen", positivoProfe.Imagen);
            com.Parameters.AddWithValue("@discapacidad", positivoProfe.Discapacidad);
            com.CommandText = "insert into PositivoProfe values(@FechaConfirmado, @Comprobacion, @Antecedentes, @Riesgo, @NumContai, @Extra, @F_Profe, @imagen, @discapacidad);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo Positivo Profe";
            conexion.Close();
            return respuesta;
        }
        public string InsertaSeguimientoPro(SeguimientoPRO seguimientoPRO)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@F_positivoProfe", seguimientoPRO.F_positivoProfe);
            com.Parameters.AddWithValue("@F_medico", seguimientoPRO.F_medico);
            com.Parameters.AddWithValue("@Fecha", seguimientoPRO.Fecha);
            com.Parameters.AddWithValue("@Form_comunica", seguimientoPRO.Form_Comunica);
            com.Parameters.AddWithValue("@Reporte", seguimientoPRO.Reporte);
            com.Parameters.AddWithValue("@Entrevista", seguimientoPRO.Entrevista);
            com.Parameters.AddWithValue("@Extra", seguimientoPRO.Extra);
            com.Parameters.AddWithValue("@imagen", seguimientoPRO.Imagen);
            com.CommandText = "insert into SeguimientoPRO values(@F_positivoProfe, @F_medico, @Fecha, @Form_comunica, @Reporte, @Entrevista, @Extra, @imagen);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo Seguimiento PRO";
            conexion.Close();
            return respuesta;
        }
        public string InsertaProfeGrupo(ProfeGrupo profeGrupo)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@F_Profe", profeGrupo.F_Profe);
            com.Parameters.AddWithValue("@F_GruCuat", profeGrupo.F_GruCuat);
            com.Parameters.AddWithValue("@Extra", profeGrupo.Extra);
            com.Parameters.AddWithValue("@Extra2", profeGrupo.Extra2);
            com.CommandText = "insert into ProfeGRupo values(@F_Profe, @F_GruCuat, @Extra, @Extra2);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo ProfeGrupo";
            conexion.Close();
            return respuesta;
        }
        public string InsertaMedico(Medico medico)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@Nombre", medico.Nombre);
            com.Parameters.AddWithValue("@App", medico.App);
            com.Parameters.AddWithValue("@Apm", medico.Apm);
            com.Parameters.AddWithValue("@Telefono", medico.Telefono);
            com.Parameters.AddWithValue("@correo", medico.correo);
            com.Parameters.AddWithValue("@horario", medico.horario);
            com.Parameters.AddWithValue("@especialidad", medico.especialidad);
            com.Parameters.AddWithValue("@extra", medico.extra);
            com.CommandText = "insert into Medico values(@Nombre, @App, @Apm, @Telefono, @correo, @horario, @especialidad, @extra);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo Medico";
            conexion.Close();
            return respuesta;
        }
        public string InsertaSeguimientoAl(SeguimientoAL seguimientoAL)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@F_PositivoAL", seguimientoAL.F_PositivoAL);
            com.Parameters.AddWithValue("@F_medico", seguimientoAL.F_medico);
            com.Parameters.AddWithValue("@Fecha", seguimientoAL.Fecha);
            com.Parameters.AddWithValue("@Form_Comunica", seguimientoAL.Form_Comunica);
            com.Parameters.AddWithValue("@Reporte", seguimientoAL.Reporte);
            com.Parameters.AddWithValue("@Entrevista", seguimientoAL.Entrevista);
            com.Parameters.AddWithValue("@Extra", seguimientoAL.Extra);
            com.CommandText = "insert into SeguimientoAL values(@F_PositivoAL, @F_medico, @Fecha, @Form_Comunica, @Reporte, @Entrevista, @Extra);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo SeguimientoAL";
            conexion.Close();
            return respuesta;
        }
        public string InsertaPositivoAlumno(PositivoAlumno positivoAlumno)
        {
            string respuesta = "";
            SqlConnection conexion = new SqlConnection(Cadena);
            conexion.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.Parameters.AddWithValue("@FechaConfirmado", positivoAlumno.FechaConfirmado);
            com.Parameters.AddWithValue("@Comprobacion", positivoAlumno.Comprobacion);
            com.Parameters.AddWithValue("@Antecedentes", positivoAlumno.Antecedentes);
            com.Parameters.AddWithValue("@Riesgo", positivoAlumno.Riesgo);
            com.Parameters.AddWithValue("@NumContagio", positivoAlumno.NumContagio);
            com.Parameters.AddWithValue("@Extra", positivoAlumno.Extra);
            com.Parameters.AddWithValue("@F_Alumno", positivoAlumno.F_Alumno);
            com.CommandText = "insert into PositivoAlumno values(@FechaConfirmado, @Comprobacion, @Antecedentes, @Riesgo, @NumContagio, @Extra, @F_Alumno);";
            com.ExecuteNonQuery();
            respuesta = "Se creó un nuevo PositivoAlumno";
            conexion.Close();
            return respuesta;
        }



    }
}
