using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidad
{
    public class SeguimientoAL
    {
        public int Id_Seguimiento { set; get; }
        public int F_PositivoAL { set; get; }
        public int F_medico { set; get; }
        public string Fecha { set; get; }
        public string Form_Comunica { set; get; }
        public string Reporte { set; get; }
        public string Entrevista { set; get; }
        public string Extra { set; get; }
    }
}
