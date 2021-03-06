﻿   <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DateRequests.aspx.cs" Inherits="Project3.DateRequests" %>

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
                <li><a href="../Project3/ProfilePage.aspx">Profile</a></li>
                <li><a href="../search.aspx">Search</a></li>
                <li><a href="../DateRequests.aspx">Requests</a></li>
                <li><a href="../AllConversations.aspx">Messages</a></li>
                <li class="active"><a href="../Login.aspx">Log out</a></li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
    <div>
    <h1>ACTIVE DATES</h1>
        <asp:GridView ID="gvActive" runat="server" 
            AutoPostBack="False" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="White" BorderWidth="20px" 
            CellPadding="4" ForeColor="Black" GridLines="Horizontal" 
            EmptyDataText="None at this time" 
            OnRowCommand="gvActive_RowCommand" Width="500px">
            <Columns>
                <asp:BoundField DataField="RequestID" Visible="False" />
                <asp:BoundField DataField="Sender" HeaderText="Partcipant 1" />
                <asp:BoundField DataField="Receiver" HeaderText="Participant 2" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="Button1" runat="server" 
                            CausesValidation="False"  Text="DETAILS"  
                            CommandArgument='<%# Container.DataItemIndex %>' 
                            CommandName="SeeConversation" UseSubmitBehavior="False" PostBackUrl="~/DateRequestSetup.aspx" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                No current active dates.
            </EmptyDataTemplate>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView><hr />
        <br />
        <h1>DATE REQUESTS RECEIVED</h1>
        <asp:GridView ID="gvReceived" runat="server"
             AutoPostBack="False" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="White" BorderWidth="20px" 
            CellPadding="4" ForeColor="Black" GridLines="Horizontal" 
            EmptyDataText="None at this time" OnSelectedIndexChanged="gvReceived_SelectedIndexChanged" 
            Width="500px" OnRowCommand="gvReceived_RowCommand">
            <Columns>
                <asp:BoundField DataField="RequestID" Visible="False" />
                <asp:BoundField DataField="Sender" HeaderText="Sent By" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btnAccept"  runat="server" CausesValidation="False" CommandName="Accept" Text="ACCEPT" CommandArgument='<%# Container.DataItemIndex %>' UseSubmitBehavior="False"/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:Button ID="btnDecline" runat="server" CausesValidation="False" CommandArgument='<%# Container.DataItemIndex %>' CommandName="Decline" Text="DECLINE" UseSubmitBehavior="False" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                No current date requests received
            </EmptyDataTemplate>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView><hr />
        <br />
        <h1>DATE REQUESTS SENT</h1>
        <asp:GridView ID="gvSent" runat="server" AutoPostBack="True" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderWidth="20px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" EmptyDataText="None at this time" Width="500px">
            <Columns>
                <asp:BoundField DataField="RequestID" Visible="False" />
                <asp:BoundField DataField="Receiver" HeaderText="Sent To" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
            </Columns>
            <EmptyDataTemplate>
                No current date requests sent
            </EmptyDataTemplate>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
