<%@ Page Title="" Language="C#" MasterPageFile="~/WebMaster.master" AutoEventWireup="true" CodeBehind="WebCRUDEmpleados.aspx.cs" Inherits="Web_Hunde.Mantenimientos.Empleados.WebCRUDEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 35px;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            width: 822px;
        }
        .auto-style5 {
            height: 35px;
            width: 822px;
        }
        .auto-style6 {
            width: 80px;
        }
        .auto-style7 {
            width: 86px;
        }
        .auto-style11 {
            height: 35px;
            width: 171px;
        }
        .auto-style12 {
            width: 171px;
        }
        .auto-style14 {
            height: 26px;
            width: 171px;
        }
        .auto-style15 {
            width: 822px;
        }
        .nuevoEstilo1 {
            font-size: xx-large;
        }
        .auto-style16 {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate >
            <div class="container">
            <h1 class="text-primary text-center"><strong>Listado de empleados</strong></h1>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style15">
                        
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style14"></td>
                    <td class="auto-style4">
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style5">
                        
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="btnAgregar" runat="server" CssClass="btn btn-primary" Text="Agregar Empleado" Width="144px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="3">
                        <asp:Label ID="lblMensaje" runat="server" CssClass="text-danger"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="3">
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="945px">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">
                    </td>
                    <td class="auto-style15">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
