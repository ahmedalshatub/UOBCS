<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication5.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Order Number:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        OrderDate:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        CustomerName:<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        Total Amount:<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
