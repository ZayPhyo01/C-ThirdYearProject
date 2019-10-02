<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InsertFloraType.aspx.cs" Inherits="WebApp.Pages.Management.InsertFloraType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Cake Type Name:<br /><br />
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><br /><br />
    <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
</asp:Content>
