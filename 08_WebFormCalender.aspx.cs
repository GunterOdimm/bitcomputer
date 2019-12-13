using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _08_WebFormCalender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Response.Write("선택한 날짜 : " + Calendar1.SelectedDate.ToShortDateString());
        }

        protected void Calendar3_SelectionChanged(object sender, EventArgs e)
        {
            Response.Write("선택한 날짜 : " + Calendar3.SelectedDate.ToShortDateString());

        }

        protected void Calendar4_SelectionChanged(object sender, EventArgs e)
        {
            Response.Write("선택한 날짜 : " + Calendar4.SelectedDate.ToShortDateString());

        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            Response.Write("선택한 날짜 : " + Calendar2.SelectedDate.ToShortDateString());
        }
    }
}