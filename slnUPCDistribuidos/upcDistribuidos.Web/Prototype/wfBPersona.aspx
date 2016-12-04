<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfBPersona.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfBPersona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
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
                        <asp:ImageButton ID="btnNuevo" runat="server" Height="32px" ImageUrl="~/images/new.png" ToolTip="Nuevo" OnClick="btnNuevo_Click" />
                        &nbsp;&nbsp;<asp:ImageButton ID="btnBuscar" runat="server" Height="32px" ImageUrl="~/images/search.png" ToolTip="Buscar" OnClick="btnBuscar_Click" />
                        &nbsp;<asp:ImageButton ID="btnSalir" runat="server" Height="32px" ImageUrl="~/images/cancel.png" ToolTip="Salir" OnClick="btnSalir_Click" />
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
                        <asp:GridView ID="grdPersona" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="grdCSRPageData_RowCommand">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>

                                <asp:BoundField HeaderText="Código" DataField="Codigo" />
                                <asp:BoundField HeaderText="Apellido(s)" DataField="Apellidos" />
                                <asp:BoundField HeaderText="Nombre(s)" DataField="Nombres" />
                                <asp:BoundField HeaderText="Nro. Libros" DataField="NroLibros" />
                                <asp:BoundField HeaderText="Deuda" DataField="MontoDeuda" />
                                <asp:BoundField HeaderText="Teléfono" DataField="Celular" />
                                <asp:BoundField HeaderText="E-Mail" DataField="Correo" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:ImageButton ID="btnEditar" runat="server" CommandName="Editar" ImageUrl="~/images/edit.png"
                                            ToolTip="Editar" CommandArgument='<%# Eval("Codigo") %>'></asp:ImageButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:ImageButton ID="hdEliminar" runat="server" ImageUrl="~/images/delete.png" NavigateUrl="javascript:Mensaje()"
                                            Text="Eliminar">
                                            
                                        </asp:ImageButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:ImageButton ID="btnVer" runat="server" CommandName="Ver" ImageUrl="~/images/view.png"
                                            ToolTip="Ver" CommandArgument='<%# Eval("Codigo") %>'></asp:ImageButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
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
