<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="PandaExpress.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br /><br />
    <div style="text-align:right">
        <asp:Label ID="Label1" runat="server" Text="Label" Height="20px" style="margin-left: 0px" Width="120px"></asp:Label>
    </div>
    &nbsp&nbsp&nbsp&nbsp
    <asp:Button ID="Button2" runat="server" Text="Logout" OnClick="Button2_Click" CausesValidation="false" />
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ForeColor="Red" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator><br />
    <asp:Button ID="Button1" runat="server" Text="SEARCH" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="5" OnPageIndexChanging="GridView1_PageIndexChanging" DataKeyNames="Id" OnRowCommand="goto_click">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID"></asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="NAME"></asp:BoundField>
            <asp:BoundField DataField="Cuisine" HeaderText="CUISINE"></asp:BoundField>
            <asp:BoundField DataField="Location" HeaderText="LOCATION"></asp:BoundField>
            <asp:BoundField DataField="Rating" HeaderText="RATING"></asp:BoundField>
            <asp:ButtonField CommandName="chalo" ButtonType="Button" Text="VIEW"/>
        </Columns>
    </asp:GridView>
</asp:Content>
