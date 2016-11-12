<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfBUsuario.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfBUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 345px;
        }
        .auto-style2 {
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Mantenimiento de Usuario"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ImageButton ID="btnNewUsu" runat="server" Height="32px" ImageUrl="~/images/new.png" ToolTip="Nuevo" OnClick="btnNewUsu_Click" />
                    <asp:ImageButton ID="btnBusUsu" runat="server" Height="32px" ImageUrl="~/images/search.png" ToolTip="Buscar" OnClick="btnBusUsu_Click" />
                    <asp:ImageButton ID="btnSalir" runat="server" Height="32px" ImageUrl="~/images/cancel.png" ToolTip="Salir" OnClick="btnSalir_Click1" />
                </td>      
            </tr>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                              <fieldset>
                                  <legend>Buscar Por:</legend>
                                  <table>
                                    <tr>
                                        <td class="auto-style2">
                                            <asp:Label ID="Label2" runat="server" Text="Código Usuario:"></asp:Label>
                                        </td>
                                        <td class="auto-style1">
                                            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                                        </td>
                                        
                                    </tr>
                                    <tr>
                                        <td class="auto-style2">
                                            <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
                                        </td>
                                        <td class="auto-style1">
                                            <asp:TextBox ID="txtDescripcion" runat="server" Width="313px"></asp:TextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:GridView ID="grdUsuario" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                <Columns>
                                                    <asp:ButtonField ButtonType="Image" CommandName="btnEliminar" ImageUrl="~/images/edit.png" Text="Editar" />
                                                    <asp:ButtonField ButtonType="Image" ImageUrl="~/images/delete.png" Text="Eliminar" />
                                                    <asp:ButtonField ButtonType="Image" ImageUrl="~/images/view.png" Text="Ver" />
                                                    <asp:BoundField HeaderText="Usuario" DataField="CodUsuario" />
                                                    <asp:BoundField HeaderText="Contraseña" DataField="Password" />
                                                    <asp:BoundField HeaderText="Perfil" DataField="Perfil" />
                                                    <asp:BoundField HeaderText="Nombre Completo" DataField="NombreCompleto" />
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
                                </fieldset>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
