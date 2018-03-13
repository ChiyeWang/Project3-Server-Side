<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="Project3.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProfile" runat="server" Font-Size="40pt" Text="My Profile"></asp:Label>
            <br />
            <br />
            <div>
                <asp:Label ID="lblContact" runat="server" Text="Contact Information(will be visible to all users)" Font-Size="15pt"></asp:Label>
            </div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
