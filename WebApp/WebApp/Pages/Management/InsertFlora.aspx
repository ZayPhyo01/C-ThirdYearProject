<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InsertFlora.aspx.cs" Inherits="WebApp.Pages.Management.InsertFlora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Cake Name:<br /><br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
    Cake Type:<br /><br />
    <asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource1" DataTextField="Id" DataValueField="Id" ></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:coffeeshopConnectionString %>" SelectCommand="SELECT [Id] FROM [ProductTypes1]"></asp:SqlDataSource>
    Price:<br /><br />
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br />
    <asp:DropDownList ID="ddlImage" runat="server"></asp:DropDownList><br /><br />
    Description:<br /><br />
    <asp:TextBox ID="txtDes" runat="server"></asp:TextBox><br /><br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><br />
    <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
</asp:Content>
