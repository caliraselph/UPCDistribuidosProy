<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFiltroMaterial.aspx.cs" Inherits="upcDistribuidos.Web.frmFiltroMaterial" %>

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
            height: 23px;
        }
        .auto-style3 {
            text-decoration: underline;
        }
        .auto-style4 {
            width: 212px;
        }
        .auto-style5 {
            height: 23px;
            width: 212px;
        }
        .auto-style8 {
            width: 55px;
        }
        .auto-style9 {
            height: 23px;
            width: 55px;
        }
        .auto-style10 {
            width: 43px;
        }
        .auto-style11 {
            height: 23px;
            width: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"><strong>
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="FILTRO MATERIAL"></asp:Label>
                    </strong></td>
                <td class="auto-style9"></td>
                <td class="auto-style11"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Tipo Material:"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="21px" Width="112px">
                        <asp:ListItem>Revista</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="Label3" runat="server" Text="Titulo:"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/search.png" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="604px">
                        <Columns>
                            <asp:CommandField ShowCancelButton="False" ShowSelectButton="True">
                            <HeaderStyle BackColor="#33CCFF" />
                            </asp:CommandField>
                            <asp:BoundField DataField="TipoMaterial" DataFormatString="TipoMaterial" HeaderText="TipoMaterial">
                            <HeaderStyle BackColor="#33CCFF" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Codigo" DataFormatString="Codigo" HeaderText="Codigo">
                            <HeaderStyle BackColor="#33CCFF" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Autor" DataFormatString="Autor" HeaderText="Autor">
                            <HeaderStyle BackColor="#33CCFF" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Titulo" DataFormatString="Titulo" HeaderText="Titulo">
                            <HeaderStyle BackColor="#33CCFF" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Anio" DataFormatString="Anio" HeaderText="Año">
                            <HeaderStyle BackColor="#33CCFF" />
                            </asp:BoundField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
