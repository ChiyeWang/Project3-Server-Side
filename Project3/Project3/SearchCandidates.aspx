<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchCandidates.aspx.cs" Inherits="Project3.SearchCandidates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        SEARCH CANDIDATES<br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
            <asp:ListItem>MALE</asp:ListItem>
            <asp:ListItem>FEMALE</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Age&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="43px"></asp:TextBox>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
