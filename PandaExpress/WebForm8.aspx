<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="PandaExpress.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br /><br />
    <div style="text-align:right">
        <asp:Label ID="Label1" runat="server" Text="Label" Height="20px" style="margin-left: 0px" Width="120px"></asp:Label>
    </div> 
    &nbsp&nbsp&nbsp&nbsp
    <asp:Button ID="Button2" runat="server" Text="Logout" OnClick="Button2_Click" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Comment"/>
            <asp:BoundField DataField="Cmt_Text" HeaderText="Comment"/>
            <asp:ButtonField ButtonType="Button" Text="Accept" CommandName="chalo"/>
            <asp:ButtonField ButtonType="Button" Text="Reject" CommandName="niklo"/>
        </Columns>
    </asp:GridView>
</asp:Content>
