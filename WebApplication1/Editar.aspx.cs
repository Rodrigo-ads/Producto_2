using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassNegocio;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Actualizar : System.Web.UI.Page
    {
        ClassNego obj = new ClassNego();
        int id_Cuatri = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListCuatrimestrePeriodo.AutoPostBack = true;
                SqlDataReader Cuatrimestre = obj.ObtenerTablas("Cuatrimestre");

                DropDownListCuatrimestrePeriodo.Items.Clear();
                DropDownListCuatrimestrePeriodo.Items.Add("Selecciona el Periodo");

                while (Cuatrimestre.Read())
                {
                    DropDownListCuatrimestrePeriodo.Items.Add(new ListItem()
                    {
                        Text = Cuatrimestre[1].ToString(),
                        Value = Cuatrimestre[0].ToString()
                    });
                }
            }
        }


        protected void DropDownListCuatrimestrePeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader reader = obj.ObtenerTablas("Cuatrimestre where id="+ DropDownListCuatrimestrePeriodo.SelectedValue);
                id_Cuatri = Convert.ToInt32(DropDownListCuatrimestrePeriodo.SelectedValue);
                while (reader.Read())
                {
                    TextBoxCuatrimestreAnio.Text = reader[2].ToString();
                    TextBoxCuatrimestreInicio.Text = reader[3].ToString();
                    TextBoxCuatrimestreFin.Text = reader[4].ToString();
                    TextBoxCuatrimestreExtra.Text = reader[5].ToString();
                }
                Response.Write(id_Cuatri);
                
            }
            catch(Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }

        protected void btnCuatrimestre_Click(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = obj.actualizarCuatrimestre(new ClassEntidad.Cuatrimestre()
                {
                    Id_Cuatrimestre = Convert.ToInt32(DropDownListCuatrimestrePeriodo.SelectedValue),
                    Anio = Convert.ToInt32(TextBoxCuatrimestreAnio.Text),
                    Inicio = TextBoxCuatrimestreInicio.Text,
                    fin = TextBoxCuatrimestreFin.Text,
                    Extra = TextBoxCuatrimestreExtra.Text
                });
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}