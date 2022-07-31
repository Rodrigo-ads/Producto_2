using ClassNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Eliminar : System.Web.UI.Page
    {
        ClassNego obj = new ClassNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.AutoPostBack = true;
                DropDownList1.Items.Clear();
                DropDownList1.Items.Add("Seleccione la tabla");
                DropDownList1.Items.Add("Alumno");
                DropDownList1.Items.Add("Profesor");
                DropDownList1.Items.Add("Cuatrimestre");
                DropDownList1.Items.Add("grupoCuatrimestre");
                DropDownList1.Items.Add("AlumnoGRupo");
                DropDownList1.Items.Add("ProfeGrupo");
                DropDownList1.Items.Add("positivoProfe");
                DropDownList1.Items.Add("positivoAlumno");
                DropDownList1.Items.Add("SeguimientoPRO");
                DropDownList1.Items.Add("SeguimientoAL");
                DropDownList1.Items.Add("Medico");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedIndex != 0 || DropDownList1.SelectedIndex != 0)
            {
                int id = Int32.Parse(DropDownList2.SelectedValue);
                Label1.Text = obj.EliminarRegistro(DropDownList1.SelectedValue, id);
            }
            else
            {
                Label1.Text = "Seleccione un registro!";
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex != 0)
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add(new ListItem()
                {
                    Value = "0",
                    Text = "Seleccione el registro"
                });
                string seleccionada = DropDownList1.SelectedValue;
                SqlDataReader tabla = obj.ObtenerTablas(seleccionada);
                while (tabla.Read())
                {
                    DropDownList2.Items.Add(new ListItem()
                    {
                        Value = tabla[0].ToString(),
                        Text = tabla[0].ToString() + " - " + tabla[1].ToString() + " - " + tabla[2].ToString()
                    });
                }
            }
            else
            {
                DropDownList2.Items.Clear();
                Label1.Text = "Seleccione una tabla!";
            }

        }
    }
}