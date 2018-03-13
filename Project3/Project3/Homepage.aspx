<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Project3.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 316px; top: 12px; position: absolute; height: 32px; width: 168px" Text="Start Dating By Sign Up"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 263px; top: 50px; position: absolute" Text="User Name:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 380px; top: 50px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 263px; top: 90px; position: absolute" Text="Password: "></asp:Label>
        
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 380px; top: 90px; position: absolute"></asp:TextBox>
        
        <asp:Button ID="btnSignup" runat="server" style="z-index: 1; left: 285px; top: 216px; position: absolute" Text="Sign Up" />
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 405px; top: 217px; position: absolute" Text="Log in" />
        
        <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 263px; top: 130px; position: absolute" Text="Full Name:"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server" style="z-index: 1; left: 380px; top: 130px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 263px; top: 170px; position: absolute" Text="Email Address:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 380px; top: 170px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
