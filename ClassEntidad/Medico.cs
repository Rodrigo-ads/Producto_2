using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidad
{
    public class Medico
    {
        public int ID_dr { get; set; }
        public string Nombre { get; set; }
        public string App { set; get; }
        public string Apm { set; get; }
        public string Telefono { set; get; }
        public string correo { set; get; }
        public string horario { set; get; }
        public string especialidad { set; get; }
        public string extra { set; get; }
    }
}
