<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfTMaterial.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfTMaterial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Material"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ImageButton ID="btnNewMat" runat="server" Height="32px" ImageUrl="~/images/save.png" ToolTip="Grabar" OnClick="btnNewMat_Click"/>
                    <asp:ImageButton ID="btnSalMat" runat="server" Height="32px" ImageUrl="~/images/cancel.png" ToolTip="Salir" OnClick="btnSalMat_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset>
                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Código:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                                </td>
                                <td></td>
                                <td>
                                    <asp:Label ID="Label3" runat="server" Text="Tipo:"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="cboTipo" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label4" runat="server" Text="Titulo:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
                                </td>
                                <td></td>
                                <td>
                                    <asp:Label ID="Label5" runat="server" Text="Autor"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAutor" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label6" runat="server" Text="Editorial"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtEditorial" runat="server"></asp:TextBox>
                                </td>
                                <td></td>
                                <td>
                                    <asp:Label ID="Label12" runat="server" Text="Año"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtAno" runat="server"></asp:TextBox>
                                    <asp:RegularExpressionValidator id="RegularExpressionValidator1"
                                        ControlToValidate="txtAno"
                                        ValidationExpression="\d+"
                                        Display="Static"
                                        EnableClientScript="true"
                                        runat="server"/>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label7" runat="server" Text="Categoria"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="cboCategoria" runat="server">

                                    </asp:DropDownList>
                                </td>
                                <td></td>
                                <td>
                                    <asp:Label ID="Label8" runat="server" Text="Stock"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                                    <asp:RegularExpressionValidator id="RegularExpressionValidator2"
                                        ControlToValidate="txtStock"
                                        ValidationExpression="\d+"
                                        Display="Static"
                                        EnableClientScript="true"
                                        runat="server"/>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Text="Estado"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="cboEstado" runat="server"/>
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
