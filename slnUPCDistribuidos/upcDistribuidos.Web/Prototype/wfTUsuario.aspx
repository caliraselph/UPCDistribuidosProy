<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfTUsuario.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfTUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ImageButton ID="btnNewUsu" runat="server" Height="32px" ImageUrl="~/images/save.png" ToolTip="Grabar" OnClick="btnNewUsu_Click" />
                    <asp:ImageButton ID="btnSalUsu" runat="server" Height="32px" ImageUrl="~/images/cancel.png" ToolTip="Salir" OnClick="btnSalUsu_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset>
                        <table>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label5" runat="server" Text="Perfil:"></asp:Label>
                                </td>
                                <td class="auto-style1">
                                    <asp:DropDownList ID="ddlPerfil" runat="server">
                                        <asp:ListItem Value="USU">Usuario</asp:ListItem>
                                        <asp:ListItem Value="ADM">Administrador</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                             <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label2" runat="server" Text="Usuario:"></asp:Label>
                                    </td>
                                    <td style="margin-left: 40px" class="auto-style1">
                                        <asp:TextBox ID="txtUsuario" runat="server" ></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label10" runat="server" Text="Contraseña:"></asp:Label>
                                    </td>
                                    <td class="auto-style1">
                                        <asp:TextBox ID="txtContrasena" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label3" runat="server" Text="Persona:"></asp:Label>
                                </td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txtCodPersona" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtDescPersona" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="32px" ImageUrl="~/images/view.png" ToolTip="Buscar" OnClick="btnBusPer_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="Label4" runat="server" Text="Estado:"></asp:Label>
                                </td>
                                <td class="auto-style1">
                                    <asp:DropDownList ID="ddlEstado" runat="server">
                                        <asp:ListItem Value="1">Activo</asp:ListItem>
                                        <asp:ListItem Value="0">Inactivo</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Label ID="lblIdPersona" runat="server" Text="-1" Visible="False"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
