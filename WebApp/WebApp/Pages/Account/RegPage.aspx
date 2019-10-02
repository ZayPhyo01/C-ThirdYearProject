<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegPage.aspx.cs" Inherits="WebApp.Pages.Account.RegPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>User Name:</td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>E-mail:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>Password:</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Confirm Password:</td>
            <td>
                <asp:TextBox ID="txtCPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            <td></td>
        </tr>
         <tr>
            <td>Phone Number:</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox></td>
            <td></td>
        </tr>
         <tr>
            <td>Address</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnReg" runat="server" Text="Register" OnClick="btnReg_Click" /><br />
                <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
            </td>
            <td></td>
            <td></td>
        </tr>
    </table>
</asp:Content>
