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
    public partial class WebForm1 : System.Web.UI.Page
    {
        ClassNego obj = new ClassNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlDataReader Cuatrimestre = obj.ObtenerTablas("Cuatrimestre");
                SqlDataReader ProgramaEducativo = obj.ObtenerTablas("ProgramaEducativo");
                SqlDataReader grupos = obj.ObtenerTablas("Grupo");

                DropDownList1.Items.Clear();
                DropDownList1.Items.Add("Seleccione el cuatrimestre");
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add("Seleccione el cuatrimestre");
                DropDownList6.Items.Clear();
                DropDownList6.Items.Add("Seleccione el cuatrimestre");

                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Seleccione el Programa");
                DropDownList4.Items.Clear();
                DropDownList4.Items.Add("Seleccione el Programa");

                DropDownList5.Items.Clear();
                DropDownList5.Items.Add("Seleccione un Grupo");


                while (Cuatrimestre.Read())
                {
                    DropDownList1.Items.Add(new ListItem()
                    {
                        Text = Cuatrimestre[1].ToString(),
                        Value = Cuatrimestre[0].ToString()
                    });
                    DropDownList3.Items.Add(new ListItem()
                    {
                        Text = Cuatrimestre[1].ToString(),
                        Value = Cuatrimestre[0].ToString()
                    });
                    DropDownList6.Items.Add(new ListItem()
                    {
                        Text = Cuatrimestre[1].ToString(),
                        Value = Cuatrimestre[0].ToString()
                    });
                }
                while (ProgramaEducativo.Read())
                {
                    DropDownList2.Items.Add(new ListItem()
                    {
                        Text = ProgramaEducativo[1].ToString(),
                        Value = ProgramaEducativo[0].ToString()
                    });
                    DropDownList4.Items.Add(new ListItem()
                    {
                        Text = ProgramaEducativo[1].ToString(),
                        Value = ProgramaEducativo[0].ToString()
                    });
                }
                while (grupos.Read())
                {
                    DropDownList5.Items.Add(new ListItem()
                    {
                        Text = grupos[1].ToString() + " - " + grupos[2].ToString(),
                        Value = grupos[0].ToString()
                    });
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0 || DropDownList2.SelectedIndex == 0)
            {
                Label1.Text = "seleccione un cuatrimestre y un programa educativo";
            }
            else
            {
                int cuatri = Int32.Parse(DropDownList1.SelectedValue);
                int programa = Int32.Parse(DropDownList2.SelectedValue);
                GridView1.DataSource = obj.ProfesContagiados(cuatri, programa);
            }
            GridView1.DataBind();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0 || DropDownList2.SelectedIndex == 0)
            {
                Label1.Text = "seleccione un cuatrimestre y un programa educativo";
            }
            else
            {
                int cuatri = Int32.Parse(DropDownList1.SelectedValue);
                int programa = Int32.Parse(DropDownList2.SelectedValue);
                GridView1.DataSource = obj.AlumnosContagiados(cuatri, programa);
            }
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (DropDownList3.SelectedIndex == 0 || DropDownList4.SelectedIndex == 0 || DropDownList5.SelectedIndex == 0)
            {
                Label2.Text = "seleccione un cuatrimestre, un programa educativo y un grupo";
            }
            else
            {
                int cuatri = Int32.Parse(DropDownList3.SelectedValue);
                int programa = Int32.Parse(DropDownList4.SelectedValue);
                int grupo = Int32.Parse(DropDownList5.SelectedValue);

                GridView2.DataSource = obj.AlumnoContagiadosGrupo(cuatri, programa, grupo);
            }
            GridView2.DataBind();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (DropDownList6.SelectedIndex == 0)
            {
                Label2.Text = "seleccione un cuatrimestre";
            }
            else
            {
                string matri = TextBox1.Text;
                int cuatri = Int32.Parse(DropDownList6.SelectedValue);

                GridView3.DataSource = obj.AlumnoSeguimiento(cuatri, matri);
            }
            GridView3.DataBind();
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                int registro = Int32.Parse(TextBox2.Text);

                GridView4.DataSource = obj.ProfesorContagios(registro);
                GridView4.DataBind();
            }
            catch (Exception ex)
            {
                Label4.Text = "Ingrese un numero valido";
            }
        }
    }
}