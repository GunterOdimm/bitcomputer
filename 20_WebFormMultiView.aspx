<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="20_WebFormMultiView.aspx.cs" Inherits="WebApplication1._20_WebFormMultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>MultiView 컨트롤과 예제</h3>
            <asp:DropDownList Id="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>View1</asp:ListItem>
                <asp:ListItem>View2</asp:ListItem>
            </asp:DropDownList>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <%-- ActiveViewIndex는 최초로 보여줄 인덱스 값을 설정한다 없다면 따로 초기화면에 나오지 않는다. --%>
                <asp:View ID="View1" runat="server">
                    View1<br />
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    View2<br />
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/633002_328433_428.gif" Height="500px" margin="auto" />
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
