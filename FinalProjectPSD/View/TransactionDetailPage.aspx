<%@ Page Title="" Language="C#" MasterPageFile="~/Master/CustomerNavbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="FinalProjectPSD.View.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">
        <thead>
            <tr>
                <th>Transaction ID</th>
                <th>Makeup ID</th>
                <th>Quantity</th>
            </tr>
        </thead>
        <tbody>
            <% foreach(var td in tdlist)
            {   %>
            <tr>
                <td><%=td.TransactionID %></td>
                <td><%=td.MakeupID %></td>
                <td><%=td.Quantity %></td>
            </tr><%
            }
                 %>
        </tbody>
    </table>
</asp:Content>
