<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="frmRegistrarPrestamo.aspx.cs" Inherits="upcDistribuidos.Web.frmRegistrarPrestamo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style6 {
            position: static;
            width: 456px;
        }
        .auto-style7 {
            position: static;
            width: 365px;
        }
        .auto-style8 {
            position: static;
            width: 348px;
        }
        .auto-style9 {
            position: static;
            width: 208px;
        }
        .auto-style10 {
            position: static;
            width: 318px;
        }
        .auto-style11 {
            position: static;
            width: 235px;
        }
        .auto-style12 {
            position: static;
            width: 312px;
        }
        .auto-style13 {
            position: static;
            text-align: center;
        }
        .auto-style14 {
            position: static;
        }
        .auto-style15 {
            position: static;
            width: 312px;
            height: 19px;
        }
        .auto-style16 {
            position: static;
            height: 19px;
        }
        .auto-style20 {
            position: static;
            width: 365px;
            height: 19px;
        }
        .auto-style21 {
            position: static;
            width: 294px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td aria-checked="mixed" class="auto-style12">&nbsp;</td>
            <td aria-checked="mixed" class="auto-style9">&nbsp;</td>
            <td aria-checked="mixed" class="auto-style10">&nbsp;</td>
            <td aria-checked="mixed" class="auto-style8">&nbsp;</td>
            <td aria-checked="mixed" class="auto-style13" colspan="6">
                <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="REGISTRAR PRESTAMO"></asp:Label>
            </td>
            <td aria-checked="mixed" class="auto-style21">&nbsp;</td>
            <td aria-checked="mixed" class="auto-style7">&nbsp;</td>
            <td aria-checked="mixed" style="position: static">&nbsp;</td>
            <td aria-checked="mixed" style="position: static">&nbsp;</td>
            <td aria-checked="mixed" style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/save.png" />
            </td>
            <td class="auto-style10">
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/cancel.png" />
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style14" colspan="2">Fecha Salida:</td>
            <td class="auto-style14" colspan="3">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style14" colspan="2">
                <asp:Label ID="Label4" runat="server" Text="Tipo Persona:"></asp:Label>
            </td>
            <td class="auto-style14" colspan="3">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Profesor</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15"></td>
            <td class="auto-style14" colspan="2">
                <asp:Label ID="Label3" runat="server" Text="Fecha Ingreso:"></asp:Label>
            </td>
            <td class="auto-style16" colspan="3">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style16" colspan="2">
                <asp:Label ID="Label5" runat="server" Text=" Persona:"></asp:Label>
            </td>
            <td class="auto-style16" colspan="3">
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>Brayan</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style20"></td>
            <td class="auto-style16"></td>
            <td class="auto-style16"></td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style14" colspan="2">
                <asp:Label ID="Label6" runat="server" Text="Tipo Material:"></asp:Label>
            </td>
            <td class="auto-style11">
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>Revista</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style6">
                <asp:Label ID="Label7" runat="server" Text="Material:"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>HarryPotter</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style7">
                <asp:Button ID="btnAgregar" runat="server" Text="+" />
            </td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style14" colspan="9" rowspan="5">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" Width="635px">
                    <Columns>
                        <asp:BoundField ApplyFormatInEditMode="True" DataField="Material" DataFormatString="Material" HeaderText="Material">
                        <HeaderStyle BackColor="#33CCFF" />
                        </asp:BoundField>
                        <asp:BoundField ApplyFormatInEditMode="True" DataField="Codigo" DataFormatString="Codigo" HeaderText="Codigo">
                        <HeaderStyle BackColor="#33CCFF" />
                        </asp:BoundField>
                        <asp:BoundField ApplyFormatInEditMode="True" DataField="Titulo" DataFormatString="Titulo" HeaderText="Titulo">
                        <HeaderStyle BackColor="#33CCFF" />
                        </asp:BoundField>
                        <asp:BoundField ApplyFormatInEditMode="True" DataField="Autor" DataFormatString="Autor" HeaderText="Autor">
                        <HeaderStyle BackColor="#33CCFF" />
                        </asp:BoundField>
                        <asp:HyperLinkField HeaderText="Eliminar" Text="Eliminar">
                        <HeaderStyle BackColor="#33CCFF" />
                        </asp:HyperLinkField>
                    </Columns>
                </asp:GridView>
            </td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style21">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
            <td style="position: static">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
