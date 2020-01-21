<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="PandaExpress.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br /><br />
    <div style="text-align:right">
        <asp:Label ID="Label6" runat="server" Text="Label" Height="20px" style="margin-left: 0px" Width="120px"></asp:Label>
    </div> 
    &nbsp&nbsp&nbsp&nbsp
    <asp:Button ID="Button2" runat="server" Text="Logout" OnClick="Button2_Click" CausesValidation="false"/>
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="tb1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ErrorMessage="*RequiredFieldValidator" ControlToValidate="tb1"></asp:RequiredFieldValidator><br />
    <asp:Label ID="Label2" runat="server" Text="Cuisine"></asp:Label>
    <asp:TextBox ID="tb2" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ErrorMessage="*RequiredFieldValidator" ControlToValidate="tb2"></asp:RequiredFieldValidator><br />
    <asp:Label ID="Label3" runat="server" Text="Location"></asp:Label>
    <asp:TextBox ID="tb3" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ForeColor="Red" ErrorMessage="*RequiredFieldValidator" ControlToValidate="tb3"></asp:RequiredFieldValidator><br />
    <asp:Label ID="Label4" runat="server" Text="Rating"></asp:Label>
    <asp:TextBox ID="tb4" runat="server"></asp:TextBox>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="*RangeValidator" ForeColor="Red" ControlToValidate="tb4" MinimumValue="0" MaximumValue="5"></asp:RangeValidator><br />
    <asp:Label ID="Label5" runat="server" Text="Owner"></asp:Label>
    <asp:TextBox ID="tb5" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ForeColor="Red" ErrorMessage="*RequiredFieldValidator" ControlToValidate="tb5"></asp:RequiredFieldValidator><br />
    <asp:Button ID="Button1" runat="server" Text="Add new restaurant" OnClick="Button1_Click1" />
    
</asp:Content>
