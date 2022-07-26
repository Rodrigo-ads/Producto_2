using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidad
{
    public class Profesor
    {
        public int ID_Profe { set; get; }
        public int RegistroEmpleado { set; get; }
        public string Nombre { set; get; }
        public string Ap_pat { set; get; }
        public string Ap_Mat { set; get; }
        public string Genero { set; get; }
        public string Categoria { set; get; }
        public string Correo { set; get; }
        public string Celular { set; get; }
        public int F_EdoCivil { set; get; }
    }
}
