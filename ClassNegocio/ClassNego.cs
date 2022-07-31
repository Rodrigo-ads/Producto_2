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
    }
}
