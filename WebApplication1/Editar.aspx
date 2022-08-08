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
                    <asp:TextBox ID="TextBoxCuatrimestreInicio" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon4">Fin</span>
                    <asp:TextBox ID="TextBoxCuatrimestreFin" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="input-group mb-3 mt-3">
                    <span class="input-group-text" id="basic-addon5">Extra</span>
                    <asp:TextBox ID="TextBoxCuatrimestreExtra" class="form-control" runat="server"></asp:TextBox>
                </div>
                <asp:Button ID="btnCuatrimestre" runat="server" CssClass="btn btn-primary" Text="Actualizar Cuatrimestre" />
            </div>
        </div>
    </form>
</body>
</html>
