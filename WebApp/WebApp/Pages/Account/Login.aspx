<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApp.Pages.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Login Form</h2>
    <p>
        Please enter your name and password.<br />
        <asp:HyperLink ID="InkReg" runat="server" NavigateUrl="~/Pages/Account/RegPage.aspx">Register</asp:HyperLink>
    </p>
    <table style="width: 297px">
        <tr>
            <td><b>Login:</b></td>
            <td class="auto-style1">
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td><b>Password:</b></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"  ></asp:TextBox>
            </td>
            <td></td>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                

            </td>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </tr>
    </table>
</asp:Content>
