<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="08_WebFormCalender.aspx.cs" Inherits="WebApplication1._08_WebFormCalender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>SelectionChanged 이벤트를 사용한 예제1.</h3>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" SelectionMode="Day">
            </asp:Calendar>
            <h3>SelectionChanged 이벤트를 사용한 예제2.</h3>
            <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged" SelectionMode="DayWeekMonth">
            </asp:Calendar>
            <h3>SelectionChanged 이벤트를 사용한 예제3.</h3>
            <asp:Calendar ID="Calendar3" runat="server" OnSelectionChanged="Calendar3_SelectionChanged" SelectionMode="DayWeek">
            </asp:Calendar>
            <h3>SelectionChanged 이벤트를 사용한 예제4.</h3>
            <asp:Calendar ID="Calendar4" runat="server" OnSelectionChanged="Calendar4_SelectionChanged" SelectionMode="None" BackColor="#FFFFCC">
            </asp:Calendar>
        </div>
    </form>
</body>
</html>
