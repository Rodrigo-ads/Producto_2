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
                SqlDataReader civil = obj.ObtenerTablas("EstadoCivil");
                SqlDataReader idPro = obj.ObtenerTablas("Profesor");
                SqlDataReader idAlumGrup = obj.ObtenerTablas("AlumnoGrupo");
                DropDownListProfeCivil.Items.Clear();
                DropDownProfesorID.Items.Clear();
                DropDownListAlumnoGrupo_Alumno.Items.Clear();
                DropDownListAlumnoGrupo_Alumno.Items.Add("Seleccione una opcion");
                while (civil.Read())
                {
                    DropDownListProfeCivil.Items.Add(new ListItem()
                    {
                        Text = civil[1].ToString(),
                        Value = civil[0].ToString()
                    });

                }
                while (idPro.Read())
                {
                    DropDownProfesorID.Items.Add(idPro[1].ToString());
                }

                while (idAlumGrup.Read())
                {
                    DropDownListAlumnoGrupo_Alumno.Items.Add(idAlumGrup[1].ToString());
                }
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

        protected void DropDownProfesorID_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                SqlDataReader reader = obj.ObtenerTablas("Profesor where RegistroEmpleado=" + DropDownProfesorID.SelectedValue);
                while (reader.Read())
                {
                    TextBoxProfesorMaterno.Text = reader[4].ToString();
                    TextBoxProfesorPaterno.Text = reader[3].ToString();
                    TextBoxProfesorCelular.Text = reader[8].ToString();
                    TextBoxProfesorCorreo.Text = reader[7].ToString();
                    TextBoxProfesorGenero.Text = reader[5].ToString();
                    (DropDownListProfeCivil.SelectedValue) = reader[9].ToString();
                    TextBoxProfesorNombre.Text = reader[2].ToString();
                    TextBoxProfesorCategoria.Text = reader[6].ToString();
                }
            }
            catch (Exception ex)
            {
                Label2.Text = ex.Message;
            }
        }

        protected void ActualizarPro_Click(object sender, EventArgs e)
        {
            try
            {

                Label2.Text = obj.ActualizarProfesor(new ClassEntidad.Profesor()
                {
                    RegistroEmpleado = Int32.Parse(DropDownProfesorID.SelectedValue),
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

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {

                Label2.Text = obj.ActualizarAlumnoGrupo(new ClassEntidad.AlumnoGrupo()
                {
                    f_alumn = Convert.ToInt32(DropDownListAlumnoGrupo_Alumno.SelectedValue),
                    f_grucuat = Convert.ToInt32(TextBoxGrupoCuatri.Text),
                    extra = TextBoxAlumnoGrupo_Extra1.Text,
                    extra2 = TextBoxAlumnoGrupo_Extra1.Text
                });
            }
            catch (Exception Ex)
            {
                Label2.Text = Ex.Message;
            }
        }

        protected void DropDownListAlumnoGrupo_Alumno_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownListAlumnoGrupo_Alumno.SelectedIndex == 0)
            {
                Label2.Text = "Seleccione una opcion correcta";
            }
            else
            {
                try
                {

                    SqlDataReader reader = obj.ObtenerTablas("AlumnoGrupo where F_Alumn=" + DropDownListAlumnoGrupo_Alumno.SelectedValue);
                    while (reader.Read())
                    {
                        TextBoxGrupoCuatri.Text = reader[2].ToString();
                        TextBoxAlumnoGrupo_Extra1.Text = reader[3].ToString();
                        TextBoxAlumnoGrupo_Extra1.Text = reader[4].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Label2.Text = ex.Message;
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