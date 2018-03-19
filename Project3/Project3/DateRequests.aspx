<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DateRequests.aspx.cs" Inherits="Project3.DateRequests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>ACTIVE DATES</h1>
        <asp:GridView ID="gvActive" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" EmptyDataText="None at this time">
            <Columns>
                <asp:BoundField DataField="RequestID" Visible="False" />
                <asp:BoundField DataField="Sender" HeaderText="Partcipant 1" />
                <asp:BoundField DataField="Receiver" HeaderText="Participant 2" />
                <asp:CommandField ButtonType="Button" SelectText="DETAILS" ShowCancelButton="False" ShowSelectButton="True" />
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
        </asp:GridView>
        <br />
        <h1>DATE REQUESTS RECEIVED</h1>
        <asp:GridView ID="gvReceived" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" EmptyDataText="None at this time">
            <Columns>
                <asp:BoundField DataField="Sender" HeaderText="Sent By" />
                <asp:CommandField ButtonType="Button" SelectText="ACCEPT" ShowCancelButton="False" ShowSelectButton="True" />
                <asp:CommandField ButtonType="Button" SelectText="DECLINE" ShowCancelButton="False" ShowSelectButton="True" />
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
        </asp:GridView>
        <br />
        <h1>DATE REQUESTS SENT</h1>
        <asp:GridView ID="gvSent" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" EmptyDataText="None at this time">
            <Columns>
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
