<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="17_WebFormImageMap.aspx.cs" Inherits="WebApplication1._17_WebFormImageMap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>ImageMap 컨트롤 예제</h3>
            <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="http://dn.joongdo.co.kr/mnt/images/file/2019y/02m/18d/20190218001422249_1.jpg" Height="500px" OnClick="ImageMap1_Click" BorderWidth="0px">
                <asp:RectangleHotSpot HotSpotMode="PostBack" PostBackValue="HotSpot1" AlternateText="HotSpot1" Top="30" Left ="175" Bottom="110" Right="355" />
                <asp:RectangleHotSpot HotSpotMode="PostBack" PostBackValue="HotSpot2" AlternateText="HotSpot2" Top="155" Left ="175" Bottom="240" Right="355" />
                <asp:RectangleHotSpot HotSpotMode="Navigate" NavigateUrl="https://mycast.xyz" AlternateText="HotSpot3" Top="285" Left="175" Bottom="365" Right="355" />
                <asp:RectangleHotSpot HotSpotMode="PostBack" PostBackValue="BackGround" AlternateText="BackGround" Top="0" Left ="0" Bottom="390" Right="540" />

            </asp:ImageMap>
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
