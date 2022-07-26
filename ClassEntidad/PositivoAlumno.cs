using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidad
{
    public class PositivoAlumno
    {
        public int ID_posAl { set; get; }
        public string FechaConfirmado { set; get; }
        public string Comprobacion { set; get; }
        public string Antecedentes { set; get; }
        public string Riesgo { set; get; }
        public int NumContagio { set; get; }
        public string Extra { set; get; }
        public int F_Alumno { set; get; }
    }
}
