<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ActualizarMaterial.aspx.cs" Inherits="ActualizarMaterial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Actualizar Material</h3>
            <div>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Tipo de Material:" /></div>
                <div>
                    <asp:DropDownList runat="server" ID="ddlTipoMaterial">
                        <asp:ListItem Text="Libro"></asp:ListItem>
                        <asp:ListItem Text="Revista"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div>
                    <div>
                        <asp:Label ID="Label2" runat="server" Text="Codigo:" /></div>
                    <div>
                        <asp:TextBox runat="server" ID="txtCodigo"></asp:TextBox></div>
                </div>
                <div>
                    <div>
                        <asp:Label ID="Label3" runat="server" Text="Autor:" /></div>
                    <div>
                        <asp:TextBox runat="server" ID="txtAutor"></asp:TextBox></div>
                </div>
                <div>
                    <div>
                        <asp:Label ID="Label4" runat="server" Text="Titulo:" /></div>
                    <div>
                        <asp:TextBox runat="server" ID="txtTitulo"></asp:TextBox></div>
                </div>
                <div>
                    <div>
                        <asp:Label ID="Label5" runat="server" Text="Año:" /></div>
                    <div>
                        <asp:TextBox runat="server" ID="txtAnio"></asp:TextBox></div>
                </div>
                <div>
                    <div>
                        <asp:Label ID="Label6" runat="server" Text="Estado:" /></div>
                    <div>
                        <asp:TextBox runat="server" ID="txtEstado"></asp:TextBox></div>
                </div>
                <div>
                    <div>
                        <asp:Button runat="server" ID="btnModificar" Text="Modificar" OnClientClick="alert('Se modificaron los datos con éxito'); window.close();"/>
                        <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" OnClientClick="window.close();"/>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
