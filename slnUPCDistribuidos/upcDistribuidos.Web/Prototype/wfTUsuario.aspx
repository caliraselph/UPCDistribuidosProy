<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfTUsuario.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfTUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 233px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="btnGrabar" runat="server" Height="32px" ImageUrl="~/images/save.png" ToolTip="Grabar" OnClick="btnGrabar_Click" />
                        &nbsp;<asp:ImageButton ID="btnSalir" runat="server" Height="32px" ImageUrl="~/images/cancel.png" ToolTip="Salir" OnClick="btnSalir_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <fieldset>
                            
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label5" runat="server" Text="Perfil:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlTipo" runat="server">
                                            <asp:ListItem>Administrador</asp:ListItem>
                                            <asp:ListItem>Bibliotecario</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label2" runat="server" Text="Usuario:"></asp:Label>
                                    </td>
                                    <td style="margin-left: 40px">
                                        <asp:TextBox ID="txtUsuario" runat="server" ></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label10" runat="server" Text="Contraseña:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtContrasena" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                </table>
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>

    <div>
    
    </div>
    </form>
</body>
</html>
