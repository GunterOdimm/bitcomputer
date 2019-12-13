<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="07_WebFormBulletedList.aspx.cs" Inherits="WebApplication1._07_WebFormBulletedList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style ="text-align : center">
            <div style="float:left; padding-right: 20px;">
                <h3>Disc</h3>
                <asp:BulletedList ID="BulletedList1" runat="server">
                    <asp:ListItem>Item1</asp:ListItem>
                    <asp:ListItem>Item2</asp:ListItem>
                    <asp:ListItem>Item3</asp:ListItem>
                    <asp:ListItem>Item4</asp:ListItem>
                    <%-- Bulleted List의 사전적 정의는 글머리 기호이다.
                         DisplayMode를 설정해줌으로써 글자별 속성을 넣어 줄수 있다.
                         BulletStyle 을 사용해서 글머리를 바꿔줄수도 있다. --%>
                </asp:BulletedList>
            </div>
            <div style="float:left; padding-right: 20px;">
                <h3>Circle</h3>
                <asp:BulletedList ID="BulletedList2" BulletStyle ="Circle" DisplayMode="HyperLink" runat="server">
                    <asp:ListItem Value="http://www.naver.com">Item1</asp:ListItem>
                    <asp:ListItem Value="http://www.daum.net">Item2</asp:ListItem>
                    <asp:ListItem Value="http://www.google.com">Item3</asp:ListItem>
                    <asp:ListItem Value="http://www.nate.com">Item4</asp:ListItem>
                </asp:BulletedList>
            </div>
             <div style="float:left; padding-right:20px;">
                <h3>Square</h3>
                <asp:BulletedList ID="BulletedList3" BulletStyle="Square" DisplayMode="LinkButton" runat="server" OnClick="BulletedList3_Click">  
                    <asp:ListItem Value="Item1 Value">Item1</asp:ListItem>
                    <asp:ListItem>Item2</asp:ListItem>
                    <asp:ListItem>Item3</asp:ListItem>
                    <asp:ListItem>Item4</asp:ListItem>
                    <%-- 여기서의 value값은 특별한 이유로 집어넣은것은 아니다. 그냥 이런식으로 삽입이 가능하다는것을 증명하기 위해서 이다. --%>
                </asp:BulletedList>
            </div>
            <div style="float:left; padding-right: 20px">
                <h3>Numbered</h3>
                <asp:BulletedList ID="BulletedList4" BulletStyle="Numbered" FirstBulletNumber="3" runat="server">
                    <asp:ListItem>Item1</asp:ListItem>
                    <asp:ListItem>Item2</asp:ListItem>
                    <asp:ListItem>Item3</asp:ListItem>
                    <asp:ListItem>Item4</asp:ListItem>
                </asp:BulletedList>
            </div>
        </div>
    </form>
</body>
</html>
