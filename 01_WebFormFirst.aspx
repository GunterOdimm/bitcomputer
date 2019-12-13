<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01_WebFormFirst.aspx.cs" Inherits="WebApplication1._01_WebHomeFirst" %>

<!DOCTYPE html>
<%-- html5타입을 이야기한다. --%>
<%--<script runat ="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("현재 시간은 : " + DateTime.Now.ToLongTimeString());
    }
</script>--%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>이 부분은 타이틀 부분 입니다.</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            이부분은 body타입 입니다.
        </div>
    </form>
</body>
<footer>
</footer>
</html>
