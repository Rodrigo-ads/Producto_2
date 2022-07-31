using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidad
{
    public class Alumno
    {
        public int ID_Alumno { set; get; }
        public string Matricula { set; get; }
        public string Nombre { set; get; }
        public string Ap_pat { set; get; }
        public string Ap_mat { set; get; }
        public string Genero { set; get; }
        public string Correo { set; get; }
        public string Celular { set; get; }
        public int f_edoCivil { set; get; }
    }
}
