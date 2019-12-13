<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="10_WebFormCheck.aspx.cs" Inherits="WebApplication1._10_WebFormCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>CheckBox 컨트롤 예제</h3>

            <h4>1. 좋아하는 스포츠를 고르세요.</h4>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="야구" /><br />
            <%-- 체크 박스는 무조건 postback을 호출하지를 않는다는 특징이 존재한다. --%>
            <asp:CheckBox ID="CheckBox2" runat="server" Text="축구" TextAlign="Left"/><br />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="농구" Enabled="false"/><br />
            <asp:Button ID="Button1" runat="server" Text="선택" OnClick="Button_Click" /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

            <h4>2. 메일링 가입 여부 체크</h4>
            <asp:CheckBox ID="CheckBox4" runat="server" Text="메일링 가입" AutoPostBack="true" OnCheckedChanged="CheckBox4_CheckedChanged" /><br />
            <%-- 여기서는 강제로 autoPostBack을 걸어준것 이거 안해두면 안된다. --%>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
