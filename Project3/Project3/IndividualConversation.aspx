<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndividualConversation.aspx.cs" Inherits="Project3.IndividualConversation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>YOUR CONVERSATION</h1>
        <asp:GridView ID="gvMessages" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" ShowHeader="False">
            <Columns>
                <asp:BoundField DataField="Sender" />
                <asp:BoundField DataField="Content" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnDelete" runat="server" Text="DELETE" />
                    </ItemTemplate>
                </asp:TemplateField>
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
    
        <br />
    
    </div>
        <asp:TextBox ID="txtSendMessage" runat="server"></asp:TextBox>
        <asp:Button ID="btnSendMessage" runat="server" Text="Send Message" OnClick="btnSendMessage_Click" />
        <asp:RequiredFieldValidator ID="ValSendMessage" runat="server" ControlToValidate="txtSendMessage" ErrorMessage="Required">*</asp:RequiredFieldValidator>
    </form>
</body>
</html>
