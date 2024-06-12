<%@ Page Title="" Language="C#" MasterPageFile="~/Master/CustomerNavbar.Master" AutoEventWireup="true" CodeBehind="ViewCustomer.aspx.cs" Inherits="FinalProjectPSD.View.Admin.ViewCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="userGridView" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="UserName" HeaderText="Username" SortExpression="UserName" />
            <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Action" ShowHeader="True" Text="Detail" />
        </Columns>
    </asp:GridView>
</asp:Content>
