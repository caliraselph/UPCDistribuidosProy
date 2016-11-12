<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfRecuperarContrasena.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfRecuperarContrasena" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 144px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <fieldset>
                    <legend>Recuperar Contraseña</legend>  
                    <table>
                        <tr>
                            <td colspan="5">
                                <asp:Label ID="Label2" runat="server" Text="Favor de ingresar el correo asociado a su cuenta. Se le enviará un correo con su nueva contraseña."></asp:Label>
                            </td>
                        </tr>
                        <tr>
                <td></td>
                <td></td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="371px"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                </td>
                <td></td>
                <td></td>
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
