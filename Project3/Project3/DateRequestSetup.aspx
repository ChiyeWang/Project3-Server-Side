<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DateRequestSetup.aspx.cs" Inherits="Project3.DateRequestSetup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        DATE PARTICIPANTS<br />
        <asp:TextBox ID="txtParticipant1" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtParticipant2" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <br />
        DATE:
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        <br />
        TIME:
        <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
        <br />
        LOCATION:
        <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update Date" />
    </div>
    </form>
</body>
</html>
