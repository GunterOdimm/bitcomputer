<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="18_WebFormLabel.aspx.cs" Inherits="WebApplication1._18_WebFormLabel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Label 컨트롤 예제</h3>
            <asp:Label ID="Label1" runat="server" Text="이름(N)" AccessKey="N" AssociatedControlID="TextBox1"></asp:Label>
            <%-- Accesskey 키는 단축키를 만들어준다. 이는 alt키 + 할당된 키 --%>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" AccessKey="0" AssociatedControlID="Button1"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Button(0)" OnClick="Button1_Click" />
            <br /><br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
