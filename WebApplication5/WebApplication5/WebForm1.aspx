<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Order Number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server">1</asp:TextBox>
        </p>
        <p>
            OrderDate<asp:TextBox ID="TextBox1" runat="server">6/5/2019</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Calender" />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
        </p>
        <p>
            CustomerName
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            Items</p>
        <p>
            The Item<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="0">Zinger</asp:ListItem>
                <asp:ListItem Value="1">Burger</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Price <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            qty<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save And New" />
        </p>
        <p>
            Total Amount
            <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Bulling" />
        </p>
    </form>
</body>
</html>
