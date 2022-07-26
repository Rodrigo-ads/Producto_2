using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDAL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClassNegocio
{
    public class ClassNego
    {
        ClaseDAL obj = null;

        public string AbrirCadenaConexion()
        {
            return obj.AbrirConexion();
        }

        public void CerrarCadenaConexion()
        {
            obj.CerrarConexion();
        }

        public string consultarProfes()
        {
            string consulta = "SELECT * FROM PROFESOR";
            return consulta;
        }
    }
}
