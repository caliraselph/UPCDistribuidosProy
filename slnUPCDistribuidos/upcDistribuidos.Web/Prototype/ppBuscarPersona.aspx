<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ppBuscarPersona.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.ppBuscarPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
  <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Buscar Persona"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;<asp:ImageButton ID="btnBuscar" runat="server" Height="32px" ImageUrl="~/images/search.png" ToolTip="Buscar" OnClick="btnBuscar_Click" />
                        &nbsp;</td>
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
                                    <td class="auto-style3">&nbsp;</td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td class="auto-style2">
                                        <asp:Label ID="Label3" runat="server" Text="Nombres y Apellidos:"></asp:Label>
                                    </td>
                                    <td colspan="4">
                                        <asp:TextBox ID="txtDescripcion" runat="server" Width="417px"></asp:TextBox>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="grdPersona" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="grdPersona_RowCommand" >
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" />
                                    <asp:BoundField HeaderText="Código" DataField="Codigo" />
                                    <asp:BoundField HeaderText="Apellido(s)" DataField="Apellidos" />
                                    <asp:BoundField HeaderText="Nombre(s)" DataField="Nombres" />
                                    <asp:BoundField HeaderText="Nro. Libros" DataField="NroLibros" />
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
