<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfTReserva.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfTReserva" %>

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

                    <asp:Label ID="Label4" runat="server" Text="Registrar Prestamo"></asp:Label>

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
        <table >
            <tr>
                <td class="td-style4">
                    <asp:ImageButton ID="imgGuardarReserva" CssClass="img-style2" runat="server" ImageUrl="~/images/save.png"  />
                </td>
                <td class="td-style4">
                    <asp:ImageButton ID="imgCancelarReserva" CssClass="img-style2" runat="server" ImageUrl="~/images/close.jpg" />
                </td>
                <td ></td>
            </tr>
        </table>
    </div>
    <div id="divBuscarMaterial">

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
                <td class="td-style1">
                    <asp:Label ID="Label2" runat="server" Text="Tipo Material:"></asp:Label>
                </td>
                <td class="td-style1">
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                </td>
                <td class="td-style1">
                    <asp:Label ID="Label3" runat="server" Text="Categoria"></asp:Label>
                </td>
                <td class="td-style1">
                    <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                </td>
                <td class="td-style1">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/search.png" />
                </td>
                <td class="td-style1">

                </td>
            </tr>
        </table>
    </div>
    <div id="divTCampos">
        <table class="table-style1">
            <tr>
                <td>

                </td>
                <td>

                </td>
            </tr>
        </table>
    </div>
    <div id="divDetalleMateriales">
        <table class="table-style1">
            <tr>
                <td>

                </td>
                <td>

                </td>
            </tr>
        </table>
    </div>
    </form>

</body>
</html>
