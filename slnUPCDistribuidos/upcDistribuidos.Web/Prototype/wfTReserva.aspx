﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfTReserva.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfTReserva" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../scripts/Estilo1.css" rel="stylesheet" />
</head>
<body>
    <form id="frmTReserva" runat="server">
    <div id="divTitulo">
        <table class="table-style1">
            <tr>
                <td class="td-style5">

                </td>
                <td class="td-style6">

                </td>
                <td class="td-style5">

                </td>
            </tr>
            <tr>
                <td class="td-style5">

                </td>
                <td class="td-style6">
                    <asp:Label ID="Label4" runat="server" Text="Registrar Reserva" CssClass="lbl-style2" Font-Bold="True" Font-Size="Large" Font-Underline=""></asp:Label>
                </td>
                <td class="td-style5">
                </td>
               <td class="td-style5">
                </td>
            </tr>
            <tr>
                <td class="td-style5">

                </td>
                <td class="td-style6">

                </td>
                <td class="td-style5">

                </td>
            </tr>
        </table>  
    </div>
    <div id="divBotones" class="div-style1">
        <table >
            <tr>
                <td class="td-style4">
                    <asp:ImageButton ID="imgGuardarReserva" CssClass="img-style2" runat="server" ImageUrl="~/images/save.png"  />
                </td>
                <td class="td-style4">
                    <asp:ImageButton ID="imgCancelarReserva" CssClass="img-style2" runat="server" ImageUrl="~/images/close.jpg" />
                </td>
                
            </tr>
        </table>
    </div>
    <div id="divBuscarMaterial" class="div-style1">
        <table class="table-style1">
            <tr>
                <td class="td-style5">
                </td>
                <td class="td-style6">
                    <asp:Label ID="lblBusquedaMaterial" runat="server" Text="Buscar Materiales" CssClass="lbl-style2" Font-Bold="True" Font-Size="Large" Font-Underline=""></asp:Label>
                </td>
                <td class="td-style5">
                </td>
            </tr>
        </table>
        <table class="table-style1">
            <tr>
                <td class="td-style1">

                </td>
                <td class="td-style7">
                    <asp:Label ID="Label1" runat="server" Text="Titulo:" CssClass="lbl-style1"></asp:Label>
                </td>
                <td class="td-style8">
                    <asp:TextBox ID="txtFiltroTitulo" runat="server"></asp:TextBox>
                </td>
                <td class="td-style7">
                    <asp:Label ID="Label2" runat="server" Text="Tipo Material:" CssClass="lbl-style1"></asp:Label>
                </td>
                <td class="td-style1">
                    <asp:DropDownList ID="ddlTipoMaterialB" runat="server" CssClass="ddl-style1" ></asp:DropDownList>
                </td>
                <td class="td-style7">
                    <asp:Label ID="Label3" runat="server" Text="Categoria:" CssClass="lbl-style1"></asp:Label>
                </td>
                <td class="td-style1">
                    <asp:DropDownList ID="ddlCategoriaB" runat="server" CssClass="ddl-style1" ></asp:DropDownList>
                </td>
                <td class="td-style9">
                    <asp:ImageButton ID="imgBuscarMaterial" runat="server" ImageUrl="~/images/search.png" />
                </td>
                <td class="td-style1">

                </td>
            </tr>
        </table>
        <table class="table-style1">
            <tr>
                <td class="td-style10">
                </td>
                <td class="td-style11">
                        <asp:GridView ID="dgvBusquedaMaterial" runat="server"  AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="100%" OnRowCommand="dgvBusquedaMaterial_RowCommand" >
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <EmptyDataTemplate>No hay Registros a mostrar</EmptyDataTemplate>
                            <Columns>
                                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True">
                                <ItemStyle Width="20px" />
                                </asp:CommandField>
                                <asp:BoundField DataField="Codigo" DataFormatString="Codigo" HeaderText="Código" >
                                <ItemStyle Width="50px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Titulo" DataFormatString="Titulo" HeaderText="Titulo" />
                                <asp:BoundField DataField="CodTipMaterial" DataFormatString="CodTipMaterial" HeaderText="CodTipMaterial" Visible="False" />
                                <asp:BoundField DataField="TipoMaterial" DataFormatString="TipoMaterial" HeaderText="Tipo Material" />
                                <asp:BoundField DataField="CodCategoria" DataFormatString="CodCategoria" HeaderText="CodCategoria" Visible="False" />
                                <asp:BoundField DataField="Categoria" DataFormatString="Categoria" HeaderText="Categoria" />
                                <asp:BoundField DataField="Anio" DataFormatString="Anio" HeaderText="Año" >
                                <ItemStyle Width="20px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Autor" DataFormatString="Autor" HeaderText="Autor" />
                            </Columns>

                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White"  />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="Gray" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                </td>
                <td class="td-style10">

                </td>
            </tr>
        </table>
    </div>
    <div id="divTCampos" class="div-style1">
        <table class="table-style1">
            <tr>
                <td class="td-style5">

                </td>
                <td class="td-style6">
                    <asp:Label ID="lblTituloDatos" runat="server" Text="Datos" CssClass="lbl-style2" Font-Bold="True" Font-Size="Large" Font-Underline=""></asp:Label>
                </td>
                <td class="td-style5">
                </td>
               <td class="td-style5">
                </td>
            </tr>
        </table>  
        <table class="table-style1">
            <tr>
                <td class="td-style12">
                </td>
                <td class="td-style13">
                    <div class="div-style1">
                       <table class="table-style1"> 
                        <tr>
                            <td class="td-style5">
                                <asp:Label ID="Label5" runat="server" Text="Codigo:"></asp:Label>
                            </td>
                            <td class="td-style5">
                                <asp:TextBox ID="txtCodigoR" runat="server"></asp:TextBox>
                            </td>
                            <td class="td-style5"></td>
                            <td class="td-style5"></td>
                        </tr>
                        <tr>
                            <td class="td-style5">
                                <asp:Label ID="Label6" runat="server" Text="Fecha Reserva:"></asp:Label>
                            </td>
                            <td class="td-style5">
                                <asp:TextBox ID="txtFechaReservar" runat="server"></asp:TextBox>
                            </td>
                            <td class="td-style5">
                                <asp:Label ID="Label7" runat="server" Text="Fecha Prestamo:"></asp:Label>
                            </td>
                            <td class="td-style5">
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="td-style5">
                                <asp:Label ID="Label8" runat="server" Text="Fecha Retorno:"></asp:Label>
                            </td>
                            <td class="td-style5">
                                <asp:TextBox ID="txtFechaRetornoR" runat="server"></asp:TextBox>
                            </td>
                            <td class="td-style5">
                                <asp:Label ID="Label9" runat="server" Text="Fecha Devolucion:"></asp:Label>
                            </td>
                            <td class="td-style5">
                                <asp:TextBox ID="txtFechaDevolucionR" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="td-style5">
                                <asp:Label ID="Label10" runat="server" Text="Persona:"></asp:Label>
                            </td>
                            <td class="td-style5">
                                <asp:TextBox ID="txtPersonaR" runat="server"></asp:TextBox>
                                <asp:ImageButton ID="imbBuscarPersonaR" runat="server" ImageUrl="~/images/search.png" />
                            </td>
                            <td class="td-style5">
                                <asp:Label ID="Label11" runat="server" Text="Estado:"></asp:Label>
                            </td>
                            <td class="td-style5">
                                <asp:TextBox ID="txtEstadoR" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    </div>
                </td>
                <td class="td-style12">

                </td>
            </tr>
            <tr>
                <td class="td-style12">
                </td>
                <td class="td-style13">
                    <div class="div-style1">
                            <asp:GridView ID="dgvDetalleR" runat="server"  AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="100%" OnRowCommand="dgvDetalleR_RowCommand" >
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <EmptyDataTemplate>No hay Registros a mostrar</EmptyDataTemplate>
                            <Columns>
                                <asp:BoundField DataField="Codigo" DataFormatString="Codigo" HeaderText="Código" >
                                <ItemStyle Width="50px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Titulo" DataFormatString="Titulo" HeaderText="Titulo" />
                                <asp:BoundField DataField="CodTipMaterial" DataFormatString="CodTipMaterial" HeaderText="CodTipMaterial" Visible="False" />
                                <asp:BoundField DataField="TipoMaterial" DataFormatString="TipoMaterial" HeaderText="Tipo Material" />
                                <asp:BoundField DataField="CodCategoria" DataFormatString="CodCategoria" HeaderText="CodCategoria" Visible="False" />
                                <asp:BoundField DataField="Categoria" DataFormatString="Categoria" HeaderText="Categoria" />
                                <asp:BoundField DataField="Anio" DataFormatString="Anio" HeaderText="Año" >
                                <ItemStyle Width="20px" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Autor" DataFormatString="Autor" HeaderText="Autor" />
                                <asp:ButtonField ButtonType="Image" CommandName="cmdEliminarDetalle" ImageUrl="~/images/delete.png" Text="Button">
                                <ItemStyle Width="10px" />
                                </asp:ButtonField>
                            </Columns>

                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White"  />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="Gray" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                    </div>
                </td>
                <td class="td-style12">
                </td>
            </tr>
            <tr>
                <td class="td-style12">
                </td>
                <td class="td-style13">
                </td>
                <td class="td-style12">
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
