<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="Project3.ViewProfile" %>

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
                <li><a href="../ProfilePage.aspx">Profile</a></li>
                <li><a href="../search.aspx">Search</a></li>
                <li class="active"><a href="../Login.aspx">Log out</a></li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server" style="font-size: 35px">
        <div>
            <asp:Label ID="lblProfile" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
            <asp:Label ID="lblNameOutput" runat="server" Text="Label"></asp:Label>
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
            <asp:Label ID="lblState" runat="server" Text="State:"></asp:Label>
            <asp:Label ID="lblStateOutput" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblOccupation" runat="server" Text="Occupation:"></asp:Label>
            <asp:Label ID="lblOccupationOutput" runat="server" Text="Label"></asp:Label>
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
            <asp:Label ID="lblAge" runat="server" Text="Age:"></asp:Label>
            <asp:Label ID="lblAgeOutput" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblCommitmentType" runat="server" Text="Commitment Type:"></asp:Label>
            <asp:Label ID="lblCommitmentTypeOutput" runat="server" Text="Label"></asp:Label>
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
            <asp:Label ID="lblHeight" runat="server" Text="Height:"></asp:Label>
            <asp:Label ID="lblHeightOutput" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblLikes" runat="server" Text="Likes:"></asp:Label>
            <asp:Label ID="lblLikesOutput" runat="server" Text="Label"></asp:Label>
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
            <asp:Label ID="lblJobType" runat="server" Text="Job Type:"></asp:Label>
            <asp:Label ID="lblJobTypeOutput" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblDescription" runat="server" Text="Description:"></asp:Label>
            <asp:Label ID="lblDescriptionOutput" runat="server" Text="Label"></asp:Label>
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
            &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
            <asp:Label ID="lblContactEmail" runat="server" Text="Contact Email:"></asp:Label>
            <asp:Label ID="lblContactEmailOutput" runat="server" Text="Label"></asp:Label>


        </div>
    </form>
</body>
</html>
