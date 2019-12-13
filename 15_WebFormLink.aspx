<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="15_WebFormLink.aspx.cs" Inherits="WebApplication1._15_WebFormLink" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat ="server" NavigateUrl="https://mycast.xyz" Text="마이캐스트 홈페이지로 이동"></asp:HyperLink>
            <br /><br />
            <asp:HyperLink ID="HyperLink2" runat="server" ImageUrl ="http://img.gqkorea.co.kr/gq/2016/05/style_574291adc4d9a.jpg" NavigateUrl="http://Microsoft.co.kr" Target="_blank"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
