<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerNavbar.Master" AutoEventWireup="true" CodeBehind="OrderMakeup.aspx.cs" Inherits="FinalProjectPSD.View.Customer.OrderMakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>MakeMeUpzz Catalog</h1>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="Weight (g)" SortExpression="MakeupWeight" />
                <asp:BoundField DataField="MakeupTypes.MakeupTypeName" HeaderText="Type" SortExpression="MakeupTypes.MakeupTypeName" />
                <asp:BoundField DataField="MakeupBrands.MakeupBrandName" HeaderText="Brand" SortExpression="MakeupBrands.MakeupBrandName" />
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="QuantityTB" runat="server" Text="1"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="OrderBtn" runat="server" Text="Order" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
