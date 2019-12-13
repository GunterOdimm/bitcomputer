using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _06_WebFormNewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.PreviousPage != null)
                // 전의 페이지게 존재한다면 넘어온다.
            {
                TextBox myTextBox = (TextBox)Page.PreviousPage.FindControl("TextBox1");
                // 전에 있었던 페이지의 textBox1에서 값을 가지고 온다.
                Response.Write("페이지 간 게시 : " + myTextBox.Text);
            }
            else
            // 전의 페이지가 없다면 넘어온다( 간단하게 그냥 바로 이페이지를 켜면 에러가 뜨게 한다. )
            {
                Response.Write("페이지 간 게시가 아닙니다");
            }
        }
    }
}