<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllConversations.aspx.cs" Inherits="Project3.AllConversations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="style" type="text/css" href="Main.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <style>
        .textbox {
            margin: 0px 15px;
        }
        #public{
            background-color :aquamarine;
        }
        #private{
            background-color:bisque;
        }
    </style>
</head>
<body>
    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" style="font-size:40px" >StudentMeetStudent</a>
            </div>
            <ul class="nav navbar-nav" style="font-size:20px">
                <li><a href="../ProfilePage.aspx">Profile</a></li>
                <li><a href="../search.aspx">Search</a></li>
                <li><a href="../DateRequests.aspx">Requests</a></li>
                <li><a href="../AllConversations.aspx">Messages</a></li>
                <li class="active"><a href="../Login.aspx">Log out</a></li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        
           <h1>YOUR MESSAGES</h1>
            To see conversation, click the "Select" button to the left of the conversation.
            <asp:GridView ID="gvAllConversations" runat="server" BackColor="White" BorderColor="White" BorderWidth="20px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" ShowHeader="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvAllConversations_SelectedIndexChanged" CellSpacing="10" AutoGenerateColumns="False" EmptyDataText="No Messages at this time" Width="275px">
                <Columns>
                    <asp:BoundField DataField="Receiver" />
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
