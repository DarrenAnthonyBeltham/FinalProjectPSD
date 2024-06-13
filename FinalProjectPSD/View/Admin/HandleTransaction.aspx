<%@ Page Title="" Language="C#" MasterPageFile="~/Master/CustomerNavbar.Master" AutoEventWireup="true" CodeBehind="HandleTransaction.aspx.cs" Inherits="FinalProjectPSD.View.Admin.HandleTransaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Order Queue</h3>
    <asp:GridView ID="GV" runat="server" AutoGenerateColumns="false" OnRowCommand="GV_RowCommand">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID"/>
            <asp:BoundField DataField="User.UserName" HeaderText="Username" SortExpression="User.UserName"/>
            <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate"/>
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"/>
            <asp:ButtonField Text="Handle Transaction" ButtonType="Button" CommandName="handle"/>
        </Columns>
    </asp:GridView>
    <asp:Label ID="Lbl_Error" runat="server" Text=""></asp:Label>
</asp:Content>
