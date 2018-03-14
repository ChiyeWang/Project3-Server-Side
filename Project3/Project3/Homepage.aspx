<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="Project3.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Main.css">
    <style>
        body{
            background-image:url('pic/Main.jpg');
            background-size:100%;
            width:100%;
        }
        
    </style>
</head>
<body>
    <!-- This is the Kristina Branch pull test-->
    <!-- asdfasdfasdf -->
    <form id="form1" runat="server">
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 600px; top: 13px; position: absolute; height: 32px; width: 562px; margin-top: 0px;" Text="Start Dating By Sign Up" Font-Size="50px"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 550px; top: 100px; position: absolute" Text="User Name:" Font-Size="30px"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 900px; top: 100px; position: absolute; height: 28px;"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 550px; top: 150px; position: absolute" Text="Password: " Font-Size="30px"></asp:Label>
        
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 900px; top: 150px; position: absolute; height: 28px;"></asp:TextBox>
        <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 550px; top: 200px; position: absolute" Text="Full Name:" Font-Size="30px"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server" style="z-index: 1; left: 900px; top: 200px; position: absolute; height: 28px;"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 550px; top: 250px; position: absolute" Text="Email Address:" Font-Size="30px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 900px; top: 250px; position: absolute; height: 28px;"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 548px; top: 344px; position: absolute" Text="Log in" Font-Size="30px" OnClick="btnLogin_Click" />


        
        <asp:Button ID="btnSignup" runat="server" style="z-index: 1; left: 850px; top: 344px; position: absolute; " Text="Sign Up" Font-Size="30px" OnClick="btnSignup_Click"/>
        


     

        


     
        <asp:Button ID="btnGuest" runat="server" Text="Continue as Guest" style="z-index: 1; left: 550px; top: 422px; position: absolute"  Font-Size="30px"/>

        <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="15px" style="z-index: 1; left: 550px; top: 303px; position: absolute; width: 138px; height: 23px; margin-top: 0px" Text="Label" ForeColor="Red" Visible="False"></asp:Label>

    </form>
</body>
</html>
