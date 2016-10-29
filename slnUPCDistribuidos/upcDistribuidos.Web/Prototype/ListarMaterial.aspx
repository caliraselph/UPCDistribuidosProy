<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarMaterial.aspx.cs" Inherits="ListarMaterial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Lista de Materiales</h3>
            <div>
                <div><asp:Button runat="server" ID="btnNuevo" Text="Nuevo" OnClientClick="window.open('RegistrarMaterial.aspx', 'newwindow', 'width=500, height=450'); return false;"/></div>
                <table>
                    <thead>
                        <tr>
                            <th style="border: 1px solid">Tipo Material</th>
                            <th style="border: 1px solid">Codigo</th>
                            <th style="border: 1px solid">Autor</th>
                            <th style="border: 1px solid">Titulo </th>
                            <th style="border: 1px solid">Año </th>
                            <th style="border: 1px solid">Estado </th>
                            <th style="border: 1px solid">Acciones </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td style="border: 1px solid">Libro</td>
                            <td style="border: 1px solid">M0001</td>
                            <td style="border: 1px solid">Ricardo Palma</td>
                            <td style="border: 1px solid">Tradiciones Peruanas</td>
                            <td style="border: 1px solid">1876 </td>
                            <td style="border: 1px solid">Perfectas Condiciones </td>
                            <td style="border: 1px solid">
                                <a href="#" onclick="window.open('ActualizarMaterial.aspx', 'newwindow', 'width=500, height=450'); return false;">Editar</a></td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid">Libro</td>
                            <td style="border: 1px solid">M0002</td>
                            <td style="border: 1px solid">Cesar Vallejo</td>
                            <td style="border: 1px solid">Los Heraldos Negros</td>
                            <td style="border: 1px solid">1740 </td>
                            <td style="border: 1px solid">Deteriorado </td>
                            <td style="border: 1px solid">
                                <a href="#" onclick="window.open('ActualizarMaterial.aspx', 'newwindow', 'width=500, height=450'); return false;">Editar</a></td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid">Revista</td>
                            <td style="border: 1px solid">M0003</td>
                            <td style="border: 1px solid">Stan Lee</td>
                            <td style="border: 1px solid">Civil War</td>
                            <td style="border: 1px solid">2012 </td>
                            <td style="border: 1px solid">Deteriorado </td>
                            <td style="border: 1px solid">
                                <a href="#" onclick="window.open('ActualizarMaterial.aspx', 'newwindow', 'width=500, height=450'); return false;">Editar</a></td>
                        </tr>
                        <tr>
                            <td style="border: 1px solid">Revista</td>
                            <td style="border: 1px solid">M0004</td>
                            <td style="border: 1px solid">Akira Toriyama</td>
                            <td style="border: 1px solid">Dragon Ball #17</td>
                            <td style="border: 1px solid">1993 </td>
                            <td style="border: 1px solid">Deteriorado </td>
                            <td style="border: 1px solid">
                                <a href="#" onclick="window.open('ActualizarMaterial.aspx', 'newwindow', 'width=500, height=450'); return false;">Editar</a></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
