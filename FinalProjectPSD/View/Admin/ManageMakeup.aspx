<%@ Page Title="" Language="C#" MasterPageFile="~/Master/CustomerNavbar.Master" AutoEventWireup="true" CodeBehind="ManageMakeup.aspx.cs" Inherits="FinalProjectPSD.View.Admin.ManageMakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3>Manage Makeup Brand</h3>
        <asp:GridView ID="GV_Brand" runat="server" AutoGenerateColumns="false"
            OnRowDeleting="GV_Brand_RowDeleting" OnSelectedIndexChanging="GV_Brand_SelectedIndexChanging">
            <Columns>
                <asp:BoundField DataField="MakeupBrandID" HeaderText="Brand ID" SortExpression="MakeupBrandID"/>
                <asp:BoundField DataField="MakeupBrandName" HeaderText="Name" SortExpression="MakeupBrandName"/>
                <asp:BoundField DataField="MakeupBrandRating" HeaderText="Price" SortExpression="MakeupBrandRating"/>
                <asp:CommandField ShowSelectButton="true" ButtonType="Button" SelectText="Update Brand" />
                <asp:CommandField ShowDeleteButton="true" ButtonType="Button" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="label_error" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="button_insertBrand" runat="server" Text="Insert Makeup Brand" OnClick="button_insertBrand_Click"/>
    </div>
</asp:Content>
