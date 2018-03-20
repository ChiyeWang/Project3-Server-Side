<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="Project3.search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body style="background-color: cadetblue">
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
    <form id="form1" runat="server" >
        <div style ="font-size :30px">
            <asp:Label ID="lblInstruction" runat="server" Text="You can search your dater by any of the fields"></asp:Label>
            <br />
            <asp:Label ID="lblSearchState" runat="server" Text="Search By State"></asp:Label>
            <asp:TextBox ID="txtSearchState" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearchState" runat="server" Text="Search" OnClick="btnSearchState_Click" />
            <br />
            <asp:Label ID="lblSearchAge" runat="server" Text="Search By Age"></asp:Label>
            <asp:TextBox ID="txtSearchAge" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearchAge" runat="server" Text="Search" OnClick="btnSearchAge_Click" />
            <br />
            <asp:Label ID="lblSearchCommitment" runat="server" Text="Search By Commitment Type"></asp:Label>
            <asp:TextBox ID="txtSearchCommitment" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearchCommitment" runat="server" Text="Search" OnClick="btnSearchCommitment_Click" />
            <br />
            <asp:Label ID="lblSearchOccupation" runat="server" Text="Search By Occupation"></asp:Label>
            <asp:TextBox ID="txtSearchOccupation" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearchOccupation" runat="server" Text="Search" OnClick="btnSearchOccupation_Click" />
        </div>
        <asp:GridView ID="gvGuestResult" runat="server" AutoGenerateColumns="False" Visible="False" Width="864px" OnSelectedIndexChanged="gvGuestResult_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="Fullname" HeaderText="Name" />
                <asp:BoundField DataField="State" HeaderText="State" />
                <asp:BoundField DataField="CommitmentType" HeaderText="Commitment Type" />
                <asp:BoundField DataField="Likes" HeaderText="Likes" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:CommandField ButtonType="Button" SelectText="View" ShowSelectButton="True" />
                <asp:BoundField DataField="Username" HeaderText="" Visible="false" />
            </Columns>
        </asp:GridView>
        <asp:GridView ID="gvPublicResult" runat="server" AutoGenerateColumns="False" Style="z-index: 1; left: 7px; top: 376px; position: absolute; height: 188px; width: 1052px" Visible="False" Width="1052px" OnSelectedIndexChanged="gvPublicResult_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Fullname" HeaderText="Name" />
                <asp:BoundField DataField="State" HeaderText="State" />
                <asp:BoundField DataField="Occupation" HeaderText="Occupation" />
                <asp:BoundField DataField="Age" HeaderText="Age" />
                <asp:BoundField DataField="CommitmentType" HeaderText="Commitment Type" />
                <asp:BoundField DataField="Height" HeaderText="Height" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:CommandField ButtonType="Button" NewText="View" SelectText="View" ShowSelectButton="True" />
                <asp:BoundField DataField="Username" HeaderText="Username" Visible="true" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
