<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="WebApplication1.Crear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
</head>
<body>
    <nav class="navbar navbar-expand-lg bg-light">
        <div class="container-fluid">
            <a class="navbar-brand" href="Consultas.aspx">Producto 2</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="Obtener.aspx">Obtener</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Crear.aspx">Crear</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Editar.aspx">Editar</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Eliminar.aspx">Eliminar</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <form id="form1" runat="server">
        <div class="container">
            <div class="mb-5">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear Alumno</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon1">Matricula</span>
                    <asp:TextBox ID="TextBoxAlumnoMatricula" class="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon2">Nombre</span>
                    <asp:TextBox ID="TextBoxAlumnoNombre" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon3">Apellido Paterno</span>
                    <asp:TextBox ID="TextBoxAlumnopaterno" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon4">Apellido Materno</span>
                    <asp:TextBox ID="TextBoxAlumnomaterno" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon5">Genero</span>
                    <asp:TextBox ID="TextBoxAlumnogenero" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon6">Correo</span>
                    <asp:TextBox ID="TextBoxAlumnocorreo" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon7">Celular</span>
                    <asp:TextBox ID="TextBoxAlumnocelular" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:DropDownList ID="DropDownLisCivil" class="form-control" runat="server"></asp:DropDownList>
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Crear Alumno" OnClick="Button1_Click" />
            </div>

            <div class="mb-5">
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear Profesor</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon8">Registro</span>
                    <asp:TextBox ID="TextBoxProfesorRegistro" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon9">Nombre</span>
                    <asp:TextBox ID="TextBoxProfesorNombre" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon10">Apellido Paterno</span>
                    <asp:TextBox ID="TextBoxProfesorPaterno" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon11">Apellido Materno</span>
                    <asp:TextBox ID="TextBoxProfesorMaterno" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon12">Genero</span>
                    <asp:TextBox ID="TextBoxProfesorGenero" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon13">Correo</span>
                    <asp:TextBox ID="TextBoxProfesorCorreo" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon14">Celular</span>
                    <asp:TextBox ID="TextBoxProfesorCelular" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon15">Categoria</span>
                    <asp:TextBox ID="TextBoxProfesorCategoria" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:DropDownList ID="DropDownListProfeCivil" class="form-control" runat="server"></asp:DropDownList>
                <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" Text="Crear Profesor" OnClick="Button2_Click" />
            </div>
            <div class="mb-5">
                 <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear Medico</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon17">Nombre</span>
                    <asp:TextBox ID="TextBoxMedicoNombre" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon18">Apellido Paterno</span>
                    <asp:TextBox ID="TextBoxMedicoApp" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon19">Apellido Materno</span>
                    <asp:TextBox ID="TextBoxMedicoApm" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon20">Teléfono</span>
                    <asp:TextBox ID="TextBoxMedicoTelefono" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon21">Correo</span>
                    <asp:TextBox ID="TextBoxMedicoCorreo" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon22">Horario</span>
                    <asp:TextBox ID="TextBoxMedicoHorario" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon23">Especialidad</span>
                    <asp:TextBox ID="TextBoxMedicoEspecialidad" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon24">Extra</span>
                    <asp:TextBox ID="TextBoxMedicoExtra" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button3" runat="server" CssClass="btn btn-primary" Text="Crear Médico" OnClick="Button3_Click" />
            </div>
            <div class="mb-5">
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear Cuatrimestre</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon25">Periodo</span>
                    <asp:TextBox ID="TextBoxCuatriPeriodo" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon26">Año</span>
                    <asp:TextBox ID="TextBoxCuatriAnio" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon27">Inicio</span>
                    <asp:TextBox ID="TextBoxCuatriInicio" type="Date" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon28">Fin</span>
                    <asp:TextBox ID="TextBoxCuatriFin" type="Date" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon29">Extra</span>
                    <asp:TextBox ID="TextBoxCuatriExtra" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button4" runat="server" CssClass="btn btn-primary" Text="Crear Cuatrimestre" OnClick="Button4_Click" />
            </div>
            <div class="mb-5">
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear GrupoCuatrimestre</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon30">Programa Educativo</span>
                    <asp:DropDownList ID="DropDownListGrupoCuatrimestre_Programa" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon31">Grupo</span>
                    <asp:DropDownList ID="DropDownListGrupoCuatrimestre_Grupo" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon32">Cuatrimestre</span>
                    <asp:DropDownList ID="DropDownListGrupoCuatrimestre_Cuatri" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon33">Turno</span>
                    <asp:TextBox ID="TextBoxGrupoCuatrimestre_Turno" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon34">Modalidad</span>
                    <asp:TextBox ID="TextBoxGrupoCuatrimestre_Modalidad" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon35">Extra</span>
                    <asp:TextBox ID="TextBoxGrupoCuatrimestre_Extra" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button5" runat="server" CssClass="btn btn-primary" Text="Crear GrupoCuatrimestre" OnClick="Button5_Click" />
            </div>
            <div class="mb-5">
                <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear AlumnoGrupo</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon36">Alumno</span>
                    <asp:DropDownList ID="DropDownListAlumnoGrupo_Alumno" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon37">GrupoCuatri</span>
                    <asp:DropDownList ID="DropDownListAlumnoGrupo_GrupoCuatri" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon38">Extra 1</span>
                    <asp:TextBox ID="TextBoxAlumnoGrupo_Extra1" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon39">Extra 2</span>
                    <asp:TextBox ID="TextBoxAlumnoGrupo_Extra2" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button6" runat="server" CssClass="btn btn-primary" Text="Crear GrupoAlumno" OnClick="Button6_Click" />
            </div>
            <div class="mb-5">
                <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear ProfeGrupo</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon40">Profesor</span>
                    <asp:DropDownList ID="DropDownListProfeGrupo_Profe" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon41">GrupoCuatri</span>
                    <asp:DropDownList ID="DropDownListProfeGrupo_GrupoCuatri" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon42">Extra 1</span>
                    <asp:TextBox ID="TextBoxProfeGrupo_Extra1" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon43">Extra 2</span>
                    <asp:TextBox ID="TextBoxProfeGrupo_Extra2" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button7" runat="server" CssClass="btn btn-primary" Text="Crear ProfeGrupo" OnClick="Button7_Click" />
            </div>
            <div class="mb-5">
                <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear PositivoProfe</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon44">Fecha Confirmado</span>
                    <asp:TextBox ID="TextBoxPositivoProfe_Fecha" type="Date" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon45">Comprobación</span>
                    <asp:TextBox ID="TextBoxPositivoProfe_Comprobacion" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon46">Antecedentes</span>
                    <asp:TextBox ID="TextBoxPositivoProfe_Antecedentes" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon47">Riesgo</span>
                    <asp:TextBox ID="TextBoxPositivoProfe_Riesgo" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon48">NumContagio</span>
                    <asp:TextBox ID="TextBoxPositivoProfe_NumContagio" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon49">Extra</span>
                    <asp:TextBox ID="TextBoxPositivoProfe_Extra" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon50">Profesor</span>
                    <asp:DropDownList ID="DropDownListPositivoProfe_Profesor" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon51">Comprobante Covid-19</span>
                    <asp:FileUpload ID="FileUploadPositivoProfe_Imagen" runat="server" />
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon52">Discapacidad</span>
                    <asp:TextBox ID="TextBoxPositivoProfe_Discapacidad" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button8" runat="server" CssClass="btn btn-primary" Text="Crear PositivoProfe" OnClick="Button8_Click" />
            </div>
            <div class="mb-5">
                <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear PositivoAlumno</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon53">Fecha Confirmado</span>
                    <asp:TextBox ID="TextBoxPositivoAlumno_Fecha" type="Date" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon54">Comprobación</span>
                    <asp:TextBox ID="TextBoxPositivoAlumno_Comprobacion" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon55">Antecedentes</span>
                    <asp:TextBox ID="TextBoxPositivoAlumno_Antecedentes" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon56">Riesgo</span>
                    <asp:TextBox ID="TextBoxPositivoAlumno_Riesgo" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon57">NumContagio</span>
                    <asp:TextBox ID="TextBoxPositivoAlumno_NumContagio" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon58">Extra</span>
                    <asp:TextBox ID="TextBoxPositivoAlumno_Extra" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon59">Alumno</span>
                    <asp:DropDownList ID="DropDownListPositivoAlumno_Alumno" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <asp:Button ID="Button9" runat="server" CssClass="btn btn-primary" Text="Crear PositivoAlumno" OnClick="Button9_Click" />
            </div>
            <div class="mb-5">
                <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear SeguimientoPRO</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon60">Profe Positivo</span>
                    <asp:DropDownList ID="DropDownListPositivoPRO_Profe" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon61">Médico</span>
                    <asp:DropDownList ID="DropDownListPositivoPRO_Medico" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon62">Fecha</span>
                    <asp:TextBox ID="TextBoxPositivoPRO_Fecha" type="Date" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon63">Form Comunica</span>
                    <asp:TextBox ID="TextBoxPositivoPRO_FormComunica" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon64">Reporte</span>
                    <asp:TextBox ID="TextBoxPositivoPRO_Reporte" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon65">Entrevista</span>
                    <asp:TextBox ID="TextBoxPositivoPRO_Entrevista" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon66">Extra</span>
                    <asp:TextBox ID="TextBoxPositivoPRO_Extra" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon67">Imagen</span>
                    <asp:FileUpload ID="FileUploadPositivoPRO_Imagen" runat="server" />
                </div>
                <asp:Button ID="Button10" runat="server" CssClass="btn btn-primary" Text="Crear PositivoPRO" OnClick="Button10_Click" />
            </div>
            <div class="mb-5">
                <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear SeguimientoAL</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon68">Positivo Alumno</span>
                    <asp:DropDownList ID="DropDownListSeguimientoAL_PositivoAlumno" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon69">Médico</span>
                    <asp:DropDownList ID="DropDownListSeguimientoAL_Medico" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon70">Fecha</span>
                    <asp:TextBox ID="TextBoxListSeguimientoAL_Fecha" type="Date" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon71">Form Comunica</span>
                    <asp:TextBox ID="TextBoxListSeguimientoAL_FormComunica" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon72">Reporte</span>
                    <asp:TextBox ID="TextBoxListSeguimientoAL_Reporte" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon73">Entrevista</span>
                    <asp:TextBox ID="TextBoxListSeguimientoAL_Entrevista" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon74">Extra</span>
                    <asp:TextBox ID="TextBoxListSeguimientoAL_Extra" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button11" runat="server" CssClass="btn btn-primary" Text="Crear SeguimientoAL" OnClick="Button11_Click" />
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</body>
</html>
