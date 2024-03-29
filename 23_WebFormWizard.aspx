﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="23_WebFormWizard.aspx.cs" Inherits="WebApplication1._23_WebFormWizard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Wizrd 컨트롤 예제</h3>
            <asp:Wizard ID="Wizard1" runat="server" OnFinishButtonClick="Wizard1_FinishButtonClick" CellPadding="5" Width="400">
                <WizardSteps>
                    <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
                        <h4>물품 선택</h4>
                        <p>
                            잭필드 남성 면바지 3종 세트:
                            <asp:TextBox ID="TextBox1" runat="server" Text="1" Columns="3"></asp:TextBox> 개
                            <br />
                            진미령 간장 게장:
                            <asp:TextBox ID="TextBox2" runat="server" Text="1" Columns="3"></asp:TextBox> 개
                        </p>
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
                        <h4>주소 입력</h4>
                        <p>
                            주소: <asp:TextBox ID="TextBox3" runat="server" Width="200"></asp:TextBox>
                        </p>
                    </asp:WizardStep>
                    <asp:WizardStep ID="WizardStep3" runat="server" Title ="Step 3" StepType="Complete">
                        <h4>주문 확인</h4>
                        <p>
                            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                        </p>
                    </asp:WizardStep>
                </WizardSteps>
            </asp:Wizard>
        </div>
    </form>
</body>
</html>
