<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfLogin.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 157px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
    <legend><b>Iniciar Sesión</b></legend>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtUsuario" runat="server" Width="135px"></asp:TextBox>
            </td>
            <td rowspan="3">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/Cadenas.png"/>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Contraseña:"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password" Width="136px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnAcceder" runat="server" Text="ACCEDER" OnClick="btnAcceder_Click" />
            </td>
            <td class="auto-style1">
                <asp:Button ID="btnSalir" runat="server" Text="SALIR" OnClick="btnSalir_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Prototype/wfRecuperarContrasena.aspx">¿Olvidaste tu contraseña?</asp:HyperLink></td>
        </tr>
    </table>
    </fieldset>
    </div>
    </form>
</body>
</html>
