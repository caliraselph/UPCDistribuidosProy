<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfBPersona.aspx.cs" Inherits="upcDistribuidos.Web.Views.wfPersona" %>

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
            width: 159px;
        }
        .auto-style3 {
            width: 106px;
        }
        .auto-style4 {
            width: 143px;
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
                        <asp:ImageButton ID="btnNew" runat="server" Height="32px" ImageUrl="~/images/new.png" ToolTip="Nuevo" OnClick="btnNew_Click" />
                        &nbsp;<asp:ImageButton ID="btnNew0" runat="server" Height="32px" ImageUrl="~/images/delete.png" ToolTip="Eliminar" />
                        &nbsp;<asp:ImageButton ID="btnNew1" runat="server" Height="32px" ImageUrl="~/images/search.png" ToolTip="Buscar" OnClick="btnNew1_Click" />
                        &nbsp;<asp:ImageButton ID="btnNew2" runat="server" Height="32px" ImageUrl="~/images/cancel.png" ToolTip="Salir" OnClick="btnNew2_Click" />
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
                                    <td class="auto-style4">
                                        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                                    </td>
                                    <td></td>
                                    <td class="auto-style3">
                                        <asp:Label ID="Label4" runat="server" Text="DNI:"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label3" runat="server" Text="Nombres y Apellidos:"></asp:Label>
                                    </td>
                                    <td colspan ="4">
                                        <asp:TextBox ID="txtDescripcion" runat="server" Width="417px"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:CheckBoxField HeaderText="Sel" DataField="Sel" />
                                <asp:BoundField HeaderText="Código" DataField="Codigo" />
                                <asp:BoundField HeaderText="Apellido(s)" DataField="Apellidos" />
                                <asp:BoundField HeaderText="Nombre(s)" DataField="Nombres" />
                                <asp:BoundField HeaderText="Tipo" DataField="Tipo" />
                                <asp:BoundField HeaderText="Nro. Libros" DataField="NroLibros" />
                                <asp:BoundField HeaderText="Deuda" DataField="Deuda" />
                                <asp:BoundField HeaderText="Teléfono" DataField="Telefono" />
                                <asp:BoundField HeaderText="E-Mail" DataField="Email" />
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
