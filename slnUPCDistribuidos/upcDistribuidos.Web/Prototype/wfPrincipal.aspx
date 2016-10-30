<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfPrincipal.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfPrincipal" %>

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
                <asp:Menu ID="Menu1" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" StaticSubMenuIndent="10px">
                    <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <DynamicMenuStyle BackColor="#F7F6F3" />
                    <DynamicSelectedStyle BackColor="#5D7B9D" />
                    <Items>
                        <asp:MenuItem Text="Mantenimiento" Value="mnuMantenimiento">
                            <asp:MenuItem Text="Material" Value="mnuMaterial" NavigateUrl="wfBMaterial.aspx"></asp:MenuItem>
                            <asp:MenuItem Text="Personal" Value="mnuPersonal" NavigateUrl="wfBPersona.aspx"></asp:MenuItem>
                            <asp:MenuItem Text="Usuario" Value="mnuUsuario" NavigateUrl="wfBUsuario.aspx"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="Operación Central" Value="mnuOperacionCentral">
                            <asp:MenuItem Text="Préstamo" Value="mnuPrestamo" NavigateUrl="wfBPrestamo.aspx"></asp:MenuItem>
                          <%--  <asp:MenuItem Text="Devolución" Value="mnuDevolucion"></asp:MenuItem>
                            <asp:MenuItem Text="Stock" Value="mnuStock"></asp:MenuItem>--%>
                        </asp:MenuItem>
                        <asp:MenuItem Text="Seguridad" Value="mnuSeguridad">
                            <asp:MenuItem Text="Cambio de contraseña" Value="mnuCambioContrasena"></asp:MenuItem>
                        </asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <StaticSelectedStyle BackColor="#5D7B9D" />
                </asp:Menu>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
