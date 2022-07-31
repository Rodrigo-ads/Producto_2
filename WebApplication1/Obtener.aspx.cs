using ClassNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Obtener : System.Web.UI.Page
    {
        ClassNego obj = new ClassNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

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
            string tabla = DropDownList1.SelectedValue;
            if (DropDownList1.SelectedIndex != 0)
            {
                GridView1.DataSource = obj.ObtenerTablas(tabla);
                GridView1.DataBind();
                Label1.Text = "";
            }
            else
            {
                Label1.Text = "Seleccione una tabla!";

            }
        }




    }
}