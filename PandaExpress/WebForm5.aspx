<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="PandaExpress.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br /><br />
    <div style="text-align:right">
        <asp:Label ID="Label1" runat="server" Text="Label" Height="20px" style="margin-left: 0px" Width="120px"></asp:Label>
    </div>
    <asp:Button ID="Button5" runat="server" Text="Log Out" OnClick="Button5_Click"/><br /><br />
    <asp:Button ID="Button1" runat="server" Text="ViewData" OnClick="Button1_Click1" />&nbsp
    <asp:Button ID="Button2" runat="server" Text="Add Restaurant" OnClick="Button2_Click1"/>&nbsp
    <asp:Button ID="Button3" runat="server" Text="Comments" OnClick="Button3_Click"/>&nbsp
    <asp:Button ID="Button4" runat="server" Text="Filter Report" OnClick="Button4_Click"/><br />
    <br /><br /><br />
    <asp:Label ID="lbl" runat="server"  Height="50px" Width="341px"/>
</asp:Content>
