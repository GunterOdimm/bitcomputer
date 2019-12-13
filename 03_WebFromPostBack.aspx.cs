using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _03_WebFromPostBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Response.Write("다시 게시 되었습니다.");
            }
            else
            {
                Response.Write("웹 페이지가 처음 요청 되었습니다.");
            }
        }
    }
}