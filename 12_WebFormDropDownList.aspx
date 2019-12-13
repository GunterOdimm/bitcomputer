<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="12_WebFormDropDownList.aspx.cs" Inherits="WebApplication1._12_WebFormDropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>DropDownLIst 컨트롤 예제</h3>
            <asp:DropDownList ID ="DropDownList1" runat="server">

            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /><br />
            <asp:Label Id="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
