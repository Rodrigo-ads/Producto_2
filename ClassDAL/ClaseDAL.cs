using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassDAL
{
    public class ClaseDAL
    {
        private string cadConexion;
        private SqlConnection conexionGlobal = null;

        public ClaseDAL(string cadenaDB)
        {
            cadConexion = cadenaDB;
            conexionGlobal = new SqlConnection();
        }

        public string AbrirConexion()
        {
            string msj = "";
            conexionGlobal.ConnectionString = cadConexion;
            try
            {
                conexionGlobal.Open();
                msj = "Conexión abierta CORRECTAMENTE";
            }
            catch (Exception f)
            {
                conexionGlobal = null;
                msj = "Error " + f.Message;
            }
            return msj;
        }

        public void CerrarConexion()
        {
            if(conexionGlobal != null)
            {
                if(conexionGlobal.State == ConnectionState.Open)
                {
                    conexionGlobal.Close();
                    conexionGlobal.Dispose();
                }
            }
        }

        public DataSet ConsultaDS(string querySQL, ref string msj)
        {
            SqlCommand carrito = null;
            SqlDataAdapter trailer = null;
            DataSet DS_salida = new DataSet();

            msj = AbrirConexion();

            if (conexionGlobal == null)
            {
                msj = "No hay conexion a la BD";
                DS_salida = null;
            }
            else
            {
                carrito = new SqlCommand();
                carrito.CommandText = querySQL;
                carrito.Connection = conexionGlobal;

                trailer = new SqlDataAdapter();
                trailer.SelectCommand = carrito;

                try
                {
                    trailer.Fill(DS_salida, "Consulta1");
                    msj = "Consulta Correcta en DataSet";
                }
                catch (Exception a)
                {
                    DS_salida = null;
                    msj = "Error!" + a.Message;
                }
                conexionGlobal.Close();
                conexionGlobal.Dispose();
            }
            return DS_salida;
        }
       


    }
}
