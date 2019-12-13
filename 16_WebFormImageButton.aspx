<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="16_WebFormImageButton.aspx.cs" Inherits="WebApplication1._16_WebFormImageButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>ImageButton 컨트롤 예제</h3>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="http://img.gqkorea.co.kr/gq/2016/05/style_574291adc4d9a.jpg" OnClick="ImageButton1_Click" Height ="500px" /><br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br /><br />
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Image/633002_328433_428.gif" OnClick="ImageButton2_Click" Height ="500px" />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
