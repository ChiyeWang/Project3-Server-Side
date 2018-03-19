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
                <li class="active"><a href="../Login.aspx">Log out</a></li>
            </ul>
        </div>
    </nav>
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
