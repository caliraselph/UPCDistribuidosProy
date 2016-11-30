<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfBPrestamo.aspx.cs" Inherits="upcDistribuidos.Web.Prototype.wfBPrestamo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../scripts/Estilo1.css" rel="stylesheet" />
    <title></title>
    

</head>
<body>
    <script type="text/javascript" >
        function MostrarCodigoEmpleado(cod) {
            //debugger;
            document.getElementById("txtPersona").value = cod;
            //window.print(cod);
           // $("#txtPersona").val(cod);
        }

    </script>
    <form id="formBPrestamo" runat="server">
        <div>
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
                    <td class="td-style6" >
                        <asp:Label ID="Label1" runat="server" Text="BUSQUEDA DE PRESTAMO" CssClass="lbl-style2" Font-Bold="True" Font-Size="Large" Font-Underline=""></asp:Label>
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
        <div class="div-style1" >   
            <table>
                <tr>
                    <td class="td-style4">
                        <asp:ImageButton ID="btnNuevoPrestamo" CssClass="img-style2" runat="server" ImageUrl="~/images/new.png" />
                    </td>
                    <td class="td-style4">
                        <asp:ImageButton ID="btnConsultarPrestamo" CssClass="img-style2" runat="server" ImageUrl="~/images/search.png" OnClick="btnConsultarPrestamo_Click" />
                    </td>
                    <td class="td-style4">
                        <asp:ImageButton ID="btnSalirPrestamo" CssClass="img-style2" runat="server" ImageUrl="~/images/close.jpg" />
                    </td>
                    
                </tr>
            </table>
        </div>    
        <div class="div-style1" id="divFiltros">
            <table>
            <tr >   
                <td  class="td-style1" >
                    <asp:Label ID="lblFechaPrestamo" runat="server" Text="Fecha Prestamo:" CssClass="lbl-style1"/>
                </td>
                <td  class="td-style2" >
                    <asp:TextBox ID="txtFechaPresIni" runat="server" CssClass="txt-style1"></asp:TextBox>
                    <asp:ImageButton ID="imgFechaPresIni" runat="server" ImageUrl="~/images/date.jpg" CssClass="img-style1" OnClick="imgFechaPresIni_Click"  />
                </td>
                <td  class="td-style2" >
                    <asp:TextBox ID="txtFechaPresFin" runat="server" CssClass="txt-style1"></asp:TextBox>
                    <asp:ImageButton ID="imgFechaPresFin" runat="server" ImageUrl="~/images/date.jpg" CssClass="img-style1" OnClick="imgFechaPresFin_Click"  />
                </td>
                <td class="td-style3" >
                     <asp:Label ID="lblPersona" runat="server" Text="Persona:" CssClass="lbl-style1"/>
                </td>
                <td class="td-style2" >
                      <asp:TextBox ID="txtPersona" runat="server" CssClass="txt-style1" ></asp:TextBox>
                    <asp:ImageButton ID="imgBuscarPersona" runat="server" ImageUrl="~/images/search.png" CssClass="img-style1" OnClientClick="window.open('./ppBuscarPersona.aspx','Personas', 'top=300,width=650 ,height=350, left=350');" />
                
                </td>
                <td class="td-style3" >
                    <asp:Label ID="lblEstado" runat="server" Text="Estado:" CssClass="lbl-style1"/>
                </td>
                <td class="td-style2" >
                    <asp:DropDownList ID="ddlEstado" runat="server" CssClass="ddl-style1" ></asp:DropDownList>
                </td>
            </tr>
            <tr >   
                <td  class="td-style1" >
                </td>
                <td  class="td-style2" >
                    <asp:Calendar Visible="false" ID="calFecPresIni" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="129px" Width="140px" OnSelectionChanged="calFecPresIni_SelectionChanged" >
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                </td>
                <td  class="td-style2" >
                    <asp:Calendar ID="calFecPresFin" Visible="false" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="129px" Width="140px" OnSelectionChanged="calFecPresFin_SelectionChanged" >
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                </td>
                <td class="td-style3" >
                </td>
                <td class="td-style2" >
                </td>
                <td class="td-style3" >
                </td>
                <td class="td-style2" >
                </td>
            </tr>
            <tr >   
                <td  class="td-style1" >
                    <asp:Label ID="Label2" runat="server" Text="Fecha Devolucion:" CssClass="lbl-style1"/>
                </td>
                <td  class="td-style2" >
                    <asp:TextBox ID="txtFechaIniDev" runat="server" CssClass="txt-style1"></asp:TextBox>
                    <asp:ImageButton ID="imgFechaIniDev" runat="server" ImageUrl="~/images/date.jpg" CssClass="img-style1" OnClick="imgFechaIniDev_Click"  />
                </td>
                <td  class="td-style2" >
                    <asp:TextBox ID="txtFechaFinDev" runat="server" CssClass="txt-style1"></asp:TextBox>
                    <asp:ImageButton ID="imgFechaFinDev" runat="server" ImageUrl="~/images/date.jpg" CssClass="img-style1" OnClick="imgFechaFinDev_Click" />
                </td>
                <td class="td-style3" >
                     <asp:Label ID="Label3" runat="server" Text="Codigo:" CssClass="lbl-style1"/>
                </td>
                <td class="td-style2" >
                      <asp:TextBox ID="txtCodigo" runat="server" CssClass="txt-style1" ></asp:TextBox>
                
                </td>
                <td class="td-style3" >
                    &nbsp;</td>
                <td class="td-style2" >
                    &nbsp;</td>
            </tr>
            <tr >   
                <td  class="td-style1" >
                </td>
                <td  class="td-style2" >
                    <asp:Calendar Visible="false" ID="calFechaIniDev" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="129px" Width="140px" OnSelectionChanged="calFechaIniDev_SelectionChanged" >
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                </td>
                <td  class="td-style2" >
                    <asp:Calendar ID="calFechaFinDev" Visible="false" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="129px" Width="140px" OnSelectionChanged="calFechaFinDev_SelectionChanged" >
                        <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                        <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                        <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                        <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                        <WeekendDayStyle BackColor="#CCCCFF" />
                    </asp:Calendar>
                </td>
                <td class="td-style3" >
                </td>
                <td class="td-style2" >
                </td>
                <td class="td-style3" >
                </td>
                <td class="td-style2" >
                </td>
            </tr>
        </table> 
        </div>
        <div>
            <table class="table-style1">
                <tr>
                    <td> 
                        <asp:GridView ID="dgvPrestamo" runat="server"  AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="100%" OnRowCommand="dgvPrestamo_RowCommand"   >
                            <AlternatingRowStyle BackColor="#CCCCCC" />
                            <EmptyDataTemplate>No hay Registros a mostrar</EmptyDataTemplate>
                            <Columns>
                                <asp:ButtonField ButtonType="Image" ControlStyle-CssClass="img-style1" CommandName="cmdEditar" ImageUrl="~/images/edit.png">
<ControlStyle CssClass="img-style1"></ControlStyle>
                                <ItemStyle Width="10px" />
                                </asp:ButtonField>
                                <asp:ButtonField ButtonType="Image"  CommandName="cmdEliminar" ControlStyle-CssClass="img-style1" ImageUrl="~/images/delete.png" >
<ControlStyle CssClass="img-style1"></ControlStyle>
                                <ItemStyle Width="10px" />
                                </asp:ButtonField>
                                <asp:ButtonField ButtonType="Image"  CommandName="cmdVer"  ControlStyle-CssClass="img-style1" ImageUrl="~/images/view.png"  >
<ControlStyle CssClass="img-style1"></ControlStyle>
                                <ItemStyle Width="10px" />
                                </asp:ButtonField>
                                <asp:BoundField DataField="Codigo" DataFormatString="Codigo" HeaderText="Código" />
                                <asp:BoundField DataField="CodPersona" DataFormatString="CodPersona" HeaderText="CodPersona" Visible="False" />
                                <asp:BoundField DataField="Persona" DataFormatString="Persona" HeaderText="Persona" />
                                <asp:BoundField DataField="FechaPrestamo" DataFormatString="FechaPrestamo" HeaderText="Fecha Prestamo" />
                                <asp:BoundField DataField="FechaEntrega" DataFormatString="FechaEntrega" HeaderText="FechaEntrega" />
                                <asp:BoundField DataField="FechaDevolucion" DataFormatString="FechaDevolucion" HeaderText="Fecha Devolución" />
                                <asp:BoundField DataField="CodEstado" DataFormatString="CodEstado" HeaderText="CodEstado" Visible="False" />
                                <asp:BoundField DataField="Estado" DataFormatString="Estado" HeaderText="Estado"  />
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
                </tr>
            </table>  
        </div>
    </form>
</body>
</html>
