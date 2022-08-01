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

                DropDownListGrupoCuatrimestre_Programa.Items.Clear();
                SqlDataReader programaEducativo = obj.ObtenerTablas("ProgramaEducativo");
                while (programaEducativo.Read())
                {
                    DropDownListGrupoCuatrimestre_Programa.Items.Add(new ListItem()
                    {
                        Text = programaEducativo[1].ToString() + " - " + programaEducativo[2].ToString(),
                        Value = programaEducativo[0].ToString()
                    });
                }

                DropDownListGrupoCuatrimestre_Grupo.Items.Clear();
                SqlDataReader grupo = obj.ObtenerTablas("Grupo");
                while (grupo.Read())
                {
                    DropDownListGrupoCuatrimestre_Grupo.Items.Add(new ListItem()
                    {
                        Text = grupo[1].ToString() + " - " + grupo[2].ToString(),
                        Value = grupo[0].ToString()
                    });
                }

                DropDownListGrupoCuatrimestre_Cuatri.Items.Clear();
                SqlDataReader Cuatri = obj.ObtenerTablas("Cuatrimestre");
                while (Cuatri.Read())
                {
                    DropDownListGrupoCuatrimestre_Cuatri.Items.Add(new ListItem()
                    {
                        Text = Cuatri[1].ToString() + " - " + Cuatri[2].ToString(),
                        Value = Cuatri[0].ToString()
                    });
                }

                DropDownListAlumnoGrupo_Alumno.Items.Clear();
                DropDownListPositivoAlumno_Alumno.Items.Clear();
                SqlDataReader Alumno = obj.ObtenerTablas("Alumno");
                while (Alumno.Read())
                {
                    DropDownListAlumnoGrupo_Alumno.Items.Add(new ListItem()
                    {
                        Text = Alumno[1].ToString() + " - " + Alumno[2].ToString(),
                        Value = Alumno[0].ToString()
                    });
                    DropDownListPositivoAlumno_Alumno.Items.Add(new ListItem()
                    {
                        Text = Alumno[1].ToString() + " - " + Alumno[2].ToString(),
                        Value = Alumno[0].ToString()
                    });
                }

                DropDownListAlumnoGrupo_GrupoCuatri.Items.Clear();
                DropDownListProfeGrupo_GrupoCuatri.Items.Clear();
                SqlDataReader GrupoCuatri =  obj.ObtenerTablas("GrupoCuatrimestre");
                while (GrupoCuatri.Read())
                {
                    DropDownListAlumnoGrupo_GrupoCuatri.Items.Add(new ListItem()
                    {
                        Text = GrupoCuatri[1].ToString() + " - " + GrupoCuatri[2].ToString(),
                        Value = GrupoCuatri[0].ToString()
                    });
                    DropDownListProfeGrupo_GrupoCuatri.Items.Add(new ListItem()
                    {
                        Text = GrupoCuatri[1].ToString() + " - " + GrupoCuatri[2].ToString(),
                        Value = GrupoCuatri[0].ToString()
                    });
                }

                DropDownListProfeGrupo_Profe.Items.Clear();
                DropDownListPositivoProfe_Profesor.Items.Clear();
                SqlDataReader Profesor = obj.ObtenerTablas("Profesor");
                while (Profesor.Read())
                {
                    DropDownListProfeGrupo_Profe.Items.Add(new ListItem()
                    {
                        Text = Profesor[1].ToString() + " - " + Profesor[2].ToString(),
                        Value = Profesor[0].ToString()
                    });
                    DropDownListPositivoProfe_Profesor.Items.Add(new ListItem()
                    {
                        Text = Profesor[1].ToString() + " - " + Profesor[2].ToString(),
                        Value = Profesor[0].ToString()
                    });
                }

                DropDownListPositivoPRO_Profe.Items.Clear();
                SqlDataReader PositivoPRO = obj.ObtenerTablas("PositivoProfe");
                while (PositivoPRO.Read())
                {
                    DropDownListPositivoPRO_Profe.Items.Add(new ListItem()
                    {
                        Text = PositivoPRO[1].ToString() + " - " + PositivoPRO[2].ToString(),
                        Value = PositivoPRO[0].ToString()
                    });
                }

                DropDownListPositivoPRO_Medico.Items.Clear();
                DropDownListSeguimientoAL_Medico.Items.Clear();
                SqlDataReader Medico = obj.ObtenerTablas("Medico");
                while (Medico.Read())
                {
                    DropDownListPositivoPRO_Medico.Items.Add(new ListItem()
                    {
                        Text = Medico[1].ToString() + " - " + Medico[2].ToString(),
                        Value = Medico[0].ToString()
                    });
                    DropDownListSeguimientoAL_Medico.Items.Add(new ListItem()
                    {
                        Text = Medico[1].ToString() + " - " + Medico[2].ToString(),
                        Value = Medico[0].ToString()
                    });
                }

                DropDownListSeguimientoAL_PositivoAlumno.Items.Clear();
                SqlDataReader PositivoAlumno = obj.ObtenerTablas("PositivoAlumno");
                while (PositivoAlumno.Read())
                {
                    DropDownListSeguimientoAL_PositivoAlumno.Items.Add(new ListItem()
                    {
                        Text = PositivoAlumno[1].ToString() + " - " + PositivoAlumno[2].ToString(),
                        Value = PositivoAlumno[0].ToString()
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

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                Label3.Text = obj.creaMedico(new ClassEntidad.Medico()
                {
                    Nombre = TextBoxMedicoNombre.Text,
                    App = TextBoxMedicoApp.Text,
                    Apm = TextBoxMedicoApm.Text,
                    Telefono = TextBoxMedicoTelefono.Text,
                    correo = TextBoxMedicoCorreo.Text,
                    horario = TextBoxMedicoHorario.Text,
                    especialidad = TextBoxMedicoEspecialidad.Text,
                    extra = TextBoxMedicoExtra.Text
                });
            }
            catch (Exception Ex)
            {
                Label3.Text = Ex.Message;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {

                Label4.Text = obj.crearCuatrimestre(new ClassEntidad.Cuatrimestre()
                {
                    Periodo = TextBoxCuatriPeriodo.Text,
                    Anio = Convert.ToInt32(TextBoxCuatriAnio.Text),
                    Inicio = TextBoxCuatriInicio.Text,
                    fin = TextBoxCuatriFin.Text,
                    Extra = TextBoxCuatriExtra.Text,
                });
            }
            catch (Exception Ex)
            {
                Label4.Text = Ex.Message;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {

                Label5.Text = obj.crearGrupoCuatrimestre(new ClassEntidad.GrupoCuatrimestre()
                {
                    F_prod = Convert.ToInt32(DropDownListGrupoCuatrimestre_Programa.SelectedValue),
                    F_Grupo = Convert.ToInt32(DropDownListGrupoCuatrimestre_Grupo.SelectedValue),
                    F_Cuatri = Convert.ToInt32(DropDownListGrupoCuatrimestre_Cuatri.SelectedValue),
                    Turno = TextBoxGrupoCuatrimestre_Turno.Text,
                    Modalidad = TextBoxGrupoCuatrimestre_Modalidad.Text,
                    Extra = TextBoxGrupoCuatrimestre_Extra.Text
                });
            }
            catch (Exception Ex)
            {
                Label5.Text = Ex.Message;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {

                Label6.Text = obj.creaAlumnoGrupo(new ClassEntidad.AlumnoGrupo()
                {
                    f_alumn = Convert.ToInt32(DropDownListAlumnoGrupo_Alumno.SelectedValue),
                    f_grucuat = Convert.ToInt32(DropDownListAlumnoGrupo_GrupoCuatri.SelectedValue),
                    extra = TextBoxAlumnoGrupo_Extra1.Text,
                    extra2 = TextBoxAlumnoGrupo_Extra1.Text
                });
            }
            catch (Exception Ex)
            {
                Label6.Text = Ex.Message;
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {

                Label7.Text = obj.creaProfeGrupo(new ClassEntidad.ProfeGrupo()
                {
                    F_Profe = Convert.ToInt32(DropDownListProfeGrupo_Profe.SelectedValue),
                    F_GruCuat = Convert.ToInt32(DropDownListProfeGrupo_GrupoCuatri.SelectedValue),
                    Extra = TextBoxProfeGrupo_Extra1.Text,
                    Extra2 = TextBoxProfeGrupo_Extra2.Text
                });
            }
            catch (Exception Ex)
            {
                Label7.Text = Ex.Message;
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string ruta = Server.MapPath(Request.ApplicationPath + "imagenes/");
            Response.Write(ruta);
            if (FileUploadPositivoProfe_Imagen.HasFile)
            {
                Label8.Text = obj.creaPositivoProfe(new ClassEntidad.PositivoProfe()
                {
                    FechaConfirmado = TextBoxPositivoProfe_Fecha.Text,
                    Comprobacion = TextBoxPositivoProfe_Comprobacion.Text,
                    Antecedentes = TextBoxPositivoProfe_Antecedentes.Text,
                    Riesgo = TextBoxPositivoProfe_Riesgo.Text,
                    NumContaio = Convert.ToInt32(TextBoxPositivoProfe_NumContagio.Text),
                    Extra = TextBoxPositivoProfe_Extra.Text,
                    F_Profe = Convert.ToInt32(DropDownListPositivoProfe_Profesor.SelectedValue),
                    Imagen = "imagenes/ " + FileUploadPositivoProfe_Imagen.FileName,
                    Discapacidad = Convert.ToInt32(TextBoxPositivoProfe_Discapacidad.Text)
                });
                FileUploadPositivoProfe_Imagen.SaveAs(ruta + FileUploadPositivoProfe_Imagen.FileName);
            }
            else
            {
                Label8.Text = "Carga la ímagen del documento";
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            try
            {

                Label9.Text = obj.creaPositivoAlumno(new ClassEntidad.PositivoAlumno()
                {
                    FechaConfirmado = TextBoxPositivoAlumno_Fecha.Text,
                    Comprobacion = TextBoxPositivoAlumno_Comprobacion.Text,
                    Antecedentes = TextBoxPositivoAlumno_Antecedentes.Text,
                    Riesgo = TextBoxPositivoAlumno_Riesgo.Text,
                    NumContagio = Convert.ToInt32(TextBoxPositivoAlumno_NumContagio.Text),
                    Extra = TextBoxPositivoAlumno_Extra.Text,
                    F_Alumno = Convert.ToInt32(DropDownListPositivoAlumno_Alumno.SelectedValue)
                });
            }
            catch (Exception Ex)
            {
                Label9.Text = Ex.Message;
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            string ruta = Server.MapPath(Request.ApplicationPath + "imagenes/");
            Response.Write(ruta);
            if (FileUploadPositivoPRO_Imagen.HasFile)
            {
                Label8.Text = obj.creaPositivoProfe(new ClassEntidad.SeguimientoPRO()
                {
                    F_positivoProfe = Convert.ToInt32(DropDownListPositivoPRO_Profe.SelectedValue),
                    F_medico = Convert.ToInt32(DropDownListPositivoPRO_Medico.SelectedValue),
                    Fecha = TextBoxPositivoPRO_Fecha.Text,
                    Form_Comunica = TextBoxPositivoPRO_FormComunica.Text,
                    Reporte = TextBoxPositivoPRO_Reporte.Text,
                    Entrevista = TextBoxPositivoPRO_Entrevista.Text,
                    Extra = TextBoxPositivoPRO_Extra.Text,
                    Imagen = "imagenes/ " + FileUploadPositivoPRO_Imagen.FileName,
                });
                FileUploadPositivoPRO_Imagen.SaveAs(ruta + FileUploadPositivoPRO_Imagen.FileName);
            }
            else
            {
                Label8.Text = "Carga la ímagen del documento";
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            try
            {

                Label11.Text = obj.creaSeguimientoAl(new ClassEntidad.SeguimientoAL()
                {
                    F_PositivoAL = Convert.ToInt32(DropDownListSeguimientoAL_PositivoAlumno.SelectedValue),
                    F_medico = Convert.ToInt32(DropDownListSeguimientoAL_Medico.SelectedValue),
                    Fecha = TextBoxListSeguimientoAL_Fecha.Text,
                    Form_Comunica = TextBoxListSeguimientoAL_FormComunica.Text,
                    Reporte = TextBoxListSeguimientoAL_Reporte.Text,
                    Entrevista = TextBoxListSeguimientoAL_Entrevista.Text,
                    Extra = TextBoxListSeguimientoAL_Extra.Text
                });;
            }
            catch (Exception Ex)
            {
                Label11.Text = Ex.Message;
            }
        }
    }
}