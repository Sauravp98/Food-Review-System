<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="PandaExpress.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
    <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
    <asp:TextBox ID="tb1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tb1" runat="server" ForeColor="Red" ErrorMessage="*Field Required"></asp:RequiredFieldValidator><br />
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="tb2" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="tb2" runat="server" ForeColor="Red" ErrorMessage="*Field Required"></asp:RequiredFieldValidator><br />
    <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="tb3" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tb3" runat="server" ForeColor="Red" ErrorMessage="*Field Required"></asp:RequiredFieldValidator><br />
    <asp:Label ID="Label4" runat="server" Text="Mobile"></asp:Label>
    <asp:TextBox ID="tb4" runat="server"></asp:TextBox>
    <asp:CustomValidator ID="CustomValidator1" runat="server" ForeColor="Red" ErrorMessage="*Valid Mobile Number Required" ControlToValidate="tb4" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator><br />
    <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="tb5" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ForeColor="Red" ErrorMessage="*Valid Email Required" ControlToValidate="tb5" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator><br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
    <asp:Button ID="Back_Home" runat="server" Text="BACK" OnClick="Back_Home_Click" CausesValidation="false" />

</asp:Content>
