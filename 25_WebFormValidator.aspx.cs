using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _25_WebFormValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // 브라우저의 보안 때문에 자바 스크립트를 끄면 이게 이제 활성화 되는것
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
                Label1.Text = "유효성 검사가 완료되었습니다.";
            else
                Label1.Text = "유효하지 않은 정보가 존재합니다.";
        }
    }
}