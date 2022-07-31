<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="WebApplication1.WebForm1" %>

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
            <h4>
                <small class="text-muted ">Mostrar todos los Contagiados de un programa educativo en un cuatrimestre especifico</small>
            </h4>
            <asp:DropDownList CssClass="form-select mt-2" ID="DropDownList1" runat="server"></asp:DropDownList>
            <asp:DropDownList CssClass="form-select mt-2" ID="DropDownList2" runat="server"></asp:DropDownList>


            <asp:Button ID="Button1" CssClass="btn btn-primary mt-4" runat="server" Text="Buscar Profesores Contagiados" OnClick="Button1_Click" />
            <asp:Button ID="Button2" CssClass="btn btn-primary mt-4" runat="server" Text="Buscar Alumnos Contagiados" OnClick="Button2_Click" />

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" CssClass="table" runat="server"></asp:GridView>
            <br />
            <br />
            <br />
            <h4>
                <small class="text-muted ">Mostrar los alumnos contagiados de un programa educativo, en un cuatrimestre específico, de un grupo en particular</small>
            </h4>
            <asp:DropDownList CssClass="form-select mt-2" ID="DropDownList3" runat="server"></asp:DropDownList>
            <asp:DropDownList CssClass="form-select mt-2" ID="DropDownList4" runat="server"></asp:DropDownList>
            <asp:DropDownList CssClass="form-select mt-2" ID="DropDownList5" runat="server"></asp:DropDownList>

            <asp:Button ID="Button4" CssClass="btn btn-primary mt-4" runat="server" Text="Buscar Alumnos Contagiados por grupo" OnClick="Button3_Click" />

            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView2" CssClass="table" runat="server"></asp:GridView>

            <br />
            <br />
            <br />
            <h4>
                <small class="text-muted ">Mostrar el seguimiento de un Alumno (por su registro), en un cuatrimestre especifico</small>
            </h4>
            <div class="input-group mb-3">
                <span class="input-group-text" id="basic-addon1">Matricula</span>
                <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
            </div>
            <asp:DropDownList CssClass="form-select mt-2" ID="DropDownList6" runat="server"></asp:DropDownList>

            <asp:Button ID="Button3" CssClass="btn btn-primary mt-4" runat="server" Text="Seguimineto Alumno" OnClick="Button4_Click" />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView3" CssClass="table" runat="server"></asp:GridView>

            <br />
            <br />
            <br />
            <h4>
                <small class="text-muted ">Mostrar los contagios de un profesor, y conocer los detalles de cada contagio (pruebas covid, periodos de incapacidad, etc.)</small>
            </h4>
            <div class="input-group mb-3">
                <span class="input-group-text" id="basic-addon11">Registro Profesor</span>
                <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="Button5" CssClass="btn btn-primary mt-4" runat="server" Text="Profesor Detalles" OnClick="Button5_Click" />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView4" CssClass="table" runat="server"></asp:GridView>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</body>
</html>
