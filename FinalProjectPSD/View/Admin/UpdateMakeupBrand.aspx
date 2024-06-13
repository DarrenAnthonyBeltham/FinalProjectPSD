<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMakeupBrand.aspx.cs" Inherits="FinalProjectPSD.View.Admin.UpdateMakeupBrand" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Makeup Brand"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Makeup Rating"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_error" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update Brand" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
