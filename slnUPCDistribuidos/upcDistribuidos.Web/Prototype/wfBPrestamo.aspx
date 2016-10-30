<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfBPrestamo.aspx.cs" Inherits="WebApplication4.wfBPrestamo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style6 {
            height: 23px;
        }
        .auto-style12 {
            width: 17px;
        }
        .auto-style13 {
            width: 77px;
        }
        .auto-style14 {
            width: 214px;
        }
        .auto-style15 {
            width: 77px;
            height: 23px;
        }
        .auto-style16 {
            width: 214px;
            height: 23px;
        }
        .auto-style17 {
            width: 17px;
            height: 23px;
        }
        .auto-style18 {
            width: 226px;
        }
        .auto-style19 {
            height: 23px;
            width: 226px;
        }
        .auto-style20 {
            height: 23px;
            width: 226px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <table style="width:100%;">
        <tr>
            <td style="line-height: 10%">&nbsp;</td>
            <td colspan="4" style="line-height: 10%">&nbsp;</td>
            <td class="auto-style13" colspan="2" style="line-height: 10%">&nbsp;</td>
            <td class="auto-style14" style="line-height: normal">&nbsp;</td>
            <td class="auto-style12" style="line-height: normal">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
        </tr>
        <tr>
            <td style="line-height: 10%">&nbsp;</td>
            <td style="line-height: 10%">&nbsp;</td>
            <td aria-orientation="vertical" class="auto-style18" colspan="3" style="line-height: 10%">
                <asp:Label ID="Label1" runat="server" BackColor="#00CC00" CssClass="separator" Font-Bold="True" Font-Italic="True" Font-Names="Arial Black" Text="BUSCAR PRESTAMOS"></asp:Label>
            </td>
            <td class="auto-style13" colspan="2" style="line-height: 10%">&nbsp;</td>
            <td class="auto-style14" style="line-height: normal">&nbsp;</td>
            <td class="auto-style12" style="line-height: normal">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
        </tr>
        <tr>
            <td style="line-height: 10%">&nbsp;</td>
            <td style="line-height: 10%">
                <asp:ImageButton ID="btnBuscar" runat="server" ImageUrl="~/images/search.png" ToolTip="Buscar" />
                <asp:ImageButton ID="btnNuevo" runat="server" ImageUrl="~/images/new.png" OnClick="btnNuevo_Click" ToolTip="Nuevo" />
                <asp:ImageButton ID="btnEliminar" runat="server" ImageUrl="~/images/delete.png" ToolTip="Eliminar" />
            </td>
            <td class="auto-style18" colspan="3" style="line-height: 10%">&nbsp;</td>
            <td class="auto-style13" colspan="2" style="line-height: 10%">&nbsp;</td>
            <td class="auto-style14" style="line-height: normal">&nbsp;</td>
            <td class="auto-style12" style="line-height: normal">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6" style="line-height: 10%"></td>
            <td class="auto-style6" style="line-height: 10%"></td>
            <td class="auto-style19" colspan="3" style="line-height: 10%"></td>
            <td class="auto-style15" colspan="2" style="line-height: 10%"></td>
            <td class="auto-style16" style="line-height: normal"></td>
            <td class="auto-style17" style="line-height: normal"></td>
            <td class="auto-style6" style="line-height: normal"></td>
            <td class="auto-style6" style="line-height: normal"></td>
        </tr>
        <tr>
            <td class="auto-style6" style="line-height: 10%"></td>
            <td class="auto-style6" style="line-height: 10%">
                <asp:Label ID="Label2" runat="server" Text="Tipo Persona:"></asp:Label>
&nbsp;<asp:DropDownList ID="ddTipoPersona" runat="server" EnableTheming="True" Font-Overline="False" Height="23px" Width="143px">
                    <asp:ListItem>Profesor</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style20" style="line-height: 10%">
                <asp:Label ID="Label3" runat="server" Text="Persona:"></asp:Label>
&nbsp; </td>
            <td class="auto-style19" style="line-height: 10%">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style19" style="line-height: 10%">&nbsp;</td>
            <td class="auto-style15" colspan="2" style="line-height: 10%">&nbsp;</td>
            <td class="auto-style16" style="line-height: normal"></td>
            <td class="auto-style17" style="line-height: normal"></td>
            <td class="auto-style6" style="line-height: normal"></td>
            <td class="auto-style6" style="line-height: normal"></td>
        </tr>
        <tr>
            <td style="line-height: 10%">&nbsp;</td>
            <td colspan="5" rowspan="8" style="line-height: 10%">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="141px" Width="863px">
                    <Columns>
                        <asp:BoundField DataField="Codigo" DataFormatString="Codigo" HeaderText="Codigo">
                        <HeaderStyle BackColor="#33CCFF" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FechaSalida" DataFormatString="FechaSalida" HeaderText="FechaSalida">
                        <HeaderStyle BackColor="#33CCFF" />
                        </asp:BoundField>
                        <asp:BoundField DataField="FechaIngreso" DataFormatString="FechaIngreso" HeaderText="FechaIngreso">
                        <HeaderStyle BackColor="#33CCFF" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TipoPersona" DataFormatString="TipoPersona" HeaderText="TipoPersona">
                        <HeaderStyle BackColor="#33CCFF" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Persona" DataFormatString="Persona" HeaderText="Persona">
                        <HeaderStyle BackColor="#33CCFF" />
                        </asp:BoundField>
                        <asp:HyperLinkField HeaderText="Ver" Text="Ver">
                        <HeaderStyle BackColor="#33CCFF" />
                        </asp:HyperLinkField>
                    </Columns>
                </asp:GridView>
            </td>
            <td colspan="4" rowspan="8" style="line-height: 10%">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
        </tr>
        <tr>
            <td style="line-height: 10%">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
        </tr>
        <tr>
            <td style="line-height: 10%">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
        </tr>
        <tr>
            <td style="line-height: 10%">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6" style="line-height: 10%"></td>
            <td class="auto-style6" style="line-height: normal"></td>
        </tr>
        <tr>
            <td style="line-height: 10%">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
        </tr>
        <tr>
            <td style="line-height: 10%">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
        </tr>
        <tr>
            <td style="line-height: 10%">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
        </tr>
        <tr>
            <td style="line-height: 10%">&nbsp;</td>
            <td colspan="4" style="line-height: 10%">&nbsp;</td>
            <td class="auto-style13" colspan="2" style="line-height: 10%">&nbsp;</td>
            <td class="auto-style14" style="line-height: normal">&nbsp;</td>
            <td class="auto-style12" style="line-height: normal">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
            <td style="line-height: normal">&nbsp;</td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
