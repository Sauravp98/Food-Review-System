<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="PandaExpress.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
    <div style="text-align:right">
        <asp:Label ID="Label4" runat="server" Text="Label" Height="20px" style="margin-left: 0px" Width="120px"></asp:Label>
    </div>
    <br /><br />
    <asp:Label ID="Label1" runat="server" Text="Rating"></asp:Label>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
    <asp:Label ID="Label2" runat="server" Text="Location"></asp:Label>
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" ></asp:CheckBoxList>
    <asp:Label ID="Label3" runat="server" Text="Cuisine"></asp:Label>
    <asp:CheckBoxList ID="CheckBoxList2" runat="server" ></asp:CheckBoxList>
    <asp:Button ID="Button1" runat="server" Text="Filter" OnClick="Button1_Click"/>
    <asp:GridView ID="GridView1" runat="server" AllowSorting="true" AutoGenerateColumns="false" OnSorting="GridView1_Sorting" >
            <Columns>    
            <asp:BoundField DataField="Id" HeaderText="ID"></asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="NAME" ></asp:BoundField>
            <asp:BoundField DataField="Cuisine" HeaderText="CUISINE"></asp:BoundField>
            <asp:BoundField DataField="Location" HeaderText="LOCATION"></asp:BoundField>
            <asp:BoundField DataField="Rating" HeaderText="RATING" SortExpression="Rating"></asp:BoundField>
            <asp:BoundField DataField="Views" HeaderText="VIEWS" SortExpression="Views"></asp:BoundField>
            <asp:BoundField DataField="Owner" HeaderText="OWNER"></asp:BoundField>
            </Columns>
    </asp:GridView>
</asp:Content>
