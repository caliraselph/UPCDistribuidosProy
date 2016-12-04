<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfTPersona.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfTPersona" %>

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
                        <asp:Label ID="Label1" runat="server" Text="Persona"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="btnGrabar" runat="server" Height="32px" ImageUrl="~/images/save.png" ToolTip="Grabar" OnClick="btnGrabar_Click" />
                        &nbsp;<asp:ImageButton ID="btnSalir" runat="server" Height="32px" ImageUrl="~/images/cancel.png" ToolTip="Salir" OnClick="btnNew2_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <fieldset>
                            
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style2">
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label2" runat="server" Text="Código:"></asp:Label>
                                    </td>
                                    <td style="margin-left: 40px">
                                        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label3" runat="server" Text="Nombre(s):"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtNombre" runat="server" Width="400px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label4" runat="server" Text="Apellido(s):"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtApellido" runat="server" Width="400px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label6" runat="server" Text="Correo:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtCorreo" runat="server" Width="400px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label7" runat="server" Text="Teléfono:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label11" runat="server" Text="Dirección:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label8" runat="server" Text="Nro. Libros:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtNroLibro" runat="server" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label9" runat="server" Text="Deuda(S/.):"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDeuda" runat="server" BackColor="#CCCCCC" ReadOnly="True"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        &nbsp;</td>
                                    <td>&nbsp;</td>
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
