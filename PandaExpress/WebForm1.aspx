   <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PandaExpress.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"   />&nbsp
    <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
    <asp:Button ID="Button3" runat="server" Text="Change Theme" OnClick="Button3_Click" />
    <%-- <asp:Button ID="Button3" runat="server" Text="Register as Administrator" OnClick="Button3_Click" />--%>
    <%--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
</asp:Content>
