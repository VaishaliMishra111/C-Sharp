<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="WebApplication1.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="bodytag" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ViewStateData"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

        </div>
        <asp:DropDownList ID="colorselector" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>red</asp:ListItem>
            <asp:ListItem>pink</asp:ListItem>
            <asp:ListItem>green</asp:ListItem>
            <asp:ListItem>blue</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
