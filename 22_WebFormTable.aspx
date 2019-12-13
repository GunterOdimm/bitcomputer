<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="22_WebFormTable.aspx.cs" Inherits="WebApplication1._22_WebFormTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3 style="padding-left:50%">Table 컨트롤 예제</h3>
            <asp:Table ID="Table1" runat="server" CellPadding="5" CellSpacing="0" GridLines="Both" BorderWidth="1">
            </asp:Table>
            <br />
            행의 수 :
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">1 행</asp:ListItem>
                <asp:ListItem Value="2">2 행</asp:ListItem>
                <asp:ListItem Value="3">3 행</asp:ListItem>
                <asp:ListItem Value="4">4 행</asp:ListItem>
            </asp:DropDownList>
            셀의 수:
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="1">1 셀</asp:ListItem>
                <asp:ListItem Value="2">2 셀</asp:ListItem>
                <asp:ListItem Value="3">3 셀</asp:ListItem>
                <asp:ListItem Value="4">4 셀</asp:ListItem>
            </asp:DropDownList>&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="테이블 생성" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
