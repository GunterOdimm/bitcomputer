<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="09_WebFormDayRender.aspx.cs" Inherits="WebApplication1._09_WebFormDayRender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender" ShowGridLines="true" Width="500px" DayStyle-Height="30px" VisibleDate="2019-5-11" ></asp:Calendar>
        </div>
    </form>
</body>
</html>
