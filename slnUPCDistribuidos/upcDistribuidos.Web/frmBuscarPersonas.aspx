<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="frmBuscarPersonas.aspx.cs" Inherits="upcDistribuidos.Web.frmBuscarPersonas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <table class="auto-style2">
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
                            <table class="auto-style2">
                                <tr>
                                    <td class="auto-style3">
                                        <asp:Label ID="Label2" runat="server" Text="Código:"></asp:Label>
                                    </td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style3">
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
</asp:Content>
