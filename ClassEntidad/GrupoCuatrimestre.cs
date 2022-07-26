using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidad
{
    public class GrupoCuatrimestre
    {
        public int Id_GruCua { set; get; }
        public int F_prod { set; get; }
        public int F_Grupo { set; get; }
        public int F_Cuatri { set; get; }
        public string Turno { set; get; }
        public string Modalidad { set; get; }
        public string Extra { set; get; }
    }
}
