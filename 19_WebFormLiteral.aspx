<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="19_WebFormLiteral.aspx.cs" Inherits="WebApplication1._19_WebFormㅣㅑㅅㄷㄱ미" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Literal 컨트롤 예제</h3>
            <asp:Literal ID="Literal1" runat="server" Text="<hr />"></asp:Literal>
            <asp:Literal ID="Literal2" runat="server" Text="<hr1 />" Mode="Encode"></asp:Literal>
            <%-- Encode는 HTML코드를 강제로 작동 시키지 못하게 합니다. --%>

        </div>
    </form>
</body>
</html>
