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
    public partial class Crear : System.Web.UI.Page
    {
        ClassNego obj = new ClassNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlDataReader civil = obj.ObtenerTablas("EstadoCivil");
                DropDownLisCivil.Items.Clear();
                while (civil.Read())
                {
                    DropDownLisCivil.Items.Add(new ListItem()
                    {
                        Text = civil[1].ToString(),
                        Value = civil[0].ToString()
                    });
                    DropDownListProfeCivil.Items.Add(new ListItem()
                    {
                        Text = civil[1].ToString(),
                        Value = civil[0].ToString()
                    });
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = obj.crearAlumno(new ClassEntidad.Alumno()
            {
                Matricula = TextBoxAlumnoMatricula.Text,
                Ap_mat = TextBoxAlumnomaterno.Text,
                Ap_pat = TextBoxAlumnopaterno.Text,
                Celular = TextBoxAlumnocelular.Text,
                Correo = TextBoxAlumnocorreo.Text,
                Genero = TextBoxAlumnogenero.Text,
                f_edoCivil = Int32.Parse(DropDownLisCivil.SelectedValue),
                Nombre = TextBoxAlumnoNombre.Text
            });
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            try
            {

                Label2.Text = obj.crearProfesor(new ClassEntidad.Profesor()
                {
                    RegistroEmpleado = Int32.Parse(TextBoxProfesorRegistro.Text),
                    Ap_Mat = TextBoxProfesorMaterno.Text,
                    Ap_pat = TextBoxProfesorPaterno.Text,
                    Celular = TextBoxProfesorCelular.Text,
                    Correo = TextBoxProfesorCorreo.Text,
                    Genero = TextBoxProfesorGenero.Text,
                    F_EdoCivil = Int32.Parse(DropDownListProfeCivil.SelectedValue),
                    Nombre = TextBoxProfesorNombre.Text,
                    Categoria = TextBoxProfesorCategoria.Text
                });
            }
            catch (Exception Ex)
            {
                Label2.Text = Ex.Message;
            }
        }
    }
}