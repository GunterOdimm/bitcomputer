using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _14_WebFormHiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(HiddenField1.Value == "") // 빈문자 열이라면
             HiddenField1.Value = "0"; // 보안 코드 작동.

            int count = int.Parse(HiddenField1.Value) + 1;
            // 기존의 값에 다가 1을 더함
            HiddenField1.Value = count.ToString();
            // 연산한 결과를 다시 히든 필드에 저장(상태 저장)
            Label1.Text = "버튼 클릭 수 : " + HiddenField1.Value;
        }
    }
}