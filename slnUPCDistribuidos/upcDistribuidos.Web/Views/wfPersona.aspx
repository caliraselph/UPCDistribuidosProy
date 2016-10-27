<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfPersona.aspx.cs" Inherits="upcDistribuidos.Web.Views.wfPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
        <div>

            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Trabajar con Personas"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="btnNew" runat="server" Height="32px" ImageUrl="~/images/new.png" ToolTip="Nuevo" />
                        &nbsp;<asp:ImageButton ID="btnNew0" runat="server" Height="32px" ImageUrl="~/images/delete.png" ToolTip="Eliminar" />
                        &nbsp;<asp:ImageButton ID="btnNew1" runat="server" Height="32px" ImageUrl="~/images/search.png" ToolTip="Buscar" />
                        &nbsp;<asp:ImageButton ID="btnNew2" runat="server" Height="32px" ImageUrl="~/images/cancel.png" ToolTip="Salir" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <fieldset>
                            <legend><b>Buscar por:</b></legend>
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label2" runat="server" Text="Código:"></asp:Label>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label3" runat="server" Text="Nombres y Apellidos:"></asp:Label>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                            </table>
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField HeaderText="Código" />
                                <asp:BoundField HeaderText="Apellido(s)" />
                                <asp:BoundField HeaderText="Nombre(s)" />
                                <asp:BoundField HeaderText="Nro. Libros" />
                                <asp:BoundField HeaderText="Deuda" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
