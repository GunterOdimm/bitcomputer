<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="04_WebFormEventPage.aspx.cs" Inherits="WebApplication1._04_WebFormEventPage" %>

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
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
            <%-- 각종 이벤트는 보기에 도구상자에서 끌어올수도 있다. --%>
            <%-- 물론 직접 타이핑도 가능해진다. --%>
            <%-- OnClick으로 버튼이 클릭시 이벤트가 가능해지고 --%>
            <%-- 직접 이 기능을 하나하나 코드로 작성도 가능하다. --%>
        </div>
    </form>
</body>
</html>
