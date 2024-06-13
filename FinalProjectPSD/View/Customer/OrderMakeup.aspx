<%@ Page Title="" Language="C#" MasterPageFile="~/Master/CustomerNavbar.Master" AutoEventWireup="true" CodeBehind="OrderMakeup.aspx.cs" Inherits="FinalProjectPSD.View.Customer.OrderMakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>MakeMeUpzz Catalog</h1>

        <asp:GridView ID="makeupList" runat="server" AutoGenerateColumns="False" OnRowCommand="makeupList_RowCommand">
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
                        <asp:Button ID="OrderBtn" runat="server" CommandName="Order" CommandArgument='<%# Eval("MakeupID") %>' Text="Order" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

    <div>
        <h2>Shopping cart</h2>
        <asp:GridView ID="cartList" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Makeups.MakeupName" HeaderText="Name" SortExpression="Makeups.MakeupName" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="clearBtn" runat="server" Text="Clear" />
        <asp:Button ID="checkoutBtn" runat="server" Text="Checkout" OnClick="checkoutBtn_Click" />
        <br />
        <asp:Label ID="cartLbl" runat="server" Text=""></asp:Label>
    </div>

    <div>
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
