<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="05_WebFormOtherPage.aspx.cs" Inherits="WebApplication1._05_WebFormOtherPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="다시 게시" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat ="server" Text="페이지간  게시" OnClick="Button2_Click" PostBackUrl ="~/06_WebFormNewPage.aspx" />
        </div>
    </form>
</body>
</html>
