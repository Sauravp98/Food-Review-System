<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="PandaExpress.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br /><br />
    <div style="text-align:right">
        <asp:Label ID="Label1" runat="server" Text="Label" Height="20px" style="margin-left: 0px" Width="120px"></asp:Label>
    </div>
    &nbsp&nbsp&nbsp&nbsp
    <asp:Button ID="Button2" runat="server" Text="Logout" OnClick="Button2_Click" />
    <asp:TextBox ID="TextBox1" Text="Add a public comment" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Comment" OnClick="Button1_Click" /><br />
    <br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <br/><br/><br/><br/>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Cmt_Text" HeaderText="Comments"></asp:BoundField>
            <%-- <asp:BoundField DataField="Cuisine" HeaderText="CUISINE"></asp:BoundField>
            <asp:BoundField DataField="Location" HeaderText="LOCATION"></asp:BoundField>
            <asp:BoundField DataField="Rating" HeaderText="RATING"></asp:BoundField>
            <asp:ButtonField CommandName="chalo" ButtonType="Button" Text="VIEW"/>--%>
        </Columns>
    </asp:GridView>
</asp:Content>
