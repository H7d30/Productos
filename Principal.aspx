<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Guia2.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body> 
    <form id="form1" runat="server">
        <p>
           <h2> Bienvenidos Al Sistema De Productos<h3>  Datos De Productos<p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Agregar.aspx">Ingreso De Productos</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Consultar.aspx">Consulta De Productos</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Eliminar.aspx">Eliminar Productos</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Modificar.aspx">Modificacion De Productos</asp:HyperLink>
        </p>
    </form>
</body>
</html>
