using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassNegocio;
using ClassEntidad;

namespace WebApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ClassNego bl = new ClassNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void buttonProfe_Click(object sender, EventArgs e)
        {
            Label1.Text = bl.crearProfesor(new Profesor()
            {
                RegistroEmpleado = 220,
                Nombre = "Rodrigo",
                Ap_pat = "Martinez",
                Ap_Mat = "Mendez",
                Genero = "H",
                Correo = "rodrigo@hotmail.com",
                Celular = "2228587820",
                F_EdoCivil = 1,
                Categoria = "Profesor de Tiempo completo"
            });
        }

        protected void buttonAlumno_Click(object sender, EventArgs e)
        {
            Label1.Text = bl.crearAlumno(new Alumno()
            {
                Matricula = "UTP12360",
                Nombre = "Rodrigo",
                Ap_pat = "Martinez",
                Ap_mat = "Mendez",
                Genero = "H",
                Correo = "rodrigo@hotmail.com",
                Celular = "2228587820",
                f_edoCivil = 1
            });
        }
    }
}