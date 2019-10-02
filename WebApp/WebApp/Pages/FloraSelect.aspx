<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FloraSelect.aspx.cs" Inherits="WebApp.Pages.FloraSelect" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="height: 261px; width: 100%">
    <tr>
        <td rowspan="4">
            <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" Width="300px" ImageUrl="~/Images/Flora/chocolate.jpg" />
        </td>
       
        <td class="alignTitle">
            <h2>
            <asp:Label ID="lblTitle" runat="server" Text="lblTitle"></asp:Label>
                </h2>
                <hr style="height: -12px; width: 200px" />
        </td>
    </tr>
    <tr>
            <td>
            <asp:Label ID="lblDescription" runat="server" Text="lblDes" CssClass="detailsDescription"></asp:Label>
            </td>
    
        <td>
            <asp:Label ID="lblPrice" runat="server" Text="lblPrice" CssClass="detailsPrice"></asp:Label>
            <br />
        Quantity:
        <asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add Product" CssClass="button" OnClick="btnAdd_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>    
        </td>
    </tr>
    <tr>
        <td>Flora Number: 
        <asp:Label ID="lblItemNr" runat="server" Text="Label"></asp:Label>
            </td>
    </tr>
    
    <tr>
        <td>
        <asp:Label ID="label1" runat="server" Text="Available"></asp:Label>
            </td>
    </tr>
</table>
</asp:Content>
