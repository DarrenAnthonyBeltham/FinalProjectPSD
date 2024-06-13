<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="FinalProjectPSD.View.Guest.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register Page</h1>
            <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="TB_name" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="TB_email" runat="server"></asp:TextBox>
            <br />
            <asp:RadioButton ID="rbMale" runat="server" />Male
            <asp:RadioButton ID="rbFemale" runat="server" />Female
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="reg_password" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text=" Confirm Password: "></asp:Label>
            <asp:TextBox ID="reg_confpass" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="DoB : "></asp:Label>
            <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Already Have An Account?"></asp:Label>
            <a href="LoginPage.aspx">Login</a>
            <br />
            <asp:Label ID="reg_errorlbl" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
