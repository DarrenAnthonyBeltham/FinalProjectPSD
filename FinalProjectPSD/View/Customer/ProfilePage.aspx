<%@ Page Title="" Language="C#" MasterPageFile="~/Master/CustomerNavbar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="FinalProjectPSD.View.Customer.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="update">
    <h2>Update Profile</h2>
    <div>
        <asp:Label ID="lblName" runat="server" Text="Username"></asp:Label>
        <br />
        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        <asp:Label ID="lblErrorName" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
        <asp:Label ID="lblErrorEmail" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
        <br />
        <asp:RadioButton ID="RBtn_Male" runat="server" Text="Male" GroupName="Gender"/>
        <asp:RadioButton ID="RBtn_Female" runat="server" Text="Female" GroupName="Gender"/>
        <asp:Label ID="lblErrorGender" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblDOB" runat="server" Text="Date of Birth"></asp:Label>
        <br />
        <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
        <asp:Label ID="lblErrorDOB" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <br />
    <asp:Button ID="btnUpdate" runat="server" Text="Update Profile" OnClick="btnUpdate_Click" />
    <asp:Label ID="lblSuccessProfile" runat="server" Text="" ForeColor="Green"></asp:Label>
</div>
<br /> <br />
<div class="updatePassword">
    <h2>Update Password</h2>
    <div>
        <asp:Label ID="lblOldPass" runat="server" Text="Old Password"></asp:Label>
        <br />
        <asp:TextBox ID="tbOldPass" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblErrorOldPass" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblNewPass" runat="server" Text="New Password"></asp:Label>
        <br />
        <asp:TextBox ID="tbNewPass" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblErrorNewPass" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <br />
    <asp:Button ID="btnUpdatePass" runat="server" Text="Update Password" OnClick="btnUpdatePass_Click"/>
    <asp:Label ID="lblSuccessPass" runat="server" Text="" ForeColor="Green"></asp:Label>
</div>
</asp:Content>
