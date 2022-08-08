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

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownListCuatrimestrePeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader reader = obj.ObtenerTablas("Cuatrimestre WHERE Periodo=" + DropDownListCuatrimestrePeriodo.SelectedValue);
                TextBoxCuatrimestreAnio.Text = reader[2].ToString();
                TextBoxCuatrimestreInicio.Text = reader[3].ToString();
                TextBoxCuatrimestreFin.Text = reader[4].ToString();
                TextBoxCuatrimestreExtra.Text = reader[5].ToString();
            }
            catch(Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}