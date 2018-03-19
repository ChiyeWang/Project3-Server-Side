<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DateRequestSetup.aspx.cs" Inherits="Project3.DateRequestSetup" %>

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
    <div>
        DATE PARTICIPANTS<br />
        <asp:GridView ID="gvParticipants" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnLoad="gvParticipants_Load">
            <Columns>
                <asp:BoundField DataField="Sender" HeaderText="Participant 1" />
                <asp:BoundField DataField="Receiver" HeaderText="Participant 2" />
                <asp:BoundField DataField="Date" Visible="True" NullDisplayText=" " />
                <asp:BoundField DataField="Time" Visible="True" NullDisplayText=" " />
                <asp:BoundField DataField="Location" Visible="True" HtmlEncode="False" NullDisplayText=" " />
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
        <asp:TextBox ID="txtParticipant1" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtParticipant2" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <br />
        DATE:
        <asp:TextBox ID="txtDate" runat="server" MaxLength="50" ValidateRequestMode="Disabled"></asp:TextBox>
        <br />
        TIME:
        <asp:TextBox ID="txtTime" runat="server" MaxLength="50" ValidateRequestMode="Disabled"></asp:TextBox>
        <br />
        LOCATION:
        <asp:TextBox ID="txtLocation" runat="server" MaxLength="50" ValidateRequestMode="Disabled"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update Date" CausesValidation="False" UseSubmitBehavior="False" />
    </div>
    </form>
</body>
</html>
