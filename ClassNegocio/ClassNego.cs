using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDAL;
using ClassEntidad;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClassNegocio
{
    public class ClassNego
    {
        ClaseDAL obj = new ClaseDAL();

        public string crearAlumno(Alumno alumno)
        {
            return obj.InsertaAlumno(alumno);
        }
        public string crearProfesor(Profesor profesor)
        {
            return obj.InsertaProfe(profesor);
        }
        public SqlDataReader ObtenerTablas(string tabla)
        {
            return obj.Select(tabla);

        }
        public string EliminarRegistro(string table, int id)
        {
            return obj.Delete(table, id);
        }
        public SqlDataReader ProfesContagiados(int cuatri, int progra)
        {
            return obj.ProfesContagiados(cuatri, progra);
        }
        public SqlDataReader AlumnosContagiados(int cuatri, int progra)
        {
            return obj.AlumnoContagiados(cuatri, progra);
        }
        public SqlDataReader AlumnoContagiadosGrupo(int cuatri, int progra, int grupo)
        {
            return obj.AlumnoContagiadosGrupo(cuatri, progra, grupo);
        }
        public SqlDataReader AlumnoSeguimiento(int cuatri, string matri)
        {
            return obj.AlumnoSeguimiento(cuatri, matri);
        }
        public SqlDataReader ProfesorContagios(int registro)
        {
            return obj.ProfesorContagiado(registro);
        }

        public string crearCarrera(Carrera carrera)
        {
            return obj.InsertaCarrera(carrera);
        }

        public string crearProgramaEducativo(ProgramaEducativo programaEducativo)
        {
            return obj.InsertaProgramaEducativo(programaEducativo);
        }
        public string crearGrupo(Grupo grupo)
        {
            return obj.InsertaGrupo(grupo);
        }
        public string crearGrupoCuatrimestre(GrupoCuatrimestre grupoCuatrimestre)
        {
            return obj.InsertaGrupoCuatrimestre(grupoCuatrimestre);
        }
        public string crearCuatrimestre(Cuatrimestre cuatrimestre)
        {
            return obj.InsertaCuatrimestre(cuatrimestre);
        }
        public string creaAlumnoGrupo(AlumnoGrupo alumnoGrupo)
        {
            return obj.InsertaAlumnoGrupo(alumnoGrupo);
        }
        public string creaEstadoCivil(EstadoCivil estadoCivil)
        {
            return obj.InsertaEstadoCivil(estadoCivil);
        }
        public string creaPositivoProfe(PositivoProfe positivoProfe)
        {
            return obj.InsertaPositivoProfe(positivoProfe);
        }
        public string creaPositivoProfe(SeguimientoPRO seguimientoPRO)
        {
            return obj.InsertaSeguimientoPro(seguimientoPRO);
        }
        public string creaProfeGrupo(ProfeGrupo profeGrupo)
        {
            return obj.InsertaProfeGrupo(profeGrupo);
        }
        public string creaMedico(Medico medico)
        {
            return obj.InsertaMedico(medico);
        }
        public string creaSeguimientoAl(SeguimientoAL seguimientoAL)
        {
            return obj.InsertaSeguimientoAl(seguimientoAL);
        }
        public string creaPositivoAlumno(PositivoAlumno positivoAlumno)
        {
            return obj.InsertaPositivoAlumno(positivoAlumno);

        }

        public string actualizarCuatrimestre(Cuatrimestre cuatri)
        {
            return obj.ActualizaCuatrimestre(cuatri);
        }

        public string ActualizarProfesor(Profesor profesor)
        {
            return obj.ActualizarProfe(profesor);
        }
        public string ActualizarAlumnoGrupo(AlumnoGrupo alumnoGrupo)
        {
            return obj.ActualizarAlumnoGrupo(alumnoGrupo);
        }
    }

}
