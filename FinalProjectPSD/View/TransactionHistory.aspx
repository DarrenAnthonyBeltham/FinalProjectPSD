<%@ Page Title="" Language="C#" MasterPageFile="~/Master/CustomerNavbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="FinalProjectPSD.View.TransactionHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction History</h1>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <table class="table">
        <thead>
            <tr>
                <th>Transaction ID</th>
                <th>Transaction Date</th>
                <th>User Name</th>
                <th>Transaction Status</th>
                <th>Action</th>
            </tr>
        </thead>
        <tbody>
            <% foreach (var th in thlist)
                {   %>
            <tr>
                <td><%= th.TransactionID  %></td>
                <td><%= th.TransactionDate%></td>
                <td><%= th.User.Username%></td>
                <td><%= th.Status%></td>
                <td>
                    <a href="TransactionDetailPage.aspx?id=<%=th.TransactionID %>">details</a>
                </td>
            </tr>
            <%
                }
            %>
        </tbody>
    </table>
</asp:Content>
