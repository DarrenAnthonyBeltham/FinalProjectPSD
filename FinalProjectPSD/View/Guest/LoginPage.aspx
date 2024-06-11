<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FinalProjectPSD.View.Guest.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LoginPage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>LoginPage</h1>
            <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="TB_name" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="TB_password" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="CB" runat="server" />Remember Me?
            <br />
            <asp:Label ID="Label3" runat="server" Text="Don't have an account? "></asp:Label>
            <a href="RegisterPage.aspx">Register</a>
            <br />
            <asp:Label ID="Lbl_error" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
