<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="Guia2.Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Agregar Producto<br />
            <br />
            Nombre Del Producto&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtNombre" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            Direccion&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtDireccion" runat="server"></asp:TextBox>
            <br />
            <br />
            Telefono&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtTelefono" runat="server"></asp:TextBox>
            <br />
            <asp:Calendar ID="CalFecCompra" runat="server" style="margin-top: 0px" Width="187px"></asp:Calendar>
            <br />
            <asp:Button ID="BtnAgregar" runat="server" OnClick="BtnAgregar_Click" Text="Agregar" />
            <br />
            <br />
            <br />
&nbsp;<asp:Label ID="LblMensaje" runat="server" Text="LblMensaje"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Principal.aspx">Menu Principal</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
