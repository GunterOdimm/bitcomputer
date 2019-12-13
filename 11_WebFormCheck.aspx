<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="11_WebFormCheck.aspx.cs" Inherits="WebApplication1._11_WebFormCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>CheckBoxList 컨트롤 예제</h3>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem value="1">Item1</asp:ListItem>
            <asp:ListItem value="2" Text="Item2"></asp:ListItem>
            <asp:ListItem value="3" Enabled="false">Item3</asp:ListItem>
            <asp:ListItem value="4" Selected="true">Item4</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="Button1" runat="server" Text ="확인" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Test=""></asp:Label>
        </div>
    </form>
</body>
</html>
