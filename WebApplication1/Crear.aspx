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
            <a class="navbar-brand" href="#">Producto 2</a>
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
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</body>
</html>
