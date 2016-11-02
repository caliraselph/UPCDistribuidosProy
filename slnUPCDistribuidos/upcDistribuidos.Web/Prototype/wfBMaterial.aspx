<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfBMaterial.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfBMaterial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 87px;
        }
        .auto-style2 {
            width: 314px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Mantenimiento de Materiales"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:ImageButton ID="btnNewMat" runat="server" Height="32px" ImageUrl="~/images/new.png" ToolTip="Nuevo" OnClick="btnNewMat_Click" />
                    <asp:ImageButton ID="btnBusMat" runat="server" Height="32px" ImageUrl="~/images/search.png" ToolTip="Buscar" OnClick="btnBusMat_Click" />
                    <asp:ImageButton ID="btnSalir" runat="server" Height="32px" ImageUrl="~/images/cancel.png" ToolTip="Salir" OnClick="btnSalir_Click1" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <fieldset>
                        <legend>Buscar por:</legend>
                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Codigo:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                                </td>
                                <td></td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Titulo:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="Categoria:"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="cboCategoria" runat="server">
                                        <asp:ListItem>Historia</asp:ListItem>
                                        <asp:ListItem>Fisica</asp:ListItem>
                                        <asp:ListItem>Matematica</asp:ListItem>
                                        <asp:ListItem>Literatura</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                
                                <td></td>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Autor:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAutor" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Año:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAnio" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            
                        </table>
                    </fieldset>
                </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="grdMaterial" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" ViewStateMode="Enabled">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:CheckBoxField HeaderText="Sel" DataField="Sel" />
                                <asp:BoundField HeaderText="Código" DataField="Codigo" />
                                <asp:BoundField HeaderText="Titulo" DataField="Titulo" />
                                <asp:BoundField HeaderText="Autor" DataField="Autor" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="hlEditar" runat="server" NavigateUrl="~/Prototype/wfTMaterial.aspx" ImageUrl="~/images/edit.png"
                                            Text="Editar"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="hdEliminar" runat="server" ImageUrl="~/images/delete.png"
                                            Text="Eliminar">
                                            
                                        </asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="hlVer" runat="server" NavigateUrl="~/Prototype/wfTMaterial.aspx" ImageUrl="~/images/view.png"
                                            Text="Ver"></asp:HyperLink>
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
