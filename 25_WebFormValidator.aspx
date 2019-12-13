<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="25_WebFormValidator.aspx.cs" Inherits="WebApplication1._25_WebFormValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>RequiredFieldValidator 컨트롤 예제</h3>
            아이디 : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ReqruredFieldValidator1" runat="server" ErrorMessage ="아이디를 입력하세요." ControlToValidate="TextBox1">
                <%-- RequiredFieldValidator는 가르키는 필드에 어떤 값이라도 존재해야한다. --%>
            </asp:RequiredFieldValidator>
            <br />
            비밀번호 : <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ReqruredFieldValidator2" runat="server" ErrorMessage="비밀 번호를 입력하세요." ControlToValidate="TextBox2">

            </asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
