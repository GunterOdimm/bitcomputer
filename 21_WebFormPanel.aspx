<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="21_WebFormPanel.aspx.cs" Inherits="WebApplication1._21_WebFormPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Panel</h3>
            <asp:Button ID="Button1" runat="server" Text="Panel1 보임" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Panel1 안보임" OnClick="Button2_Click" />
            <br /><br />
            <asp:Panel ID="Panel1" runat="server" Height="47px" Width="130px" BackColor="YellowGreen">
                <asp:TextBox ID="TextBox1" runat="server" Width="125px" ></asp:TextBox>
                <asp:Button ID="Button3" runat="server" Text="Button" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
