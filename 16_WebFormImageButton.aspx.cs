using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _16_WebFormImageButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Label1.Text = String.Format("X : {0}, Y : {1}", e.X, e.Y);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

            Label1.Text = "<아이린> 버튼이 클릭되었습니다.";
        }
    }
}