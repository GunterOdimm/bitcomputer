<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="24_WebFormXML.aspx.cs" Inherits="WebApplication1._24WebFormXML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Xml ID ="xml1" DocumentSource="~/24-1_person.xml" TransformSource="~/24-2_person.xslt" runat="server" />
        </div>
    </form>
</body>
</html>
