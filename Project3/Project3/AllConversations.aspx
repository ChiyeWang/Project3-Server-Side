<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllConversations.aspx.cs" Inherits="Project3.AllConversations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
           <h1>YOUR MESSAGES</h1>
        
            <asp:GridView ID="gvAllConversations" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" ShowHeader="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvAllConversations_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Receiver" HeaderText="Messenger" />
                    <asp:BoundField DataField="ConversationID" Visible="False" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        
    </form>
</body>
</html>
