<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="WebApplication1.Actualizar" %>

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
                <h3><small class="text-muted ">Actualizar Cuatrimestre</small></h3>
                
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon1">Periodo</span>
                    <asp:DropDownList ID="DropDownListCuatrimestrePeriodo" CssClass="form-control" runat="server" OnSelectedIndexChanged="DropDownListCuatrimestrePeriodo_SelectedIndexChanged"></asp:DropDownList>
                </div>

                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon2">Año</span>
                    <asp:TextBox ID="TextBoxCuatrimestreAnio" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon3">Inicio</span>
                    <asp:TextBox ID="TextBoxCuatrimestreInicio" type="Date" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon4">Fin</span>
                    <asp:TextBox ID="TextBoxCuatrimestreFin" type="Date" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon5">Extra</span>
                    <asp:TextBox ID="TextBoxCuatrimestreExtra" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="btnCuatrimestre" runat="server" CssClass="btn btn-primary" Text="Actualizar Cuatrimestre" OnClick="btnCuatrimestre_Click" />
            </div>

             <div class="mb-5">
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Actualizar Profesor</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon8">Registro</span>
                   <asp:DropDownList ID="DropDownProfesorID" AutoPostBack="true" OnSelectedIndexChanged="DropDownProfesorID_SelectedIndexChanged" runat="server"></asp:DropDownList>
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
                <asp:Button ID="ActualizarPro" runat="server" CssClass="btn btn-primary" Text="Actualizar Profesor" OnClick="ActualizarPro_Click" />
            </div>

             <div class="mb-5">
                <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                <h3><small class="text-muted ">Crear AlumnoGrupo</small></h3>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon36">Alumno</span>
                    <asp:DropDownList ID="DropDownListAlumnoGrupo_Alumno" OnSelectedIndexChanged="DropDownListAlumnoGrupo_Alumno_SelectedIndexChanged" AutoPostBack="true" class="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon37">GrupoCuatri</span>
                    <asp:TextBox ID="TextBoxGrupoCuatri" class="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon38">Extra 1</span>
                    <asp:TextBox ID="TextBoxAlumnoGrupo_Extra1" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon39">Extra 2</span>
                    <asp:TextBox ID="TextBoxAlumnoGrupo_Extra2" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="Button6" runat="server" CssClass="btn btn-primary" Text="Actualizar GrupoAlumno" OnClick="Button6_Click" />
            </div>
        </div>
    </form>
</body>
</html>
