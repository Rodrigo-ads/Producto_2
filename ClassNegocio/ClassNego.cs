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
    }
}
