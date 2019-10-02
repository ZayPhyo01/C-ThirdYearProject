<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" enableEventValidation="false" CodeBehind="ShoppingCart.aspx.cs" Inherits="WebApp.Pages.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:Panel runat="server" ID="p1"> 
<asp:GridView ID="GridView2" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    runat="server" AutoGenerateColumns="true" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting">
    
</asp:GridView>

    <table style="width: 50%">
    <tr>
        <td class="auto-style2"> Total :    </td>
       
        <td class="auto-style1">            
            <asp:Literal ID="litTotal" runat="server" Text=""></asp:Literal>
        </td>
    </tr>

        <tr>
        <td class="auto-style2"> Vat :    </td>
       
        <td class="auto-style1">            
            <asp:Literal ID="litVat" runat="server" Text=""></asp:Literal>
        </td>
    </tr>
     <tr>
        <td class="auto-style2"> Shipping :    </td>
       
        <td class="auto-style1">
            <asp:Literal ID="LitShipping" runat="server"></asp:Literal> 1500 kyats </td>
    </tr>
        <tr>
        <td class="auto-style2"> Total Amount :    </td>
       
        <td class="auto-style1"> <asp:Literal ID="LitTotAmount" runat="server" Text=""></asp:Literal> 

        </td>
    </tr>
       
        </table>
       </asp:Panel>

    <table>
         <tr>
        <td colspan="2"> 
            <asp:LinkButton ID="LinkButton1" Text="Continue Shopping" runat="server" PostBackUrl="~/index.aspx"></asp:LinkButton>
        OR
           
                
         <asp:Button ID="Button2" runat="server" Text="Continue CheckOut"  Width="250px" CssClass="button" ForeColor="Fuchsia" OnClick="Button1_ClickButton1_Click"></asp:Button> 
            </td>
    </tr>

    </table>
     
</asp:Content>
