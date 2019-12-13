using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _07_WebFormBulletedList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BulletedList3_Click(object sender, BulletedListEventArgs e)
        {
            Response.Write("선택한 항목의 인덱스 : " + e.Index.ToString() + "<br/>선택한 항목의 Value : " + BulletedList3.Items[e.Index].Value + "<br/> 선택한 항목의 텍스트 : " + BulletedList3.Items[e.Index].Text);
        }
    }
}