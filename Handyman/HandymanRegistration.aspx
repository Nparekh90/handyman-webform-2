<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HandymanRegistration.aspx.cs" Inherits="Handyman.HandymanRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtFirstName" runat="server" Width="132px">First Name</asp:TextBox>
            <br />
            <asp:TextBox ID="txtLastName" runat="server" Width="133px">Last Name</asp:TextBox>
            <br />
            <asp:TextBox ID="txtPhone" runat="server" Width="132px">Phone Number</asp:TextBox>
            <br />
            <asp:TextBox ID="txtArea" runat="server" Width="131px">Area</asp:TextBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            <br />
        </div>
    </form>
</body>
</html>
