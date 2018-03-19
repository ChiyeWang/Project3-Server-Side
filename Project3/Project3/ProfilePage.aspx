<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="Project3.ProfilePage" %>

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
        <div id="public">
            <asp:Label ID="lblWelcome" runat="server" Font-Size="30pt" Text="My Profile"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblProfile" runat="server" Font-Size="40pt" Text="My Profile"></asp:Label>
            <br />
            <br />
            <div>
                <asp:Label ID="lblContact" runat="server" Text="Contact Information(will be visible to all users)" Font-Size="15pt"></asp:Label>
                <br />
                <br />
            </div>
            <div>
                <asp:Label ID="lblState" runat="server" Text="State:"></asp:Label>
                <asp:TextBox ID="txtState" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
                &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address:"></asp:Label>
                <asp:TextBox ID="txtEmailAddress" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblLikes" runat="server" Text="Likes(Please list some things that you like):"></asp:Label>
                <asp:TextBox ID="txtLikes" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
                &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                <asp:Label ID="lblAge" runat="server" Text="Age:"></asp:Label>
                <asp:TextBox ID="txtAge" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblHeight" runat="server" Text="Height:"></asp:Label>
                <asp:TextBox ID="txtHeight" runat="server" CssClass ="textbox" Enabled="False"></asp:TextBox>
                &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                <asp:Label ID="lblCommitmentType" runat="server" Text="Commitment Type:"></asp:Label>
                <asp:DropDownList ID="ddlCommitmentType" runat="server" CssClass="textbox" Enabled="False" >
                    <asp:ListItem Text="Friend" Value="Friend"></asp:ListItem>
                    <asp:ListItem Text="Relationship" Value="Relationship"></asp:ListItem>
                    <asp:ListItem Text="Marriage" Value="Marriage"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <br />
            <div>
                <asp:Label ID="lblJobType" runat="server" Text="Job Type:"></asp:Label>
                <asp:TextBox ID="txtJobType" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
                                &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblDescription" runat="server" Text="Description:"></asp:Label>
                <br />
                <asp:TextBox ID="txtDescription" runat="server" Columns ="50" Rows ="30" Height="70px" Enabled="False"></asp:TextBox>
            </div>
            <br />
            <br />
            </div>
            <div id="private">
            <div>
                <asp:Label ID="lblPrivateContact" runat="server" Text="Personal Information(will not be visible to all users)" Font-Size="15pt"></asp:Label>
                <br />
                <br />
            </div>
            <div>
                <asp:Label ID="lblPhone" runat="server" Text="Phone Number:"></asp:Label>
                <asp:TextBox ID="txtPhone" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
                &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                <asp:Label ID="lblOccupation" runat="server" Text="Occupation:"></asp:Label>
                <asp:TextBox ID="txtOccupation" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="lblFavorites" runat="server" Text="Favorites"></asp:Label>
                <asp:TextBox ID="txtFavorites" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
                <asp:Label ID="lblCity" runat="server" Text="City:"></asp:Label>
                <asp:TextBox ID="txtCity" runat="server" CssClass="textbox" Enabled="False"></asp:TextBox>
            </div>
            </div>
        <br />
        <asp:Button ID="btnModify" runat="server" Text="Modify Profile Transaction" OnClick="btnModify_Click" />
        &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
        <asp:Button ID="btnRemove" runat="server" Text="Remove Public Profile Transaction" />

    </form>
</body>
</html>
